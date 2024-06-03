namespace Zhaoxi.IntelligentShoppingCenter
{
    partial class FrmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtSlot = new TextBox();
            txtRack = new TextBox();
            txtPort = new TextBox();
            txtIP = new TextBox();
            cboCpuTypes = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnFloorSave = new UControls.CircleButton();
            label7 = new Label();
            txtFloorName = new TextBox();
            txtFloorNo = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txtDataAddrs = new TextBox();
            txtStateAddrs = new TextBox();
            cboShops = new ComboBox();
            cboFloors = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnPLCSave = new UControls.CircleButton();
            btnParaSave = new UControls.CircleButton();
            btnParaImport = new UControls.CircleButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSlot);
            groupBox1.Controls.Add(txtRack);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Controls.Add(cboCpuTypes);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(33, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 418);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PLC通信设置";
            // 
            // txtSlot
            // 
            txtSlot.Location = new Point(134, 332);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(194, 27);
            txtSlot.TabIndex = 2;
            // 
            // txtRack
            // 
            txtRack.Location = new Point(134, 264);
            txtRack.Name = "txtRack";
            txtRack.Size = new Size(194, 27);
            txtRack.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(134, 200);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(194, 27);
            txtPort.TabIndex = 2;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(134, 135);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(194, 27);
            txtIP.TabIndex = 2;
            // 
            // cboCpuTypes
            // 
            cboCpuTypes.FormattingEnabled = true;
            cboCpuTypes.Items.AddRange(new object[] { "S71500", "S71200" });
            cboCpuTypes.Location = new Point(134, 68);
            cboCpuTypes.Name = "cboCpuTypes";
            cboCpuTypes.Size = new Size(194, 28);
            cboCpuTypes.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 335);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 0;
            label5.Text = "插槽";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 268);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 0;
            label4.Text = "机架";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 204);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 0;
            label3.Text = "端口";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 138);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "IP地址";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 73);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Cpu类型";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFloorSave);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtFloorName);
            groupBox2.Controls.Add(txtFloorNo);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(467, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(716, 86);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "楼层配置";
            // 
            // btnFloorSave
            // 
            btnFloorSave.BgColor = Color.Gainsboro;
            btnFloorSave.BgColor2 = Color.Transparent;
            btnFloorSave.BorderColor = Color.LightGray;
            btnFloorSave.BorderWidth = 1;
            btnFloorSave.FlatAppearance.BorderSize = 0;
            btnFloorSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFloorSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFloorSave.FlatStyle = FlatStyle.Flat;
            btnFloorSave.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnFloorSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnFloorSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnFloorSave.Location = new Point(596, 32);
            btnFloorSave.Name = "btnFloorSave";
            btnFloorSave.Radius = 20;
            btnFloorSave.Size = new Size(80, 33);
            btnFloorSave.TabIndex = 1;
            btnFloorSave.Text = "保存";
            btnFloorSave.UseVisualStyleBackColor = true;
            btnFloorSave.Click += btnFloorSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(315, 40);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 0;
            label7.Text = "楼层名";
            // 
            // txtFloorName
            // 
            txtFloorName.Location = new Point(384, 35);
            txtFloorName.Name = "txtFloorName";
            txtFloorName.Size = new Size(139, 27);
            txtFloorName.TabIndex = 2;
            // 
            // txtFloorNo
            // 
            txtFloorNo.Location = new Point(149, 35);
            txtFloorNo.Name = "txtFloorNo";
            txtFloorNo.Size = new Size(115, 27);
            txtFloorNo.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 40);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 0;
            label6.Text = "楼层号";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDataAddrs);
            groupBox3.Controls.Add(txtStateAddrs);
            groupBox3.Controls.Add(cboShops);
            groupBox3.Controls.Add(cboFloors);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(467, 173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(716, 302);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "商铺参数配置";
            // 
            // txtDataAddrs
            // 
            txtDataAddrs.Location = new Point(149, 234);
            txtDataAddrs.Name = "txtDataAddrs";
            txtDataAddrs.Size = new Size(527, 27);
            txtDataAddrs.TabIndex = 2;
            // 
            // txtStateAddrs
            // 
            txtStateAddrs.Location = new Point(149, 163);
            txtStateAddrs.Name = "txtStateAddrs";
            txtStateAddrs.Size = new Size(527, 27);
            txtStateAddrs.TabIndex = 2;
            // 
            // cboShops
            // 
            cboShops.FormattingEnabled = true;
            cboShops.Location = new Point(149, 87);
            cboShops.Name = "cboShops";
            cboShops.Size = new Size(194, 28);
            cboShops.TabIndex = 1;
            cboShops.SelectedIndexChanged += cboShops_SelectedIndexChanged;
            // 
            // cboFloors
            // 
            cboFloors.FormattingEnabled = true;
            cboFloors.Location = new Point(149, 33);
            cboFloors.Name = "cboFloors";
            cboFloors.Size = new Size(194, 28);
            cboFloors.TabIndex = 1;
            cboFloors.SelectedIndexChanged += cboFloors_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 238);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 0;
            label11.Text = "数据地址";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 166);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 0;
            label10.Text = "状态地址";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(149, 207);
            label13.Name = "label13";
            label13.Size = new Size(439, 20);
            label13.TabIndex = 0;
            label13.Text = "(数据地址按温度、湿度、当前电表读数、昨日电表读数顺序输入)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(149, 136);
            label12.Name = "label12";
            label12.Size = new Size(439, 20);
            label12.TabIndex = 0;
            label12.Text = "(状态地址按运营状态、空调、开门、通电、照明灯状态顺序输入)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 92);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 0;
            label9.Text = "商铺";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 36);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 0;
            label8.Text = "楼层";
            // 
            // btnPLCSave
            // 
            btnPLCSave.BgColor = Color.Gainsboro;
            btnPLCSave.BgColor2 = Color.Transparent;
            btnPLCSave.BorderColor = Color.LightGray;
            btnPLCSave.BorderWidth = 1;
            btnPLCSave.FlatAppearance.BorderSize = 0;
            btnPLCSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPLCSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPLCSave.FlatStyle = FlatStyle.Flat;
            btnPLCSave.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnPLCSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnPLCSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnPLCSave.Location = new Point(167, 495);
            btnPLCSave.Name = "btnPLCSave";
            btnPLCSave.Radius = 20;
            btnPLCSave.Size = new Size(80, 33);
            btnPLCSave.TabIndex = 1;
            btnPLCSave.Text = "保存";
            btnPLCSave.UseVisualStyleBackColor = true;
            btnPLCSave.Click += btnPLCSave_Click;
            // 
            // btnParaSave
            // 
            btnParaSave.BgColor = Color.Gainsboro;
            btnParaSave.BgColor2 = Color.Transparent;
            btnParaSave.BorderColor = Color.LightGray;
            btnParaSave.BorderWidth = 1;
            btnParaSave.FlatAppearance.BorderSize = 0;
            btnParaSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnParaSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnParaSave.FlatStyle = FlatStyle.Flat;
            btnParaSave.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnParaSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnParaSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnParaSave.Location = new Point(616, 495);
            btnParaSave.Name = "btnParaSave";
            btnParaSave.Radius = 20;
            btnParaSave.Size = new Size(80, 33);
            btnParaSave.TabIndex = 1;
            btnParaSave.Text = "保存";
            btnParaSave.UseVisualStyleBackColor = true;
            btnParaSave.Click += btnParaSave_Click;
            // 
            // btnParaImport
            // 
            btnParaImport.BgColor = Color.Gainsboro;
            btnParaImport.BgColor2 = Color.Transparent;
            btnParaImport.BorderColor = Color.LightGray;
            btnParaImport.BorderWidth = 1;
            btnParaImport.FlatAppearance.BorderSize = 0;
            btnParaImport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnParaImport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnParaImport.FlatStyle = FlatStyle.Flat;
            btnParaImport.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnParaImport.ForeColor = Color.FromArgb(64, 64, 64);
            btnParaImport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnParaImport.Location = new Point(1063, 18);
            btnParaImport.Name = "btnParaImport";
            btnParaImport.Radius = 5;
            btnParaImport.Size = new Size(120, 33);
            btnParaImport.TabIndex = 1;
            btnParaImport.Text = "商铺参数导入";
            btnParaImport.UseVisualStyleBackColor = true;
            btnParaImport.Click += btnParaImport_Click;
            // 
            // FrmSetting
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 46, 56);
            ClientSize = new Size(1218, 574);
            Controls.Add(btnParaImport);
            Controls.Add(btnParaSave);
            Controls.Add(btnPLCSave);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSetting";
            ShowIcon = false;
            Text = "系统设置";
            Load += FrmSetting_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtSlot;
        private TextBox txtRack;
        private TextBox txtPort;
        private TextBox txtIP;
        private ComboBox cboCpuTypes;
        private TextBox txtFloorNo;
        private TextBox txtDataAddrs;
        private TextBox txtStateAddrs;
        private ComboBox cboShops;
        private ComboBox cboFloors;
        private TextBox txtFloorName;
        private Label label13;
        private Label label12;
        private UControls.CircleButton btnPLCSave;
        private UControls.CircleButton btnFloorSave;
        private UControls.CircleButton btnParaSave;
        private UControls.CircleButton btnParaImport;
    }
}