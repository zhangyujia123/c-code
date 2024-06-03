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

        #region ����ߴ����
        const int WM_NCHITTEST = 0x0084;// �ƶ����
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

        #region ���ڿ���
        //��С��
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //���������֮����л�
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;//�л���Normal״̬
                btnMax.Text = "1";
            }
            else
            {
                MaximumSize = Screen.AllScreens[0].WorkingArea.Size;//����Ļ�Ĺ������ߴ�
                WindowState = FormWindowState.Maximized;//�л������״̬
                btnMax.Text = "2";
            }
        }
        //�ر�----ϵͳ�˳�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.Question("ϵͳ�˳�", "��ȷ��Ҫ�˳�ϵͳ��") == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
        #endregion

        #region ���ڵ��϶�
        Point point = new Point();//��ʼ��ס��
        bool isMoving = false;//�Ƿ������϶���
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//��ǰ���µ�λ��
            isMoving = true;//�����϶�
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNew;
            if (e.Button == MouseButtons.Left && isMoving)
            {
                pointNew = e.Location;//Ŀ��λ��
                Point pPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//ƽ�Ƶľ���
                this.Location += new Size(pPointNew);//�����ƽ��
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//ֹͣ�϶�
        }
        #endregion

        Plc plc = null;//plcʵ��
        System.Timers.Timer timeTimer = null;//��̬ʱ��
        System.Timers.Timer readTimer = null;//��ʱ�ɼ�
        FloorInfo selFloor = null;//��ǰѡ��¥��
        List<ShopsInfo> selShopsList = new List<ShopsInfo>();//��ǰ¥��������б�
        List<int> selShopsIds = new List<int>();//��ǰ¥������̱�ż���
        List<ShopsSetInfo> selSetList = new List<ShopsSetInfo>();//�洢��ǰ¥������̲����б�
        Dictionary<int, ShopsData> dicDatas = new Dictionary<int, ShopsData>();
        //��ʼ������ 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //plcͨ�����ó�ʼ��
            InitCommunication();
            //¥����Ϣ�б����
            CommonHelper.LoadFloorList();
            //������Ϣ�б�
            CommonHelper.LoadShopsList();
            //������Ϣ�б�
            CommonHelper.LoadShopsSetList();
            //��ʱ����ʼ��
            InitTimers();
            //������Ϣ��ʼ��
            InitInfo();
            //ͳ���̳���������
            StatisticsShopsData();
            //¥�㵼��������
            LoadFloorNavList();
        }


        private void InitCommunication()
        {
            //����ͨ�����ü��ط���
            CommonHelper.LoadPLCSet();
            var plcInfo = CommonHelper.plcInfo;
            if (plcInfo == null)
            {
                MessageHelper.Error("ͨ�ų�ʼ��", "���Ƚ���PLCͨ�����ã�");
                return;
            }
            else
            {
                //����plcʵ��
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
        //��������ͳ��
        private void StatisticsShopsData()
        {
            int totalCount = CommonHelper.shopsList.Count;//��������
            int runningCount = CommonHelper.shopsList.Where(s => s.IsRunning).Count();//��Ӫ������
            int unCount = totalCount - runningCount;//������

            numTotalCount.Value = totalCount;
            numRunningCount.Value = runningCount;
            numUnCount.Value = unCount;
        }

        //¥�㵼��������
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
                //Ĭ��ѡ��¥�㣺��һ¥
                selFloor = CommonHelper.floorList[0];
                lblSelFloor.Text = selFloor.FloorName;//��ʾѡ��¥����
                GetSelFloorShops();
                //¥���л�����
                ChangeCurFloor();
            }
        }

        //¥��ѡ��
        private void LblLav_Click(object sender, EventArgs e)
        {
            Label curNav = sender as Label;
            FloorInfo floor = curNav.Tag as FloorInfo;
            if (floor != null)
            {
                selFloor = floor;//ѡ��¥��
                lblSelFloor.Text = floor.FloorName;
                GetSelFloorShops();
                //¥���л�Ч������
                ChangeCurFloor();
            }
        }

        //¥���л�Ч������
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

                //ͳ�Ƶ�ǰ¥�������
                StatisticsFloorData();
                //���ص�ǰ¥��������б�
                LoadFloorShopsList();
            }
        }


        //ͳ�Ƶ�ǰ¥�������
        private void StatisticsFloorData()
        {
            int selFloorId = selFloor.FloorNo;//ѡ��¥����
            int runCount = selShopsList.Where(s => s.IsRunning).Count();
            int unCount = selShopsList.Count - runCount;
            numFloorTotalCount.Value = selShopsList.Count;
            numFloorRunningCount.Value = runCount;
            numFloorUnCount.Value = unCount;
        }

        //���ص�ǰ¥��������б�
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
                        //��������
                        ShopsData shopData = new ShopsData();
                        shopData.ShopsNo = shop.ShopsNo;
                        shopData.ShopsName = shop.ShopsName;
                        shopData.RunState = shop.IsRunning;

                        UShopItem shopItem = new UShopItem();
                        shopItem.Margin = new Padding(3);
                        shopItem.BackColor = Color.FromArgb(20, 46, 56);
                        shopItem.BorderColor = Color.LightSteelBlue;
                        shopItem.InitData(shopData, setInfo);//��ʼ��������Ϣ�����
                        shopItem.Name = "shop" + shop.ShopsNo;
                        shopItem.Size = new Size(190, 115);
                        //����ѡ���¼�
                        shopItem.ShopsSelected += ShopItem_ShopsSelected;
                        flpList.Controls.Add(shopItem);
                    }
                }
            }
        }
        UShopItem selShop = null;
        //����ѡ���������
        private void ShopItem_ShopsSelected(object sender, EventArgs e)
        {
            UShopItem shopsItem = (UShopItem)sender;
            shopsItem.IsSelected = true;
            selShop = shopsItem;
            if (!panelShopInfo.Visible)
            {
                panelShopInfo.Visible = true;
            }
            //ˢ���Ҳ���������
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


        //����ѡ��¥��������б�Ͳ����б�
        private void GetSelFloorShops()
        {
            selShopsList = CommonHelper.shopsList.Where(s => s.FloorNo == selFloor.FloorNo).ToList();//��ǰ¥���������Ϣ�б�
            selShopsIds = selShopsList.Select(s => s.ShopsNo).ToList();//��ǰ¥������̱�ż���
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
            //�ɼ�����
            if (plc.IsConnected)
            {
                ReadAndLoadData();//��ʱ�ɼ������
            }
            else
            {
                MessageHelper.Error("ʵʱ�ɼ�", "PLCδ����");
                return;
            }
        }
        //��ʱ�ɼ������
        private void ReadAndLoadData()
        {
            //�ɼ�����
            foreach (var setInfo in selSetList)
            {
                int shopsNo = setInfo.ShopsNo;
                ShopsInfo shop = selShopsList.Find(s => s.ShopsNo == shopsNo);//������Ϣ
                if (shop != null)
                {
                    ShopsData shopsData = new ShopsData();
                    shopsData.ShopsNo = shopsNo;
                    shopsData.RunState = (bool)plc.Read(setInfo.RunAddr);//��Ӫ״̬
                                                                         //if(shopsData.RunState)

                    shopsData.OpenState = (bool)plc.Read(setInfo.IsOpenedAddr);//����״̬
                    shopsData.PowerState = (bool)plc.Read(setInfo.PSAddr);//ͨ��
                    shopsData.FanState = (bool)plc.Read(setInfo.FSAddr);//���״̬
                    shopsData.LighState = (bool)plc.Read(setInfo.LSAddr);//��״̬
                    shopsData.Temperature = ConverToDecimal((uint)plc.Read(setInfo.RTemperAddr));//�¶�ֵ
                    shopsData.Humidity = (ushort)plc.Read(setInfo.RHumidityAddr);//ʪ��
                    shopsData.CurPowerRead = (ushort)plc.Read(setInfo.CurPReadAddr);//��ǰ��������
                    shopsData.LastPowerRead = (ushort)plc.Read(setInfo.LastPReadAddr);//�����õ���

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

            //����
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
                            shopItem.UpdateData(shopsData);//��������
                            //�����ʪ��״̬
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
        //�����ʪ��״̬
        private void CheckTHState(UShopItem shopsItem)
        {
            decimal temperVal = shopsItem.Temperature;
            decimal humidityVal = shopsItem.Humidity;
            //�¶�״̬
            int tState = -1;
            if (temperVal < 10)
            {
                tState = 0;//����
            }
            else if (temperVal >= 10 && temperVal <= 25)
            {
                tState = 1;//����
            }
            else
            {
                tState = 2;//����
            }
            shopsItem.TState = tState;


            //ʪ��״̬���
            int hState = -1;
            if (humidityVal < 30)
            {
                hState = 0;//����
            }
            else if (humidityVal >= 30 && humidityVal <= 60)
            {
                hState = 1;//����
            }
            else
            {
                hState = 2;//��ʪ
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
        //��ϵͳ����ҳ
        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.ShowDialog();
        }

        //����������Ϣ����
        private void btnDataImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files(*.xlsx)|*.xlsx|Excel Files 2003 (*.xls)|*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;//�ļ���
                DataTable dt = ExcelHelper.ExcelToDataTable(fileName, "Sheet1", true);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ShopsInfo info = new ShopsInfo();
                        info.ShopsNo = dr["���̱��"].ToString().GetInt();
                        info.ShopsName = dr["��������"].ToString();
                        info.FloorNo = dr["¥���"].ToString().GetInt();
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
                //д���ļ�---json
                string json = JsonConvert.SerializeObject(CommonHelper.shopsList);
                if (!Directory.Exists(CommonHelper.dirFile))
                {
                    Directory.CreateDirectory(CommonHelper.dirFile);
                }
                File.WriteAllText(CommonHelper.shopsFilePath, json);
                MessageHelper.Success("����������Ϣ", "������Ϣ����ɹ���");

            }
        }
        //������ֹͣ����
        bool isStart = false;//�Ƿ�����
        private void btnStart_Click(object sender, EventArgs e)
        {
            plc = CommonHelper.plc;
            if (plc != null)
            {
                try
                {
                    if (!isStart)
                    {//����
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            isStart = true;
                            readTimer.Start();//������ʱ��
                            btnStart.Text = "ֹͣ";
                            btnStart.BgColor = Color.DarkRed;
                            btnStart.BgColor = Color.Maroon;
                            //btnStart.ForeColor=Color.White;
                        }
                        else
                        {
                            MessageHelper.Error("����ϵͳ", "plc����ʧ��");
                            return;
                        }
                    }
                    else
                    {
                        //ֹͣ
                        readTimer.Stop();//ֹͣ��ʱ��
                        plc.Close();
                        isStart = false;
                        btnStart.BgColor = Color.FromArgb(255, 128, 0);
                        btnStart.BgColor = Color.Transparent;
                        btnStart.ForeColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    MessageHelper.Error("����ϵͳ", "plc���ӳ����쳣");
                    return;
                }
            }
            else
            {
                MessageHelper.Error("����ϵͳ", "���Ƚ���PLC��Ϣ����");
                return;
            }
        }
        //��������л�
        private void swFan_CheckedChanged(object sender, EventArgs e)
        {
            bool setState = !swFan.Checked;
            ChangeFan(setState);
        }
        //ͨ��״̬
        private void swEnergize_CheckedChanged(object sender, EventArgs e)
        {
            bool setState=!swEnergize.Checked;//���Ƶ�״̬
            string psAddr=swEnergize.Tag.ToString();
            plc.Write(psAddr, setState);
            dicDatas[selShop.ShopsNo].PowerState = setState;
            if(setState==false)           
            {
                if(swFan.Checked)
                {
                    //�رշ��
                    ChangeFan(false);

                }
                if(swLight.Checked)
                {
                    ChangeLight(false);
                }
            }
        }
        //�ƿ����л�
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
        //���Ƶ�
        private void ChangeLight(bool setState)
        {
           
            string lsAddr = swLight.Tag.ToString();
            plc.Write(lsAddr, setState);
            dicDatas[selShop.ShopsNo].LighState = setState;
        }
    }
}
