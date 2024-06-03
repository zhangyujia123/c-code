using Newtonsoft.Json;
using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhaoxi.IntelligentShoppingCenter.Models;
using Zhaoxi.IntelligentShoppingCenter.Utils;
using Zhaoxi.Utils;

namespace Zhaoxi.IntelligentShoppingCenter
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(CommonHelper.dirFile))
            {
                Directory.CreateDirectory(CommonHelper.dirFile);
            }
            if (CommonHelper.plcInfo == null)
            {
                //初始化设置
                cboCpuTypes.SelectedIndex = 0;
                txtIP.Clear();
                txtPort.Text = "102";
                txtRack.Text = "0";
                txtSlot.Text = "0";
            }
            else
            {
                var info = CommonHelper.plcInfo;
                cboCpuTypes.SelectedItem = info.CpuType.ToString();
                txtIP.Text = info.Ip;
                txtPort.Text = info.Port.ToString();
                txtRack.Text = info.Rack.ToString();
                txtSlot.Text = info.Slot.ToString();
            }
            //如果有楼层信息，则加载下拉框
            if (CommonHelper.floorList.Count > 0)
            {
                ReloadCboFloors();
            }
        }

        private void ReloadCboFloors()
        {
            cboFloors.DisplayMember = "FloorName";
            cboFloors.ValueMember = "FloorNo";
            cboFloors.DataSource = CommonHelper.floorList;
            cboFloors.SelectedIndex = 0;
        }

        //提交PLC通信设置
        private void btnPLCSave_Click(object sender, EventArgs e)
        {
            //信息接收
            string cpuType = cboCpuTypes.Text.Trim();
            string ip = txtIP.Text.Trim();
            string port = txtPort.Text.Trim();
            string rack = txtRack.Text.Trim();
            string slot = txtSlot.Text.Trim();
            //信息检查
            if (string.IsNullOrEmpty(ip))
            {
                MessageHelper.Error("PLC设置", "请输入通信的IP地址！");
                return;
            }
            if (string.IsNullOrEmpty(port))
            {
                MessageHelper.Error("PLC设置", "请输入通信的端口号！");
                return;
            }
            if (string.IsNullOrEmpty(rack))
            {
                MessageHelper.Error("PLC设置", "请输入机架号！");
                return;
            }
            if (string.IsNullOrEmpty(slot))
            {
                MessageHelper.Error("PLC设置", "请输入插槽号！");
                return;
            }
            //写入配置文件---txt
            string plcString = $"CpuType:{cpuType};Ip:{ip};port:{port};rack:{rack};slot:{slot}";
            File.WriteAllText(CommonHelper.communicatePath, plcString);
            MessageHelper.Success("PLC设置", "PLC设置保存成功！");
            //重新封装到plcInfo中
            CommonHelper.plcInfo = new Models.PLCSetInfo()
            {
                CpuType = Enum.Parse<CpuType>(cpuType),
                Ip = ip,
                Port = port.GetInt(),
                Rack = rack.GetShort(),
                Slot = slot.GetShort()
            };
            //重新创建plc实例
            CommonHelper.CreatePlc();
        }

        //楼层提交 ----新增、修改
        private void btnFloorSave_Click(object sender, EventArgs e)
        {
            //信息接收
            int floorNo = txtFloorNo.Text.GetInt();
            string floorName = txtFloorName.Text.Trim();
            //信息检查
            if (floorNo == 0)
            {
                MessageHelper.Error("楼层信息", "请输入大于0的楼层编号！");
                return;
            }
            if (string.IsNullOrEmpty(floorName))
            {
                MessageHelper.Error("楼层信息", "请输入楼层名称！");
                return;
            }
            //信息封装
            FloorInfo floor = null;
            if (CommonHelper.floorList.Count > 0)
            {
                floor = CommonHelper.floorList.Find(f => f.FloorNo == floorNo);
            }
            bool isUpdate = false;//是否新增了楼层或修改了楼层名
            if (floor != null)
            {
                //更新
                int index = CommonHelper.floorList.FindIndex(f => f.FloorNo == floorNo);
                if (floor.FloorName != floorName)
                {
                    //修改的楼层名
                    floor.FloorName = floorName;
                    CommonHelper.floorList[index].FloorName = floorName;
                    isUpdate = true;
                }
            }
            else  //null
            {
                floor = new FloorInfo() { FloorNo = floorNo, FloorName = floorName };
                CommonHelper.floorList.Add(floor);
                isUpdate = true;
            }
            //写入文件
            if (isUpdate)
            {
                string json = JsonConvert.SerializeObject(CommonHelper.floorList);
                File.WriteAllText(CommonHelper.floorFilePath, json);
                MessageHelper.Success("楼层保存", "楼层保存成功！");
                cboFloors.DataSource = null;
                ReloadCboFloors();
                CommonHelper.IsFloorUpdated = true;
            }

        }

        //商铺参数配置导入--excel文件
        private void btnParaImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files(*.xlsx)|*.xlsx|Excel Files 2003 (*.xls)|*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;//文件名
                DataTable dt = ExcelHelper.ExcelToDataTable(fileName, "Sheet1", true);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ShopsSetInfo setInfo = new ShopsSetInfo();
                        setInfo.ShopsNo = dr["商铺编号"].ToString().GetInt();
                        string stateAddrs = dr["状态地址"].ToString().Trim();
                        if (!string.IsNullOrEmpty(stateAddrs))
                        {
                            string[] addrs = stateAddrs.Split(",");
                            setInfo.RunAddr = addrs[0];
                            setInfo.FSAddr = addrs[1];
                            setInfo.IsOpenedAddr = addrs[2];
                            setInfo.PSAddr = addrs[3];
                            setInfo.LSAddr = addrs[4];
                        }
                        string dataAddrs = dr["数据地址"].ToString().Trim();
                        if (!string.IsNullOrEmpty(dataAddrs))
                        {
                            string[] addrs = dataAddrs.Split(",");
                            setInfo.RTemperAddr = addrs[0];
                            setInfo.RHumidityAddr = addrs[1];
                            setInfo.CurPReadAddr = addrs[2];
                            setInfo.LastPReadAddr = addrs[3];
                        }
                        ShopsSetInfo oldInfo = CommonHelper.shopsSetList.Find(s => s.ShopsNo == setInfo.ShopsNo);
                        if (oldInfo == null)
                        {
                            CommonHelper.shopsSetList.Add(setInfo);
                        }
                        else
                        {
                            oldInfo.RunAddr = setInfo.RunAddr;
                            oldInfo.FSAddr = setInfo.FSAddr;
                            oldInfo.IsOpenedAddr = setInfo.IsOpenedAddr;
                            oldInfo.PSAddr = setInfo.PSAddr;
                            oldInfo.LSAddr = setInfo.LSAddr;
                            oldInfo.RTemperAddr = setInfo.RTemperAddr;
                            oldInfo.RHumidityAddr = setInfo.RHumidityAddr;
                            oldInfo.CurPReadAddr = setInfo.CurPReadAddr;
                            oldInfo.LastPReadAddr = setInfo.LastPReadAddr;
                        }
                    }
                    //写入文件---json
                    SaveSetInfosToFile();
                    MessageHelper.Success("导入参数信息", "商铺参数配置信息导入成功！");
                }
                else
                {
                    MessageHelper.Error("导入参数信息", "没有提供商铺参数配置数据！");
                    return;
                }

            }
        }

        private void SaveSetInfosToFile()
        {
            string json = JsonConvert.SerializeObject(CommonHelper.shopsSetList);
            if (!Directory.Exists(CommonHelper.dirFile))
            {
                Directory.CreateDirectory(CommonHelper.dirFile);
            }
            File.WriteAllText(CommonHelper.shopsSetFilePath, json);
            CommonHelper.IsSetInfosUpdated = true;
        }

        //选择楼层加载商铺下拉框
        private void cboFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFloors.SelectedValue != null)
            {
                if (CommonHelper.shopsList.Count > 0)
                {
                    int floorNo = cboFloors.SelectedValue.ToString().GetInt();
                    var curShopsList = CommonHelper.shopsList.Where(s => s.FloorNo == floorNo).ToList();//筛选当前楼层的商铺列表
                    if (curShopsList.Count > 0)
                    {
                        cboShops.DisplayMember = "ShopsName";
                        cboShops.ValueMember = "ShopsNo";
                        cboShops.DataSource = curShopsList;
                        cboShops.SelectedIndex = 0;
                    }
                    else
                    {
                        cboShops.DataSource = null;
                    }
                }
            }
        }

        //选择商铺，加载参数配置信息
        private void cboShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShops.SelectedValue != null)
            {
                int shopsNo = cboShops.SelectedValue.ToString().GetInt();//商铺编号
                ShopsSetInfo setInfo = CommonHelper.shopsSetList.Find(s => s.ShopsNo == shopsNo);//查找商铺的参数信息
                if (setInfo != null)
                {
                    txtStateAddrs.Text = setInfo.RunAddr + "," + setInfo.FSAddr + "," + setInfo.IsOpenedAddr + "," + setInfo.PSAddr + "," + setInfo.LSAddr;
                    txtDataAddrs.Text = setInfo.RTemperAddr + "," + setInfo.RHumidityAddr + "," + setInfo.CurPReadAddr + "," + setInfo.LastPReadAddr;
                }
                else
                {
                    txtStateAddrs.Text = "";
                    txtDataAddrs.Text = "";
                }
            }
        }

        //商铺参数配置的提交
        private void btnParaSave_Click(object sender, EventArgs e)
        {
            //接收信息、信息检查、    信息封装
            int shopsNo = 0;
            if(cboShops.SelectedValue!=null)
            {
                shopsNo=cboShops.SelectedValue.ToString().GetInt();
            }
            else
            {
                MessageHelper.Error("参数配置", "请选择商铺！");
                return;
            }
            string stateAddrs = txtStateAddrs.Text.Trim();
            string dataAddrs=txtDataAddrs.Text.Trim();
            ShopsSetInfo setInfo = new ShopsSetInfo();
            setInfo.ShopsNo = shopsNo;
            if(!string.IsNullOrEmpty(stateAddrs))
            {
                string[] addrs = stateAddrs.Split(",");
                setInfo.RunAddr = addrs[0];
                setInfo.FSAddr = addrs[1];
                setInfo.IsOpenedAddr = addrs[2];
                setInfo.PSAddr = addrs[3];
                setInfo.LSAddr = addrs[4];
            }
            else
            {
                MessageHelper.Error("参数配置", "请设置商铺相关的状态地址！");
                return;
            }
            if(!string.IsNullOrEmpty(dataAddrs))
            {
                string[] addrs = dataAddrs.Split(",");
                setInfo.RTemperAddr = addrs[0];
                setInfo.RHumidityAddr = addrs[1];
                setInfo.CurPReadAddr = addrs[2];
                setInfo.LastPReadAddr = addrs[3];
            }
            else
            {
                MessageHelper.Error("参数配置", "请设置商铺相关的数据地址！");
                return;
            }
            //保存到列表
            int index = CommonHelper.shopsSetList.FindIndex(s => s.ShopsNo == shopsNo);
            if(index == -1)
            {
                CommonHelper.shopsSetList.Add(setInfo);//新增
            }
            else
            {
                CommonHelper.shopsSetList[index] = setInfo;//更新
            }
            //写入文件中
            SaveSetInfosToFile();
            MessageHelper.Success("参数配置", "商铺参数配置保存成功！");
        }
    }
}
