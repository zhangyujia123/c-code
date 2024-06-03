namespace Zhaoxi.IntelligentShoppingCenter
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pictureBox1 = new PictureBox();
            uPanel1 = new UControls.UPanel();
            panelShopInfo = new UControls.UPanel();
            txtLastPowerReads = new UControls.ParaTextBox();
            txtCurPowerReads = new UControls.ParaTextBox();
            txtTodayPowers = new UControls.ParaTextBox();
            swEnergize = new UControls.USwitch();
            swLight = new UControls.USwitch();
            swFan = new UControls.USwitch();
            swOpen = new UControls.USwitch();
            uLine9 = new UControls.ULine();
            uLine8 = new UControls.ULine();
            uLine7 = new UControls.ULine();
            uLine6 = new UControls.ULine();
            uLine5 = new UControls.ULine();
            uLine4 = new UControls.ULine();
            uLine3 = new UControls.ULine();
            uLine2 = new UControls.ULine();
            label14 = new Label();
            lblSelshop = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            uPanel6 = new UControls.UPanel();
            flpList = new FlowLayoutPanel();
            uShopItem1 = new UControls.UShopItem();
            uShopItem2 = new UControls.UShopItem();
            uShopItem3 = new UControls.UShopItem();
            uShopItem4 = new UControls.UShopItem();
            uShopItem6 = new UControls.UShopItem();
            uShopItem5 = new UControls.UShopItem();
            uPanel5 = new UControls.UPanel();
            uLine1 = new UControls.ULine();
            uCircleItem6 = new UControls.UCircleItem();
            uCircleItem5 = new UControls.UCircleItem();
            uCircleItem4 = new UControls.UCircleItem();
            btnStart = new UControls.CircleButton();
            uCircleItem3 = new UControls.UCircleItem();
            uCircleItem2 = new UControls.UCircleItem();
            uCircleItem1 = new UControls.UCircleItem();
            panelNav = new UControls.UPanel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            uPanel3 = new UControls.UPanel();
            numFloorUnCount = new UControls.UNumericBox();
            numUnCount = new UControls.UNumericBox();
            numFloorRunningCount = new UControls.UNumericBox();
            numRunningCount = new UControls.UNumericBox();
            numFloorTotalCount = new UControls.UNumericBox();
            numTotalCount = new UControls.UNumericBox();
            lblSelFloor = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelTop = new UControls.UPanel();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            btnDataImport = new UControls.CircleButton();
            btnSetting = new UControls.CircleButton();
            label2 = new Label();
            lblTime = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uPanel1.SuspendLayout();
            panelShopInfo.SuspendLayout();
            uPanel6.SuspendLayout();
            flpList.SuspendLayout();
            uPanel5.SuspendLayout();
            panelNav.SuspendLayout();
            uPanel3.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(20, 46, 56);
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uPanel1
            // 
            uPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uPanel1.BgColor = Color.FromArgb(20, 46, 56);
            uPanel1.BgColor2 = Color.FromArgb(72, 104, 136);
            uPanel1.Controls.Add(panelShopInfo);
            uPanel1.Controls.Add(uPanel6);
            uPanel1.Controls.Add(uPanel5);
            uPanel1.Controls.Add(panelNav);
            uPanel1.Controls.Add(uPanel3);
            uPanel1.Controls.Add(panelTop);
            uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel1.Location = new Point(2, 2);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 2;
            uPanel1.Size = new Size(1406, 754);
            uPanel1.TabIndex = 1;
            // 
            // panelShopInfo
            // 
            panelShopInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelShopInfo.BackColor = Color.Transparent;
            panelShopInfo.BgColor = Color.FromArgb(73, 109, 133);
            panelShopInfo.BgColor2 = Color.Transparent;
            panelShopInfo.BorderColor = Color.CadetBlue;
            panelShopInfo.BorderWidth = 2;
            panelShopInfo.Controls.Add(txtLastPowerReads);
            panelShopInfo.Controls.Add(txtCurPowerReads);
            panelShopInfo.Controls.Add(txtTodayPowers);
            panelShopInfo.Controls.Add(swEnergize);
            panelShopInfo.Controls.Add(swLight);
            panelShopInfo.Controls.Add(swFan);
            panelShopInfo.Controls.Add(swOpen);
            panelShopInfo.Controls.Add(uLine9);
            panelShopInfo.Controls.Add(uLine8);
            panelShopInfo.Controls.Add(uLine7);
            panelShopInfo.Controls.Add(uLine6);
            panelShopInfo.Controls.Add(uLine5);
            panelShopInfo.Controls.Add(uLine4);
            panelShopInfo.Controls.Add(uLine3);
            panelShopInfo.Controls.Add(uLine2);
            panelShopInfo.Controls.Add(label14);
            panelShopInfo.Controls.Add(lblSelshop);
            panelShopInfo.Controls.Add(label21);
            panelShopInfo.Controls.Add(label20);
            panelShopInfo.Controls.Add(label19);
            panelShopInfo.Controls.Add(label18);
            panelShopInfo.Controls.Add(label17);
            panelShopInfo.Controls.Add(label16);
            panelShopInfo.Controls.Add(label15);
            panelShopInfo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            panelShopInfo.Location = new Point(1121, 249);
            panelShopInfo.Name = "panelShopInfo";
            panelShopInfo.Radius = 10;
            panelShopInfo.Size = new Size(274, 483);
            panelShopInfo.TabIndex = 3;
            // 
            // txtLastPowerReads
            // 
            txtLastPowerReads.AutoSize = true;
            txtLastPowerReads.DecimalCount = 0;
            txtLastPowerReads.ForeColor = Color.White;
            txtLastPowerReads.Location = new Point(139, 397);
            txtLastPowerReads.Name = "txtLastPowerReads";
            txtLastPowerReads.ParaName = null;
            txtLastPowerReads.Size = new Size(74, 20);
            txtLastPowerReads.TabIndex = 5;
            txtLastPowerReads.Text = "114 KWh";
            txtLastPowerReads.TextAlign = ContentAlignment.MiddleCenter;
            txtLastPowerReads.Unit = "KWh";
            txtLastPowerReads.Value = new decimal(new int[] { 114, 0, 0, 0 });
            // 
            // txtCurPowerReads
            // 
            txtCurPowerReads.AutoSize = true;
            txtCurPowerReads.DecimalCount = 0;
            txtCurPowerReads.ForeColor = Color.White;
            txtCurPowerReads.Location = new Point(139, 345);
            txtCurPowerReads.Name = "txtCurPowerReads";
            txtCurPowerReads.ParaName = null;
            txtCurPowerReads.Size = new Size(74, 20);
            txtCurPowerReads.TabIndex = 5;
            txtCurPowerReads.Text = "120 KWh";
            txtCurPowerReads.TextAlign = ContentAlignment.MiddleCenter;
            txtCurPowerReads.Unit = "KWh";
            txtCurPowerReads.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // txtTodayPowers
            // 
            txtTodayPowers.AutoSize = true;
            txtTodayPowers.DecimalCount = 0;
            txtTodayPowers.ForeColor = Color.White;
            txtTodayPowers.Location = new Point(139, 289);
            txtTodayPowers.Name = "txtTodayPowers";
            txtTodayPowers.ParaName = null;
            txtTodayPowers.Size = new Size(56, 20);
            txtTodayPowers.TabIndex = 5;
            txtTodayPowers.Text = "6 KWh";
            txtTodayPowers.TextAlign = ContentAlignment.MiddleCenter;
            txtTodayPowers.Unit = "KWh";
            txtTodayPowers.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // swEnergize
            // 
            swEnergize.BackColor = Color.Transparent;
            swEnergize.Location = new Point(139, 178);
            swEnergize.Name = "swEnergize";
            swEnergize.Size = new Size(93, 28);
            swEnergize.StateTexts = new string[]
    {
    "已通电",
    "已断电"
    };
            swEnergize.TabIndex = 4;
            swEnergize.CheckedChanged += swEnergize_CheckedChanged;
            // 
            // swLight
            // 
            swLight.BackColor = Color.Transparent;
            swLight.Checked = true;
            swLight.Location = new Point(139, 231);
            swLight.Name = "swLight";
            swLight.Size = new Size(93, 28);
            swLight.StateTexts = new string[]
    {
    "开灯",
    "关灯"
    };
            swLight.TabIndex = 4;
            swLight.CheckedChanged += swLight_CheckedChanged;
            // 
            // swFan
            // 
            swFan.BackColor = Color.Transparent;
            swFan.Checked = true;
            swFan.Location = new Point(139, 126);
            swFan.Name = "swFan";
            swFan.Size = new Size(93, 28);
            swFan.StateTexts = new string[]
    {
    "开",
    "关"
    };
            swFan.TabIndex = 4;
            swFan.CheckedChanged += swFan_CheckedChanged;
            // 
            // swOpen
            // 
            swOpen.BackColor = Color.Transparent;
            swOpen.Checked = true;
            swOpen.Enabled = false;
            swOpen.Location = new Point(139, 74);
            swOpen.Name = "swOpen";
            swOpen.Size = new Size(93, 28);
            swOpen.StateTexts = new string[]
    {
    "已开门",
    "已关闭"
    };
            swOpen.TabIndex = 4;
            swOpen.TrueColor = Color.Green;
            // 
            // uLine9
            // 
            uLine9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine9.LineColor = Color.WhiteSmoke;
            uLine9.Location = new Point(8, 423);
            uLine9.Name = "uLine9";
            uLine9.Size = new Size(258, 13);
            uLine9.TabIndex = 3;
            // 
            // uLine8
            // 
            uLine8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine8.LineColor = Color.SlateGray;
            uLine8.Location = new Point(9, 369);
            uLine8.Name = "uLine8";
            uLine8.Size = new Size(258, 13);
            uLine8.TabIndex = 3;
            // 
            // uLine7
            // 
            uLine7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine7.LineColor = Color.SlateGray;
            uLine7.Location = new Point(8, 315);
            uLine7.Name = "uLine7";
            uLine7.Size = new Size(258, 13);
            uLine7.TabIndex = 3;
            // 
            // uLine6
            // 
            uLine6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine6.LineColor = Color.SlateGray;
            uLine6.Location = new Point(8, 262);
            uLine6.Name = "uLine6";
            uLine6.Size = new Size(258, 13);
            uLine6.TabIndex = 3;
            // 
            // uLine5
            // 
            uLine5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine5.LineColor = Color.SlateGray;
            uLine5.Location = new Point(8, 208);
            uLine5.Name = "uLine5";
            uLine5.Size = new Size(258, 13);
            uLine5.TabIndex = 3;
            // 
            // uLine4
            // 
            uLine4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine4.LineColor = Color.SlateGray;
            uLine4.Location = new Point(9, 154);
            uLine4.Name = "uLine4";
            uLine4.Size = new Size(258, 13);
            uLine4.TabIndex = 3;
            // 
            // uLine3
            // 
            uLine3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine3.LineColor = Color.SlateGray;
            uLine3.Location = new Point(8, 102);
            uLine3.Name = "uLine3";
            uLine3.Size = new Size(258, 13);
            uLine3.TabIndex = 3;
            // 
            // uLine2
            // 
            uLine2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine2.LineColor = Color.WhiteSmoke;
            uLine2.Location = new Point(8, 52);
            uLine2.Name = "uLine2";
            uLine2.Size = new Size(258, 13);
            uLine2.TabIndex = 3;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(139, 26);
            label14.Name = "label14";
            label14.Size = new Size(82, 24);
            label14.TabIndex = 2;
            label14.Text = "商铺详情";
            // 
            // lblSelshop
            // 
            lblSelshop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelshop.AutoSize = true;
            lblSelshop.BackColor = Color.Transparent;
            lblSelshop.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblSelshop.ForeColor = Color.Cyan;
            lblSelshop.Location = new Point(22, 26);
            lblSelshop.Name = "lblSelshop";
            lblSelshop.Size = new Size(78, 25);
            lblSelshop.TabIndex = 2;
            lblSelshop.Text = "商铺-02";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Microsoft YaHei UI", 9F);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(16, 397);
            label21.Name = "label21";
            label21.Size = new Size(114, 20);
            label21.TabIndex = 2;
            label21.Text = "昨日电表读数：";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft YaHei UI", 9F);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(16, 345);
            label20.Name = "label20";
            label20.Size = new Size(114, 20);
            label20.TabIndex = 2;
            label20.Text = "当前电表读数：";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Microsoft YaHei UI", 9F);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(31, 289);
            label19.Name = "label19";
            label19.Size = new Size(99, 20);
            label19.TabIndex = 2;
            label19.Text = "今日耗电量：";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft YaHei UI", 9F);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(31, 236);
            label18.Name = "label18";
            label18.Size = new Size(99, 20);
            label18.TabIndex = 2;
            label18.Text = "照明灯状态：";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft YaHei UI", 9F);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(46, 183);
            label17.Name = "label17";
            label17.Size = new Size(84, 20);
            label17.TabIndex = 2;
            label17.Text = "通电状态：";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft YaHei UI", 9F);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(46, 129);
            label16.Name = "label16";
            label16.Size = new Size(84, 20);
            label16.TabIndex = 2;
            label16.Text = "空调运行：";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft YaHei UI", 9F);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(76, 79);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 2;
            label15.Text = "状态：";
            // 
            // uPanel6
            // 
            uPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uPanel6.BackColor = Color.FromArgb(20, 46, 56);
            uPanel6.BgColor = Color.FromArgb(20, 46, 56);
            uPanel6.BgColor2 = Color.Transparent;
            uPanel6.BorderColor = Color.LightGray;
            uPanel6.BorderWidth = 1;
            uPanel6.Controls.Add(flpList);
            uPanel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel6.Location = new Point(217, 240);
            uPanel6.Name = "uPanel6";
            uPanel6.Radius = 3;
            uPanel6.Size = new Size(896, 500);
            uPanel6.TabIndex = 2;
            // 
            // flpList
            // 
            flpList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpList.AutoScroll = true;
            flpList.Controls.Add(uShopItem1);
            flpList.Controls.Add(uShopItem2);
            flpList.Controls.Add(uShopItem3);
            flpList.Controls.Add(uShopItem4);
            flpList.Controls.Add(uShopItem6);
            flpList.Controls.Add(uShopItem5);
            flpList.Location = new Point(6, 6);
            flpList.Name = "flpList";
            flpList.Padding = new Padding(5);
            flpList.Size = new Size(883, 488);
            flpList.TabIndex = 0;
            // 
            // uShopItem1
            // 
            uShopItem1.BackColor = Color.FromArgb(20, 46, 56);
            uShopItem1.BorderColor = Color.LightSteelBlue;
            uShopItem1.HState = 1;
            uShopItem1.Humidity = new decimal(new int[] { 50, 0, 0, 0 });
            uShopItem1.IsSelected = false;
            uShopItem1.Location = new Point(10, 10);
            uShopItem1.Margin = new Padding(5);
            uShopItem1.Name = "uShopItem1";
            uShopItem1.RunState = true;
            uShopItem1.ShopSet = null;
            uShopItem1.ShopsName = "商铺-01";
            uShopItem1.ShopsNo = 101;
            uShopItem1.Size = new Size(181, 114);
            uShopItem1.TabIndex = 0;
            uShopItem1.Temperature = new decimal(new int[] { 285, 0, 0, 65536 });
            uShopItem1.TState = 1;
            // 
            // uShopItem2
            // 
            uShopItem2.BackColor = Color.FromArgb(20, 46, 56);
            uShopItem2.BorderColor = Color.LightSteelBlue;
            uShopItem2.HState = 1;
            uShopItem2.Humidity = new decimal(new int[] { 50, 0, 0, 0 });
            uShopItem2.IsSelected = false;
            uShopItem2.Location = new Point(201, 10);
            uShopItem2.Margin = new Padding(5);
            uShopItem2.Name = "uShopItem2";
            uShopItem2.RunState = false;
            uShopItem2.ShopSet = null;
            uShopItem2.ShopsName = "商铺-02";
            uShopItem2.ShopsNo = 102;
            uShopItem2.Size = new Size(181, 114);
            uShopItem2.TabIndex = 0;
            uShopItem2.Temperature = new decimal(new int[] { 285, 0, 0, 65536 });
            uShopItem2.TState = 1;
            // 
            // uShopItem3
            // 
            uShopItem3.BackColor = Color.FromArgb(20, 46, 56);
            uShopItem3.BorderColor = Color.LightSteelBlue;
            uShopItem3.HState = 1;
            uShopItem3.Humidity = new decimal(new int[] { 50, 0, 0, 0 });
            uShopItem3.IsSelected = false;
            uShopItem3.Location = new Point(392, 10);
            uShopItem3.Margin = new Padding(5);
            uShopItem3.Name = "uShopItem3";
            uShopItem3.RunState = true;
            uShopItem3.ShopSet = null;
            uShopItem3.ShopsName = "商铺-03";
            uShopItem3.ShopsNo = 103;
            uShopItem3.Size = new Size(181, 114);
            uShopItem3.TabIndex = 0;
            uShopItem3.Temperature = new decimal(new int[] { 285, 0, 0, 65536 });
            uShopItem3.TState = 1;
            // 
            // uShopItem4
            // 
            uShopItem4.BackColor = Color.FromArgb(20, 46, 56);
            uShopItem4.BorderColor = Color.LightSteelBlue;
            uShopItem4.HState = 1;
            uShopItem4.Humidity = new decimal(new int[] { 50, 0, 0, 0 });
            uShopItem4.IsSelected = false;
            uShopItem4.Location = new Point(583, 10);
            uShopItem4.Margin = new Padding(5);
            uShopItem4.Name = "uShopItem4";
            uShopItem4.RunState = false;
            uShopItem4.ShopSet = null;
            uShopItem4.ShopsName = "商铺-04";
            uShopItem4.ShopsNo = 104;
            uShopItem4.Size = new Size(181, 114);
            uShopItem4.TabIndex = 0;
            uShopItem4.Temperature = new decimal(new int[] { 285, 0, 0, 65536 });
            uShopItem4.TState = 1;
            // 
            // uShopItem6
            // 
            uShopItem6.BackColor = Color.FromArgb(20, 46, 56);
            uShopItem6.BorderColor = Color.LightSteelBlue;
            uShopItem6.HState = 1;
            uShopItem6.Humidity = new decimal(new int[] { 50, 0, 0, 0 });
            uShopItem6.IsSelected = false;
            uShopItem6.Location = new Point(10, 134);
            uShopItem6.Margin = new Padding(5);
            uShopItem6.Name = "uShopItem6";
            uShopItem6.RunState = true;
            uShopItem6.ShopSet = null;
            uShopItem6.ShopsName = "商铺-05";
            uShopItem6.ShopsNo = 105;
            uShopItem6.Size = new Size(181, 114);
            uShopItem6.TabIndex = 0;
            uShopItem6.Temperature = new decimal(new int[] { 285, 0, 0, 65536 });
            uShopItem6.TState = 1;
            // 
            // uShopItem5
            // 
            uShopItem5.BackColor = Color.FromArgb(20, 46, 56);
            uShopItem5.BorderColor = Color.LightSteelBlue;
            uShopItem5.HState = 1;
            uShopItem5.Humidity = new decimal(new int[] { 50, 0, 0, 0 });
            uShopItem5.IsSelected = false;
            uShopItem5.Location = new Point(201, 134);
            uShopItem5.Margin = new Padding(5);
            uShopItem5.Name = "uShopItem5";
            uShopItem5.RunState = false;
            uShopItem5.ShopSet = null;
            uShopItem5.ShopsName = "商铺-06";
            uShopItem5.ShopsNo = 106;
            uShopItem5.Size = new Size(181, 114);
            uShopItem5.TabIndex = 0;
            uShopItem5.Temperature = new decimal(new int[] { 285, 0, 0, 65536 });
            uShopItem5.TState = 1;
            // 
            // uPanel5
            // 
            uPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uPanel5.BackColor = Color.Transparent;
            uPanel5.BgColor = Color.FromArgb(20, 46, 56);
            uPanel5.BgColor2 = Color.Transparent;
            uPanel5.BorderColor = Color.LightSkyBlue;
            uPanel5.BorderWidth = 1;
            uPanel5.Controls.Add(uLine1);
            uPanel5.Controls.Add(uCircleItem6);
            uPanel5.Controls.Add(uCircleItem5);
            uPanel5.Controls.Add(uCircleItem4);
            uPanel5.Controls.Add(btnStart);
            uPanel5.Controls.Add(uCircleItem3);
            uPanel5.Controls.Add(uCircleItem2);
            uPanel5.Controls.Add(uCircleItem1);
            uPanel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel5.Location = new Point(217, 177);
            uPanel5.Name = "uPanel5";
            uPanel5.Radius = 5;
            uPanel5.Size = new Size(1178, 54);
            uPanel5.TabIndex = 2;
            // 
            // uLine1
            // 
            uLine1.IsHorizontal = false;
            uLine1.LineColor = Color.LightGray;
            uLine1.LineWidth = 2;
            uLine1.Location = new Point(408, 11);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(18, 35);
            uLine1.TabIndex = 1;
            // 
            // uCircleItem6
            // 
            uCircleItem6.BackColor = Color.FromArgb(20, 46, 56);
            uCircleItem6.Color = Color.MediumSlateBlue;
            uCircleItem6.Location = new Point(689, 9);
            uCircleItem6.Name = "uCircleItem6";
            uCircleItem6.Note = "潮湿";
            uCircleItem6.Size = new Size(104, 37);
            uCircleItem6.TabIndex = 0;
            // 
            // uCircleItem5
            // 
            uCircleItem5.BackColor = Color.FromArgb(20, 46, 56);
            uCircleItem5.Color = Color.DeepSkyBlue;
            uCircleItem5.Location = new Point(579, 9);
            uCircleItem5.Name = "uCircleItem5";
            uCircleItem5.Note = "湿润";
            uCircleItem5.Size = new Size(104, 37);
            uCircleItem5.TabIndex = 0;
            // 
            // uCircleItem4
            // 
            uCircleItem4.BackColor = Color.FromArgb(20, 46, 56);
            uCircleItem4.Color = Color.Orange;
            uCircleItem4.Location = new Point(469, 9);
            uCircleItem4.Name = "uCircleItem4";
            uCircleItem4.Note = "干燥";
            uCircleItem4.Size = new Size(104, 37);
            uCircleItem4.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.BackColor = Color.FromArgb(20, 46, 56);
            btnStart.BgColor = Color.FromArgb(255, 128, 0);
            btnStart.BgColor2 = Color.Transparent;
            btnStart.BorderColor = Color.LightGray;
            btnStart.BorderWidth = 1;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnStart.ForeColor = Color.FromArgb(224, 224, 224);
            btnStart.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnStart.Location = new Point(882, 9);
            btnStart.Name = "btnStart";
            btnStart.Radius = 20;
            btnStart.SelectedColor = Color.White;
            btnStart.Size = new Size(81, 34);
            btnStart.TabIndex = 3;
            btnStart.Text = "启动";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // uCircleItem3
            // 
            uCircleItem3.BackColor = Color.FromArgb(20, 46, 56);
            uCircleItem3.Color = Color.SkyBlue;
            uCircleItem3.ForeColor = Color.White;
            uCircleItem3.Location = new Point(249, 9);
            uCircleItem3.Name = "uCircleItem3";
            uCircleItem3.Note = "低温";
            uCircleItem3.Size = new Size(104, 37);
            uCircleItem3.TabIndex = 0;
            // 
            // uCircleItem2
            // 
            uCircleItem2.BackColor = Color.FromArgb(20, 46, 56);
            uCircleItem2.Color = Color.Red;
            uCircleItem2.Location = new Point(139, 9);
            uCircleItem2.Name = "uCircleItem2";
            uCircleItem2.Note = "高温";
            uCircleItem2.Size = new Size(104, 37);
            uCircleItem2.TabIndex = 0;
            // 
            // uCircleItem1
            // 
            uCircleItem1.BackColor = Color.FromArgb(20, 46, 56);
            uCircleItem1.Color = Color.DodgerBlue;
            uCircleItem1.Location = new Point(29, 9);
            uCircleItem1.Name = "uCircleItem1";
            uCircleItem1.Note = "正常";
            uCircleItem1.Size = new Size(104, 37);
            uCircleItem1.TabIndex = 0;
            // 
            // panelNav
            // 
            panelNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelNav.BackColor = Color.Transparent;
            panelNav.BgColor = Color.FromArgb(62, 95, 119);
            panelNav.BgColor2 = Color.Transparent;
            panelNav.BorderColor = Color.CadetBlue;
            panelNav.BorderWidth = 2;
            panelNav.Controls.Add(label12);
            panelNav.Controls.Add(label11);
            panelNav.Controls.Add(label10);
            panelNav.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            panelNav.Location = new Point(-8, 175);
            panelNav.Name = "panelNav";
            panelNav.Radius = 5;
            panelNav.Size = new Size(211, 565);
            panelNav.TabIndex = 3;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(9, 111);
            label12.Name = "label12";
            label12.Size = new Size(199, 45);
            label12.TabIndex = 0;
            label12.Text = "三楼";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.SteelBlue;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.Cyan;
            label11.Location = new Point(9, 66);
            label11.Name = "label11";
            label11.Size = new Size(199, 45);
            label11.TabIndex = 0;
            label11.Text = "二楼";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(9, 20);
            label10.Name = "label10";
            label10.Size = new Size(199, 45);
            label10.TabIndex = 0;
            label10.Text = "一楼";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uPanel3
            // 
            uPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uPanel3.BackColor = Color.Transparent;
            uPanel3.BgColor = Color.FromArgb(20, 46, 56);
            uPanel3.BgColor2 = Color.Transparent;
            uPanel3.BorderColor = Color.LightSkyBlue;
            uPanel3.BorderWidth = 1;
            uPanel3.Controls.Add(numFloorUnCount);
            uPanel3.Controls.Add(numUnCount);
            uPanel3.Controls.Add(numFloorRunningCount);
            uPanel3.Controls.Add(numRunningCount);
            uPanel3.Controls.Add(numFloorTotalCount);
            uPanel3.Controls.Add(numTotalCount);
            uPanel3.Controls.Add(lblSelFloor);
            uPanel3.Controls.Add(label3);
            uPanel3.Controls.Add(label9);
            uPanel3.Controls.Add(label8);
            uPanel3.Controls.Add(label6);
            uPanel3.Controls.Add(label7);
            uPanel3.Controls.Add(label5);
            uPanel3.Controls.Add(label4);
            uPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel3.Location = new Point(12, 92);
            uPanel3.Name = "uPanel3";
            uPanel3.Radius = 5;
            uPanel3.Size = new Size(1383, 70);
            uPanel3.TabIndex = 2;
            // 
            // numFloorUnCount
            // 
            numFloorUnCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numFloorUnCount.BackColor = Color.FromArgb(20, 46, 56);
            numFloorUnCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numFloorUnCount.ForeColor = Color.Red;
            numFloorUnCount.ItemBgColor = Color.FromArgb(73, 109, 133);
            numFloorUnCount.ItemSpace = 2;
            numFloorUnCount.Location = new Point(1290, 18);
            numFloorUnCount.Margin = new Padding(4);
            numFloorUnCount.Name = "numFloorUnCount";
            numFloorUnCount.NumCount = 3;
            numFloorUnCount.Size = new Size(80, 39);
            numFloorUnCount.TabIndex = 3;
            numFloorUnCount.Value = 4;
            // 
            // numUnCount
            // 
            numUnCount.BackColor = Color.FromArgb(20, 46, 56);
            numUnCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numUnCount.ForeColor = Color.Red;
            numUnCount.ItemBgColor = Color.FromArgb(73, 109, 133);
            numUnCount.ItemSpace = 2;
            numUnCount.Location = new Point(584, 18);
            numUnCount.Margin = new Padding(4);
            numUnCount.Name = "numUnCount";
            numUnCount.NumCount = 3;
            numUnCount.Size = new Size(80, 39);
            numUnCount.TabIndex = 3;
            numUnCount.Value = 10;
            // 
            // numFloorRunningCount
            // 
            numFloorRunningCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numFloorRunningCount.BackColor = Color.FromArgb(20, 46, 56);
            numFloorRunningCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numFloorRunningCount.ForeColor = Color.FromArgb(0, 192, 0);
            numFloorRunningCount.ItemBgColor = Color.FromArgb(73, 109, 133);
            numFloorRunningCount.ItemSpace = 2;
            numFloorRunningCount.Location = new Point(1108, 18);
            numFloorRunningCount.Margin = new Padding(4);
            numFloorRunningCount.Name = "numFloorRunningCount";
            numFloorRunningCount.NumCount = 3;
            numFloorRunningCount.Size = new Size(80, 39);
            numFloorRunningCount.TabIndex = 3;
            numFloorRunningCount.Value = 6;
            // 
            // numRunningCount
            // 
            numRunningCount.BackColor = Color.FromArgb(20, 46, 56);
            numRunningCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numRunningCount.ForeColor = Color.FromArgb(0, 192, 0);
            numRunningCount.ItemBgColor = Color.FromArgb(73, 109, 133);
            numRunningCount.ItemSpace = 2;
            numRunningCount.Location = new Point(396, 18);
            numRunningCount.Margin = new Padding(4);
            numRunningCount.Name = "numRunningCount";
            numRunningCount.NumCount = 3;
            numRunningCount.Size = new Size(80, 39);
            numRunningCount.TabIndex = 3;
            numRunningCount.Value = 30;
            // 
            // numFloorTotalCount
            // 
            numFloorTotalCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numFloorTotalCount.BackColor = Color.FromArgb(20, 46, 56);
            numFloorTotalCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numFloorTotalCount.ForeColor = Color.White;
            numFloorTotalCount.ItemBgColor = Color.FromArgb(73, 109, 133);
            numFloorTotalCount.ItemSpace = 2;
            numFloorTotalCount.Location = new Point(916, 18);
            numFloorTotalCount.Margin = new Padding(4);
            numFloorTotalCount.Name = "numFloorTotalCount";
            numFloorTotalCount.NumCount = 3;
            numFloorTotalCount.Size = new Size(80, 39);
            numFloorTotalCount.TabIndex = 3;
            numFloorTotalCount.Value = 10;
            // 
            // numTotalCount
            // 
            numTotalCount.BackColor = Color.FromArgb(20, 46, 56);
            numTotalCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numTotalCount.ForeColor = Color.White;
            numTotalCount.ItemBgColor = Color.FromArgb(73, 109, 133);
            numTotalCount.ItemSpace = 2;
            numTotalCount.Location = new Point(205, 18);
            numTotalCount.Margin = new Padding(4);
            numTotalCount.Name = "numTotalCount";
            numTotalCount.NumCount = 3;
            numTotalCount.Size = new Size(80, 39);
            numTotalCount.TabIndex = 3;
            numTotalCount.Value = 40;
            // 
            // lblSelFloor
            // 
            lblSelFloor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelFloor.AutoSize = true;
            lblSelFloor.BackColor = Color.FromArgb(20, 46, 56);
            lblSelFloor.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblSelFloor.ForeColor = Color.DodgerBlue;
            lblSelFloor.Location = new Point(749, 24);
            lblSelFloor.Name = "lblSelFloor";
            lblSelFloor.Size = new Size(48, 25);
            lblSelFloor.TabIndex = 2;
            lblSelFloor.Text = "一楼";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(20, 46, 56);
            label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(29, 23);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "数据统计：";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(20, 46, 56);
            label9.Font = new Font("Microsoft YaHei UI", 9F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(1195, 28);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 2;
            label9.Text = "空闲商铺数：";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(20, 46, 56);
            label8.Font = new Font("Microsoft YaHei UI", 9F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(1014, 27);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 2;
            label8.Text = "运营商铺数：";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(20, 46, 56);
            label6.Font = new Font("Microsoft YaHei UI", 9F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(494, 26);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 2;
            label6.Text = "空闲商铺数：";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(20, 46, 56);
            label7.Font = new Font("Microsoft YaHei UI", 9F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(829, 26);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 2;
            label7.Text = "总商铺数：";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(20, 46, 56);
            label5.Font = new Font("Microsoft YaHei UI", 9F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(302, 27);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 2;
            label5.Text = "运营商铺数：";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(20, 46, 56);
            label4.Font = new Font("Microsoft YaHei UI", 9F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(128, 27);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 2;
            label4.Text = "总商铺数：";
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(52, 94, 131);
            panelTop.BgColor = Color.FromArgb(20, 46, 56);
            panelTop.BgColor2 = Color.Transparent;
            panelTop.Controls.Add(btnClose);
            panelTop.Controls.Add(btnMax);
            panelTop.Controls.Add(btnMin);
            panelTop.Controls.Add(btnDataImport);
            panelTop.Controls.Add(btnSetting);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(lblTime);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(pictureBox1);
            panelTop.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Radius = 5;
            panelTop.Size = new Size(1406, 75);
            panelTop.TabIndex = 1;
            panelTop.MouseDown += panelTop_MouseDown;
            panelTop.MouseMove += panelTop_MouseMove;
            panelTop.MouseUp += panelTop_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(20, 46, 56);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.White;
            btnClose.FlatAppearance.MouseOverBackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnClose.ForeColor = Color.Silver;
            btnClose.Location = new Point(1368, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 4;
            btnClose.Text = "r";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.FromArgb(20, 46, 56);
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseDownBackColor = Color.White;
            btnMax.FlatAppearance.MouseOverBackColor = Color.White;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMax.ForeColor = Color.Silver;
            btnMax.Location = new Point(1332, 7);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 4;
            btnMax.Text = "1";
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.FromArgb(20, 46, 56);
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.White;
            btnMin.FlatAppearance.MouseOverBackColor = Color.White;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnMin.ForeColor = Color.Silver;
            btnMin.Location = new Point(1296, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 4;
            btnMin.Text = "0";
            btnMin.TextAlign = ContentAlignment.TopCenter;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnDataImport
            // 
            btnDataImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDataImport.BackColor = Color.FromArgb(20, 46, 56);
            btnDataImport.BgColor = Color.FromArgb(20, 46, 56);
            btnDataImport.BgColor2 = Color.Transparent;
            btnDataImport.BorderColor = Color.LightGray;
            btnDataImport.BorderWidth = 1;
            btnDataImport.FlatAppearance.BorderSize = 0;
            btnDataImport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDataImport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDataImport.FlatStyle = FlatStyle.Flat;
            btnDataImport.ForeColor = Color.FromArgb(224, 224, 224);
            btnDataImport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnDataImport.Location = new Point(1111, 24);
            btnDataImport.Name = "btnDataImport";
            btnDataImport.Radius = 20;
            btnDataImport.SelectedColor = Color.FromArgb(255, 128, 0);
            btnDataImport.Size = new Size(122, 34);
            btnDataImport.TabIndex = 3;
            btnDataImport.Text = "基础信息导入";
            btnDataImport.UseVisualStyleBackColor = false;
            btnDataImport.Click += btnDataImport_Click;
            // 
            // btnSetting
            // 
            btnSetting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSetting.BackColor = Color.FromArgb(20, 46, 56);
            btnSetting.BgColor = Color.FromArgb(20, 46, 56);
            btnSetting.BgColor2 = Color.Transparent;
            btnSetting.BorderColor = Color.LightGray;
            btnSetting.BorderWidth = 1;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.ForeColor = Color.FromArgb(224, 224, 224);
            btnSetting.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnSetting.Location = new Point(997, 24);
            btnSetting.Name = "btnSetting";
            btnSetting.Radius = 20;
            btnSetting.SelectedColor = Color.FromArgb(255, 128, 0);
            btnSetting.Size = new Size(101, 34);
            btnSetting.TabIndex = 3;
            btnSetting.Text = "系统设置";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(20, 46, 56);
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(617, 45);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 2;
            label2.Text = "当前时间：";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.FromArgb(20, 46, 56);
            lblTime.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lblTime.ForeColor = Color.Gainsboro;
            lblTime.Location = new Point(707, 45);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(165, 19);
            lblTime.TabIndex = 2;
            lblTime.Text = "2024/03/04  21:54:30";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(20, 46, 56);
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(82, 21);
            label1.Name = "label1";
            label1.Size = new Size(325, 37);
            label1.TabIndex = 1;
            label1.Text = "智能商场集中监测与控制";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1410, 758);
            Controls.Add(uPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "智能商场集中监测与控制";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uPanel1.ResumeLayout(false);
            panelShopInfo.ResumeLayout(false);
            panelShopInfo.PerformLayout();
            uPanel6.ResumeLayout(false);
            flpList.ResumeLayout(false);
            uPanel5.ResumeLayout(false);
            panelNav.ResumeLayout(false);
            uPanel3.ResumeLayout(false);
            uPanel3.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private UControls.UPanel uPanel1;
        private UControls.UPanel panelTop;
        private UControls.UPanel panelNav;
        private UControls.UPanel uPanel3;
        private UControls.UPanel uPanel6;
        private FlowLayoutPanel flpList;
        private UControls.UPanel uPanel5;
        private UControls.UPanel panelShopInfo;
        private Label label1;
        private UControls.CircleButton btnSetting;
        private Label label2;
        private Label lblTime;
        private UControls.CircleButton btnDataImport;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
        private UControls.UNumericBox numTotalCount;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private UControls.UNumericBox numUnCount;
        private UControls.UNumericBox numRunningCount;
        private Label lblSelFloor;
        private UControls.UNumericBox numFloorUnCount;
        private UControls.UNumericBox numFloorRunningCount;
        private UControls.UNumericBox numFloorTotalCount;
        private Label label10;
        private Label label12;
        private Label label11;
        private UControls.ULine uLine1;
        private UControls.UCircleItem uCircleItem6;
        private UControls.UCircleItem uCircleItem5;
        private UControls.UCircleItem uCircleItem4;
        private UControls.UCircleItem uCircleItem3;
        private UControls.UCircleItem uCircleItem2;
        private UControls.UCircleItem uCircleItem1;
        private UControls.CircleButton btnStart;
        private UControls.UShopItem uShopItem1;
        private UControls.UShopItem uShopItem2;
        private UControls.UShopItem uShopItem3;
        private UControls.UShopItem uShopItem4;
        private UControls.UShopItem uShopItem5;
        private UControls.UShopItem uShopItem6;
        private Label lblSelshop;
        private UControls.ULine uLine3;
        private UControls.ULine uLine2;
        private Label label14;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private UControls.USwitch swOpen;
        private UControls.ULine uLine9;
        private UControls.ULine uLine8;
        private UControls.ULine uLine7;
        private UControls.ULine uLine6;
        private UControls.ULine uLine5;
        private UControls.ULine uLine4;
        private UControls.USwitch swEnergize;
        private UControls.USwitch swLight;
        private UControls.USwitch swFan;
        private UControls.ParaTextBox txtLastPowerReads;
        private UControls.ParaTextBox txtCurPowerReads;
        private UControls.ParaTextBox txtTodayPowers;
    }
}
