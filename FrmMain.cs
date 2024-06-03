using Newtonsoft.Json;
using S7.Net;
using System.Data;
using Zhaoxi.IntelligentShoppingCenter.Models;
using Zhaoxi.IntelligentShoppingCenter.UControls;
using Zhaoxi.IntelligentShoppingCenter.Utils;
using Zhaoxi.Utils;

namespace Zhaoxi.IntelligentShoppingCenter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 窗体尺寸调整
        const int WM_NCHITTEST = 0x0084;// 移动鼠标
        const int VM_Clear = 0x0014;
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (this.MaximizeBox == true && this.WindowState == FormWindowState.Normal)
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF,
              (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        if (vPoint.X <= 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else m.Result = (IntPtr)HTLEFT;
                        else if (vPoint.X >= ClientSize.Width - 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)HTTOPRIGHT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            else m.Result = (IntPtr)HTRIGHT;
                        else if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOP;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOM;
                    }
                    break;

            }
        }
        #endregion

        #region 窗口控制
        //最小化
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //最大化与正常之间的切换
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;//切换到Normal状态
                btnMax.Text = "1";
            }
            else
            {
                MaximumSize = Screen.AllScreens[0].WorkingArea.Size;//主屏幕的工作区尺寸
                WindowState = FormWindowState.Maximized;//切换到最大化状态
                btnMax.Text = "2";
            }
        }
        //关闭----系统退出
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.Question("系统退出", "你确定要退出系统吗？") == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
        #endregion

        #region 窗口的拖动
        Point point = new Point();//开始按住点
        bool isMoving = false;//是否在正拖动中
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//当前按下的位置
            isMoving = true;//启动拖动
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNew;
            if (e.Button == MouseButtons.Left && isMoving)
            {
                pointNew = e.Location;//目标位置
                Point pPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//平移的距离
                this.Location += new Size(pPointNew);//窗体的平移
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//停止拖动
        }
        #endregion

        Plc plc = null;//plc实例
        System.Timers.Timer timeTimer = null;//动态时间
        System.Timers.Timer readTimer = null;//定时采集
        FloorInfo selFloor = null;//当前选择楼层
        List<ShopsInfo> selShopsList = new List<ShopsInfo>();//当前楼层的商铺列表
        List<int> selShopsIds = new List<int>();//当前楼层的商铺编号集合
        List<ShopsSetInfo> selSetList = new List<ShopsSetInfo>();//存储当前楼层的商铺参数列表
        Dictionary<int, ShopsData> dicDatas = new Dictionary<int, ShopsData>();
        //初始化加载 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //plc通信设置初始化
            InitCommunication();
            //楼层信息列表加载
            CommonHelper.LoadFloorList();
            //商铺信息列表
            CommonHelper.LoadShopsList();
            //参数信息列表
            CommonHelper.LoadShopsSetList();
            //定时器初始化
            InitTimers();
            //界面信息初始化
            InitInfo();
            //统计商场总体数据
            StatisticsShopsData();
            //楼层导航栏加载
            LoadFloorNavList();
        }


        private void InitCommunication()
        {
            //调用通信设置加载方法
            CommonHelper.LoadPLCSet();
            var plcInfo = CommonHelper.plcInfo;
            if (plcInfo == null)
            {
                MessageHelper.Error("通信初始化", "请先进行PLC通信设置！");
                return;
            }
            else
            {
                //创建plc实例
                CommonHelper.CreatePlc();
                plc = CommonHelper.plc;
            }
        }

        private void InitInfo()
        {
            panelNav.Controls.Clear();
            flpList.Controls.Clear();
            panelShopInfo.Visible = false;
            numTotalCount.Value = 0;
            numRunningCount.Value = 0;
            numUnCount.Value = 0;
            lblSelFloor.Text = "";
            numFloorTotalCount.Value = 0;
            numFloorRunningCount.Value = 0;
            numFloorUnCount.Value = 0;
        }

        private void InitTimers()
        {
            timeTimer = new System.Timers.Timer();
            timeTimer.Interval = 1000;
            timeTimer.AutoReset = true;
            timeTimer.Elapsed += TimeTimer_Elapsed;
            timeTimer.Start();

            readTimer = new System.Timers.Timer();
            readTimer.Interval = 1000;
            readTimer.AutoReset = true;
            readTimer.Elapsed += ReadTimer_Elapsed;
        }
        //总体数据统计
        private void StatisticsShopsData()
        {
            int totalCount = CommonHelper.shopsList.Count;//总商铺数
            int runningCount = CommonHelper.shopsList.Where(s => s.IsRunning).Count();//运营商铺数
            int unCount = totalCount - runningCount;//空闲数

            numTotalCount.Value = totalCount;
            numRunningCount.Value = runningCount;
            numUnCount.Value = unCount;
        }

        //楼层导航栏加载
        private void LoadFloorNavList()
        {
            if (CommonHelper.floorList.Count > 0)
            {
                panelNav.Controls.Clear();
                int left = 9, height0 = 20;
                for (int i = 0; i < CommonHelper.floorList.Count; i++)
                {
                    FloorInfo floor = CommonHelper.floorList[i];
                    Label lblLav = new Label();
                    lblLav.Name = "nav" + i;
                    lblLav.BackColor = Color.FromArgb(62, 95, 119);
                    lblLav.ForeColor = Color.White;
                    lblLav.Text = floor.FloorName;
                    lblLav.TextAlign = ContentAlignment.MiddleCenter;
                    lblLav.Size = new Size(199, 45);
                    lblLav.Location = new Point(left, height0 + i * 45);
                    lblLav.Tag = CommonHelper.floorList[i];
                    lblLav.Click += LblLav_Click;
                    panelNav.Controls.Add(lblLav);
                }
                //默认选择楼层：第一楼
                selFloor = CommonHelper.floorList[0];
                lblSelFloor.Text = selFloor.FloorName;//显示选择楼层名
                GetSelFloorShops();
                //楼层切换处理
                ChangeCurFloor();
            }
        }

        //楼层选择
        private void LblLav_Click(object sender, EventArgs e)
        {
            Label curNav = sender as Label;
            FloorInfo floor = curNav.Tag as FloorInfo;
            if (floor != null)
            {
                selFloor = floor;//选择楼层
                lblSelFloor.Text = floor.FloorName;
                GetSelFloorShops();
                //楼层切换效果处理
                ChangeCurFloor();
            }
        }

        //楼层切换效果处理
        private void ChangeCurFloor()
        {
            if (selFloor != null)
            {
                foreach (Control c in panelNav.Controls)
                {
                    Label lbl = c as Label;
                    FloorInfo floor = lbl.Tag as FloorInfo;
                    if (floor != null && floor.FloorNo == selFloor.FloorNo)
                    {
                        lbl.BackColor = Color.SteelBlue;
                        lbl.ForeColor = Color.Cyan;
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        lbl.BackColor = Color.FromArgb(62, 95, 119);
                        lbl.ForeColor = Color.White;
                        lbl.BorderStyle = BorderStyle.None;
                    }
                }

                //统计当前楼层的数据
                StatisticsFloorData();
                //加载当前楼层的商铺列表
                LoadFloorShopsList();
            }
        }


        //统计当前楼层的数据
        private void StatisticsFloorData()
        {
            int selFloorId = selFloor.FloorNo;//选择楼层编号
            int runCount = selShopsList.Where(s => s.IsRunning).Count();
            int unCount = selShopsList.Count - runCount;
            numFloorTotalCount.Value = selShopsList.Count;
            numFloorRunningCount.Value = runCount;
            numFloorUnCount.Value = unCount;
        }

        //加载当前楼层的商铺列表
        private void LoadFloorShopsList()
        {
            flpList.Controls.Clear();
            if (selShopsList.Count > 0)
            {
                foreach (var shop in selShopsList)
                {
                    ShopsSetInfo setInfo = selSetList.Find(s => s.ShopsNo == shop.ShopsNo);
                    if (setInfo != null)
                    {
                        //加载商铺
                        ShopsData shopData = new ShopsData();
                        shopData.ShopsNo = shop.ShopsNo;
                        shopData.ShopsName = shop.ShopsName;
                        shopData.RunState = shop.IsRunning;

                        UShopItem shopItem = new UShopItem();
                        shopItem.Margin = new Padding(3);
                        shopItem.BackColor = Color.FromArgb(20, 46, 56);
                        shopItem.BorderColor = Color.LightSteelBlue;
                        shopItem.InitData(shopData, setInfo);//初始化商铺信息与参数
                        shopItem.Name = "shop" + shop.ShopsNo;
                        shopItem.Size = new Size(190, 115);
                        //订阅选择事件
                        shopItem.ShopsSelected += ShopItem_ShopsSelected;
                        flpList.Controls.Add(shopItem);
                    }
                }
            }
        }
        UShopItem selShop = null;
        //商铺选择加载详情
        private void ShopItem_ShopsSelected(object sender, EventArgs e)
        {
            UShopItem shopsItem = (UShopItem)sender;
            shopsItem.IsSelected = true;
            selShop = shopsItem;
            if (!panelShopInfo.Visible)
            {
                panelShopInfo.Visible = true;
            }
            //刷新右侧的详情面板
            RefreshSelShopPanel(shopsItem);

        }

        private void RefreshSelShopPanel(UShopItem shopsItem)
        {
            int shopsNo = shopsItem.ShopsNo;
            lblSelshop.Text = shopsItem.ShopsName;
            ShopsSetInfo setInfo = shopsItem.ShopSet;
            if (dicDatas.ContainsKey(shopsNo))
            {
                ShopsData shopsData = dicDatas[shopsNo];
                swOpen.Checked = shopsData.OpenState;
                swFan.Checked = shopsData.FanState;
                swFan.Tag = setInfo.FSAddr;
                swEnergize.Checked = shopsData.PowerState;
                swEnergize.Tag = setInfo.PSAddr;
                swLight.Checked = shopsData.LighState;
                swLight.Tag = setInfo.LSAddr;
                txtCurPowerReads.Value = shopsData.CurPowerRead;
                txtLastPowerReads.Value = shopsData.LastPowerRead;
                txtTodayPowers.Value = shopsData.CurPowerRead - shopsData.LastPowerRead;
            }
            else
            {
                swOpen.Checked = false;
                swFan.Checked = false;
                swEnergize.Checked = false;
                swLight.Checked = false;
                swFan.Tag = setInfo.FSAddr;
                swEnergize.Tag = setInfo.PSAddr;
                swLight.Tag = setInfo.LSAddr;
                txtCurPowerReads.Value = 0;
                txtLastPowerReads.Value = 0;
                txtTodayPowers.Value = 0;
            }
        }


        //生成选择楼层的商铺列表和参数列表
        private void GetSelFloorShops()
        {
            selShopsList = CommonHelper.shopsList.Where(s => s.FloorNo == selFloor.FloorNo).ToList();//当前楼层的商铺信息列表
            selShopsIds = selShopsList.Select(s => s.ShopsNo).ToList();//当前楼层的商铺编号集合
            selSetList = CommonHelper.shopsSetList.Where(s => selShopsIds.Contains(s.ShopsNo)).ToList();
        }

        private void TimeTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    lblTime.Text = DateTime.Now.ToString("yyyy/MM/dd  HH:mm:ss");
                }));
            }
        }

        private void ReadTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //采集过程
            if (plc.IsConnected)
            {
                ReadAndLoadData();//定时采集与加载
            }
            else
            {
                MessageHelper.Error("实时采集", "PLC未连接");
                return;
            }
        }
        //定时采集与加载
        private void ReadAndLoadData()
        {
            //采集过程
            foreach (var setInfo in selSetList)
            {
                int shopsNo = setInfo.ShopsNo;
                ShopsInfo shop = selShopsList.Find(s => s.ShopsNo == shopsNo);//商铺信息
                if (shop != null)
                {
                    ShopsData shopsData = new ShopsData();
                    shopsData.ShopsNo = shopsNo;
                    shopsData.RunState = (bool)plc.Read(setInfo.RunAddr);//运营状态
                                                                         //if(shopsData.RunState)

                    shopsData.OpenState = (bool)plc.Read(setInfo.IsOpenedAddr);//开门状态
                    shopsData.PowerState = (bool)plc.Read(setInfo.PSAddr);//通电
                    shopsData.FanState = (bool)plc.Read(setInfo.FSAddr);//风机状态
                    shopsData.LighState = (bool)plc.Read(setInfo.LSAddr);//灯状态
                    shopsData.Temperature = ConverToDecimal((uint)plc.Read(setInfo.RTemperAddr));//温度值
                    shopsData.Humidity = (ushort)plc.Read(setInfo.RHumidityAddr);//湿度
                    shopsData.CurPowerRead = (ushort)plc.Read(setInfo.CurPReadAddr);//当前电量读数
                    shopsData.LastPowerRead = (ushort)plc.Read(setInfo.LastPReadAddr);//昨日用电数

                    if (dicDatas.ContainsKey(shopsNo))
                    {
                        dicDatas[shopsNo] = shopsData;
                    }
                    else
                    {
                        dicDatas.Add(shopsNo, shopsData);
                    }
                }
            }

            //加载
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    foreach (Control c in flpList.Controls)
                    {
                        UShopItem shopItem = c as UShopItem;
                        int shopsNo = shopItem.ShopsNo;
                        if (dicDatas.ContainsKey(shopsNo))
                        {
                            ShopsData shopsData = dicDatas[shopsNo];
                            shopItem.UpdateData(shopsData);//更新数据
                            //检测温湿度状态
                            CheckTHState(shopItem);
                            if (shopItem.IsSelected)
                            {
                                RefreshSelShopPanel(shopItem);
                            }

                        }
                    }
                }));
            }
        }
        //检测温湿度状态
        private void CheckTHState(UShopItem shopsItem)
        {
            decimal temperVal = shopsItem.Temperature;
            decimal humidityVal = shopsItem.Humidity;
            //温度状态
            int tState = -1;
            if (temperVal < 10)
            {
                tState = 0;//低温
            }
            else if (temperVal >= 10 && temperVal <= 25)
            {
                tState = 1;//正常
            }
            else
            {
                tState = 2;//高温
            }
            shopsItem.TState = tState;


            //湿度状态检测
            int hState = -1;
            if (humidityVal < 30)
            {
                hState = 0;//干燥
            }
            else if (humidityVal >= 30 && humidityVal <= 60)
            {
                hState = 1;//合适
            }
            else
            {
                hState = 2;//潮湿
            }
            shopsItem.HState = hState;
        }
        private decimal ConverToDecimal(uint intVal)
        {
            decimal fValue = 0.0m;
            byte[] arr = BitConverter.GetBytes(intVal);
            float fVal = BitConverter.ToSingle(arr, 0);
            fValue = (decimal)fVal;
            return fValue;
        }
        //打开系统设置页
        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.ShowDialog();
        }

        //导入商铺信息数据
        private void btnDataImport_Click(object sender, EventArgs e)
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
                        ShopsInfo info = new ShopsInfo();
                        info.ShopsNo = dr["商铺编号"].ToString().GetInt();
                        info.ShopsName = dr["商铺名称"].ToString();
                        info.FloorNo = dr["楼层号"].ToString().GetInt();
                        ShopsInfo oldInfo = CommonHelper.shopsList.Find(s => s.ShopsNo == info.ShopsNo);
                        if (oldInfo != null)
                        {
                            oldInfo.ShopsName = info.ShopsName;
                            oldInfo.FloorNo = info.FloorNo;
                        }
                        else
                            CommonHelper.shopsList.Add(info);
                    }
                }
                //写入文件---json
                string json = JsonConvert.SerializeObject(CommonHelper.shopsList);
                if (!Directory.Exists(CommonHelper.dirFile))
                {
                    Directory.CreateDirectory(CommonHelper.dirFile);
                }
                File.WriteAllText(CommonHelper.shopsFilePath, json);
                MessageHelper.Success("导入商铺信息", "商铺信息导入成功！");

            }
        }
        //启动与停止处理
        bool isStart = false;//是否启动
        private void btnStart_Click(object sender, EventArgs e)
        {
            plc = CommonHelper.plc;
            if (plc != null)
            {
                try
                {
                    if (!isStart)
                    {//启动
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            isStart = true;
                            readTimer.Start();//启动定时器
                            btnStart.Text = "停止";
                            btnStart.BgColor = Color.DarkRed;
                            btnStart.BgColor = Color.Maroon;
                            //btnStart.ForeColor=Color.White;
                        }
                        else
                        {
                            MessageHelper.Error("启动系统", "plc连接失败");
                            return;
                        }
                    }
                    else
                    {
                        //停止
                        readTimer.Stop();//停止定时器
                        plc.Close();
                        isStart = false;
                        btnStart.BgColor = Color.FromArgb(255, 128, 0);
                        btnStart.BgColor = Color.Transparent;
                        btnStart.ForeColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    MessageHelper.Error("启动系统", "plc连接出现异常");
                    return;
                }
            }
            else
            {
                MessageHelper.Error("启动系统", "请先进行PLC信息设置");
                return;
            }
        }
        //风机开关切换
        private void swFan_CheckedChanged(object sender, EventArgs e)
        {
            bool setState = !swFan.Checked;
            ChangeFan(setState);
        }
        //通电状态
        private void swEnergize_CheckedChanged(object sender, EventArgs e)
        {
            bool setState=!swEnergize.Checked;//控制的状态
            string psAddr=swEnergize.Tag.ToString();
            plc.Write(psAddr, setState);
            dicDatas[selShop.ShopsNo].PowerState = setState;
            if(setState==false)           
            {
                if(swFan.Checked)
                {
                    //关闭风机
                    ChangeFan(false);

                }
                if(swLight.Checked)
                {
                    ChangeLight(false);
                }
            }
        }
        //灯开关切换
        private void swLight_CheckedChanged(object sender, EventArgs e)
        {
            bool setState=!swLight.Checked;
            ChangeLight(setState);
        }
        private void ChangeFan(bool state)
        {
           
            string fsAddr = swFan.Tag.ToString();
            plc.Write(fsAddr, state);
            dicDatas[selShop.ShopsNo].FanState = state;
        }
        //控制灯
        private void ChangeLight(bool setState)
        {
           
            string lsAddr = swLight.Tag.ToString();
            plc.Write(lsAddr, setState);
            dicDatas[selShop.ShopsNo].LighState = setState;
        }
    }
}
