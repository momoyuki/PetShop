namespace Petshop
{
    partial class FrmBillSerMe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillSerMe));
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.txb_BillDC = new System.Windows.Forms.TextBox();
            this.lb_DC = new System.Windows.Forms.Label();
            this.txb_BillNet = new System.Windows.Forms.TextBox();
            this.lb_Net = new System.Windows.Forms.Label();
            this.txb_BillTotal = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.cb_Em = new System.Windows.Forms.ComboBox();
            this.lb_Em = new System.Windows.Forms.Label();
            this.lb_DateBill = new System.Windows.Forms.Label();
            this.dTP_ProductSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lb_Bill = new System.Windows.Forms.Label();
            this.txb_ReferID = new System.Windows.Forms.TextBox();
            this.lb_ReferID = new System.Windows.Forms.Label();
            this.Lb_BillID = new System.Windows.Forms.Label();
            this.TabControlServiceMediBill = new System.Windows.Forms.TabControl();
            this.tp_Service = new System.Windows.Forms.TabPage();
            this.CheckBoxService = new System.Windows.Forms.CheckBox();
            this.dGV_Service = new System.Windows.Forms.DataGridView();
            this.ccCheckBoxService = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ccHealRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_Medi = new System.Windows.Forms.TabPage();
            this.CheckBoxMedi = new System.Windows.Forms.CheckBox();
            this.dGV_Medi = new System.Windows.Forms.DataGridView();
            this.ccCheckBoxMedi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbYear = new System.Windows.Forms.Label();
            this.Lb_CoBill = new System.Windows.Forms.Label();
            this.bt_AddBill = new System.Windows.Forms.Button();
            this.lb_ServiceAmtBill = new System.Windows.Forms.Label();
            this.lb_Remark = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.TabControlServiceMediBill.SuspendLayout();
            this.tp_Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Service)).BeginInit();
            this.tp_Medi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Medi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Print
            // 
            this.bt_Print.Enabled = false;
            this.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Print.Location = new System.Drawing.Point(892, 49);
            this.bt_Print.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(100, 79);
            this.bt_Print.TabIndex = 127;
            this.bt_Print.Text = "พิมพ์ใบเสร็จ";
            this.bt_Print.UseVisualStyleBackColor = true;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Load.Location = new System.Drawing.Point(891, 6);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(100, 32);
            this.bt_Load.TabIndex = 125;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Visible = false;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // txb_BillDC
            // 
            this.txb_BillDC.Enabled = false;
            this.txb_BillDC.Location = new System.Drawing.Point(515, 94);
            this.txb_BillDC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillDC.Name = "txb_BillDC";
            this.txb_BillDC.Size = new System.Drawing.Size(70, 26);
            this.txb_BillDC.TabIndex = 124;
            this.txb_BillDC.Text = "0.00";
            this.txb_BillDC.TextChanged += new System.EventHandler(this.txb_BillDC_TextChanged);
            // 
            // lb_DC
            // 
            this.lb_DC.AutoSize = true;
            this.lb_DC.Location = new System.Drawing.Point(445, 98);
            this.lb_DC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DC.Name = "lb_DC";
            this.lb_DC.Size = new System.Drawing.Size(51, 18);
            this.lb_DC.TabIndex = 123;
            this.lb_DC.Text = "ส่วนลด";
            // 
            // txb_BillNet
            // 
            this.txb_BillNet.Enabled = false;
            this.txb_BillNet.Location = new System.Drawing.Point(659, 94);
            this.txb_BillNet.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillNet.Name = "txb_BillNet";
            this.txb_BillNet.Size = new System.Drawing.Size(70, 26);
            this.txb_BillNet.TabIndex = 122;
            this.txb_BillNet.Text = "0.00";
            // 
            // lb_Net
            // 
            this.lb_Net.AutoSize = true;
            this.lb_Net.Location = new System.Drawing.Point(604, 98);
            this.lb_Net.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Net.Name = "lb_Net";
            this.lb_Net.Size = new System.Drawing.Size(36, 18);
            this.lb_Net.TabIndex = 121;
            this.lb_Net.Text = "สุทธิ";
            // 
            // txb_BillTotal
            // 
            this.txb_BillTotal.Enabled = false;
            this.txb_BillTotal.Location = new System.Drawing.Point(356, 94);
            this.txb_BillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillTotal.Name = "txb_BillTotal";
            this.txb_BillTotal.Size = new System.Drawing.Size(70, 26);
            this.txb_BillTotal.TabIndex = 120;
            this.txb_BillTotal.Text = "0.00";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(267, 98);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(70, 18);
            this.lb_Total.TabIndex = 119;
            this.lb_Total.Text = "จำนวนรวม";
            // 
            // cb_Em
            // 
            this.cb_Em.FormattingEnabled = true;
            this.cb_Em.Location = new System.Drawing.Point(347, 10);
            this.cb_Em.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Em.Name = "cb_Em";
            this.cb_Em.Size = new System.Drawing.Size(244, 26);
            this.cb_Em.TabIndex = 115;
            // 
            // lb_Em
            // 
            this.lb_Em.AutoSize = true;
            this.lb_Em.Location = new System.Drawing.Point(279, 14);
            this.lb_Em.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Em.Name = "lb_Em";
            this.lb_Em.Size = new System.Drawing.Size(60, 18);
            this.lb_Em.TabIndex = 114;
            this.lb_Em.Text = "ออกโดย";
            // 
            // lb_DateBill
            // 
            this.lb_DateBill.AutoSize = true;
            this.lb_DateBill.Location = new System.Drawing.Point(261, 53);
            this.lb_DateBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DateBill.Name = "lb_DateBill";
            this.lb_DateBill.Size = new System.Drawing.Size(85, 18);
            this.lb_DateBill.TabIndex = 113;
            this.lb_DateBill.Text = "ออกเมื่อวันที่";
            // 
            // dTP_ProductSaleDate
            // 
            this.dTP_ProductSaleDate.Location = new System.Drawing.Point(353, 49);
            this.dTP_ProductSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_ProductSaleDate.Name = "dTP_ProductSaleDate";
            this.dTP_ProductSaleDate.Size = new System.Drawing.Size(188, 26);
            this.dTP_ProductSaleDate.TabIndex = 112;
            // 
            // lb_Bill
            // 
            this.lb_Bill.AutoSize = true;
            this.lb_Bill.Location = new System.Drawing.Point(16, 14);
            this.lb_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bill.Name = "lb_Bill";
            this.lb_Bill.Size = new System.Drawing.Size(86, 18);
            this.lb_Bill.TabIndex = 116;
            this.lb_Bill.Text = "เลขที่ใบเสร็จ";
            // 
            // txb_ReferID
            // 
            this.txb_ReferID.Enabled = false;
            this.txb_ReferID.Location = new System.Drawing.Point(112, 49);
            this.txb_ReferID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ReferID.MaxLength = 9;
            this.txb_ReferID.Name = "txb_ReferID";
            this.txb_ReferID.Size = new System.Drawing.Size(142, 26);
            this.txb_ReferID.TabIndex = 129;
            this.txb_ReferID.TextChanged += new System.EventHandler(this.txb_ReferID_TextChanged);
            // 
            // lb_ReferID
            // 
            this.lb_ReferID.AutoSize = true;
            this.lb_ReferID.Location = new System.Drawing.Point(24, 53);
            this.lb_ReferID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ReferID.Name = "lb_ReferID";
            this.lb_ReferID.Size = new System.Drawing.Size(81, 18);
            this.lb_ReferID.TabIndex = 130;
            this.lb_ReferID.Text = "เลขที่อ้างอิง";
            // 
            // Lb_BillID
            // 
            this.Lb_BillID.AutoSize = true;
            this.Lb_BillID.Location = new System.Drawing.Point(109, 14);
            this.Lb_BillID.Name = "Lb_BillID";
            this.Lb_BillID.Size = new System.Drawing.Size(0, 18);
            this.Lb_BillID.TabIndex = 135;
            this.Lb_BillID.TextChanged += new System.EventHandler(this.Lb_BillID_TextChanged);
            // 
            // TabControlServiceMediBill
            // 
            this.TabControlServiceMediBill.Controls.Add(this.tp_Service);
            this.TabControlServiceMediBill.Controls.Add(this.tp_Medi);
            this.TabControlServiceMediBill.Enabled = false;
            this.TabControlServiceMediBill.Location = new System.Drawing.Point(12, 135);
            this.TabControlServiceMediBill.Name = "TabControlServiceMediBill";
            this.TabControlServiceMediBill.SelectedIndex = 0;
            this.TabControlServiceMediBill.Size = new System.Drawing.Size(984, 525);
            this.TabControlServiceMediBill.TabIndex = 136;
            // 
            // tp_Service
            // 
            this.tp_Service.Controls.Add(this.CheckBoxService);
            this.tp_Service.Controls.Add(this.dGV_Service);
            this.tp_Service.Location = new System.Drawing.Point(4, 27);
            this.tp_Service.Name = "tp_Service";
            this.tp_Service.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Service.Size = new System.Drawing.Size(976, 494);
            this.tp_Service.TabIndex = 1;
            this.tp_Service.Text = "บริการ";
            this.tp_Service.UseVisualStyleBackColor = true;
            // 
            // CheckBoxService
            // 
            this.CheckBoxService.AutoSize = true;
            this.CheckBoxService.Location = new System.Drawing.Point(58, 14);
            this.CheckBoxService.Name = "CheckBoxService";
            this.CheckBoxService.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxService.TabIndex = 139;
            this.CheckBoxService.UseVisualStyleBackColor = true;
            this.CheckBoxService.CheckedChanged += new System.EventHandler(this.CheckBoxService_CheckedChanged);
            // 
            // dGV_Service
            // 
            this.dGV_Service.AllowUserToAddRows = false;
            this.dGV_Service.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_Service.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Service.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGV_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccCheckBoxService,
            this.ccHealRecord_ID,
            this.ccService_ID,
            this.ccService_Des,
            this.ccService_Amt});
            this.dGV_Service.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dGV_Service.Location = new System.Drawing.Point(7, 7);
            this.dGV_Service.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Service.MultiSelect = false;
            this.dGV_Service.Name = "dGV_Service";
            this.dGV_Service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Service.Size = new System.Drawing.Size(962, 480);
            this.dGV_Service.TabIndex = 111;
            // 
            // ccCheckBoxService
            // 
            this.ccCheckBoxService.FillWeight = 30F;
            this.ccCheckBoxService.HeaderText = "";
            this.ccCheckBoxService.Name = "ccCheckBoxService";
            this.ccCheckBoxService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ccCheckBoxService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ccCheckBoxService.Width = 30;
            // 
            // ccHealRecord_ID
            // 
            this.ccHealRecord_ID.DataPropertyName = "HealRecord_ID";
            this.ccHealRecord_ID.HeaderText = "รหัสใบเสร็จ";
            this.ccHealRecord_ID.Name = "ccHealRecord_ID";
            this.ccHealRecord_ID.Visible = false;
            this.ccHealRecord_ID.Width = 180;
            // 
            // ccService_ID
            // 
            this.ccService_ID.DataPropertyName = "Service_ID";
            this.ccService_ID.HeaderText = "รหัสบริการ";
            this.ccService_ID.Name = "ccService_ID";
            this.ccService_ID.Width = 180;
            // 
            // ccService_Des
            // 
            this.ccService_Des.DataPropertyName = "Service_Des";
            this.ccService_Des.HeaderText = "ชื่อบริการ";
            this.ccService_Des.Name = "ccService_Des";
            this.ccService_Des.Width = 400;
            // 
            // ccService_Amt
            // 
            this.ccService_Amt.DataPropertyName = "Service_Amt";
            this.ccService_Amt.HeaderText = "ค่าบริการ";
            this.ccService_Amt.Name = "ccService_Amt";
            // 
            // tp_Medi
            // 
            this.tp_Medi.Controls.Add(this.CheckBoxMedi);
            this.tp_Medi.Controls.Add(this.dGV_Medi);
            this.tp_Medi.Location = new System.Drawing.Point(4, 27);
            this.tp_Medi.Name = "tp_Medi";
            this.tp_Medi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Medi.Size = new System.Drawing.Size(976, 494);
            this.tp_Medi.TabIndex = 2;
            this.tp_Medi.Text = "ยา";
            this.tp_Medi.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMedi
            // 
            this.CheckBoxMedi.AutoSize = true;
            this.CheckBoxMedi.Location = new System.Drawing.Point(58, 14);
            this.CheckBoxMedi.Name = "CheckBoxMedi";
            this.CheckBoxMedi.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxMedi.TabIndex = 112;
            this.CheckBoxMedi.UseVisualStyleBackColor = true;
            this.CheckBoxMedi.CheckedChanged += new System.EventHandler(this.CheckBoxMedi_CheckedChanged);
            // 
            // dGV_Medi
            // 
            this.dGV_Medi.AllowUserToAddRows = false;
            this.dGV_Medi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_Medi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Medi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGV_Medi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Medi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccCheckBoxMedi,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dGV_Medi.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dGV_Medi.Location = new System.Drawing.Point(7, 7);
            this.dGV_Medi.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Medi.MultiSelect = false;
            this.dGV_Medi.Name = "dGV_Medi";
            this.dGV_Medi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Medi.Size = new System.Drawing.Size(962, 480);
            this.dGV_Medi.TabIndex = 111;
            // 
            // ccCheckBoxMedi
            // 
            this.ccCheckBoxMedi.FillWeight = 30F;
            this.ccCheckBoxMedi.HeaderText = "";
            this.ccCheckBoxMedi.Name = "ccCheckBoxMedi";
            this.ccCheckBoxMedi.Width = 30;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "HealRecord_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "รหัสใบเสร็จ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Medi_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "รหัสยา";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 180;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Medi_Des";
            this.dataGridViewTextBoxColumn11.HeaderText = "ชื่อยา";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 400;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MediSale_Unit";
            this.dataGridViewTextBoxColumn14.HeaderText = "จำนวน";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Medi_Sale";
            this.dataGridViewTextBoxColumn15.HeaderText = "ราคา";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MediRecord_Total";
            this.dataGridViewTextBoxColumn16.HeaderText = "ราคารวม";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(599, 14);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(49, 18);
            this.lbYear.TabIndex = 137;
            this.lbYear.Text = "lbYear";
            this.lbYear.Visible = false;
            // 
            // Lb_CoBill
            // 
            this.Lb_CoBill.AutoSize = true;
            this.Lb_CoBill.Location = new System.Drawing.Point(656, 14);
            this.Lb_CoBill.Name = "Lb_CoBill";
            this.Lb_CoBill.Size = new System.Drawing.Size(63, 18);
            this.Lb_CoBill.TabIndex = 138;
            this.Lb_CoBill.Text = "Lb_CoBill";
            this.Lb_CoBill.Visible = false;
            // 
            // bt_AddBill
            // 
            this.bt_AddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddBill.Location = new System.Drawing.Point(784, 94);
            this.bt_AddBill.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddBill.Name = "bt_AddBill";
            this.bt_AddBill.Size = new System.Drawing.Size(100, 34);
            this.bt_AddBill.TabIndex = 139;
            this.bt_AddBill.Text = "บันทึก";
            this.bt_AddBill.UseVisualStyleBackColor = true;
            this.bt_AddBill.Click += new System.EventHandler(this.bt_AddBill_Click);
            // 
            // lb_ServiceAmtBill
            // 
            this.lb_ServiceAmtBill.AutoSize = true;
            this.lb_ServiceAmtBill.Location = new System.Drawing.Point(554, 53);
            this.lb_ServiceAmtBill.Name = "lb_ServiceAmtBill";
            this.lb_ServiceAmtBill.Size = new System.Drawing.Size(0, 18);
            this.lb_ServiceAmtBill.TabIndex = 140;
            // 
            // lb_Remark
            // 
            this.lb_Remark.AutoSize = true;
            this.lb_Remark.Location = new System.Drawing.Point(68, 101);
            this.lb_Remark.Name = "lb_Remark";
            this.lb_Remark.Size = new System.Drawing.Size(184, 23);
            this.lb_Remark.TabIndex = 141;
            this.lb_Remark.Text = "*เลือกไม่รายการเพื่อไม่พิมพ์";
            this.lb_Remark.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Petshop.Properties.Resources.noun_16443;
            this.pictureBox1.Location = new System.Drawing.Point(37, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_Refresh.Image")));
            this.bt_Refresh.Location = new System.Drawing.Point(848, 53);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(36, 36);
            this.bt_Refresh.TabIndex = 143;
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // FrmBillSerMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Remark);
            this.Controls.Add(this.lb_ServiceAmtBill);
            this.Controls.Add(this.bt_AddBill);
            this.Controls.Add(this.Lb_CoBill);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.TabControlServiceMediBill);
            this.Controls.Add(this.Lb_BillID);
            this.Controls.Add(this.txb_ReferID);
            this.Controls.Add(this.lb_ReferID);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.txb_BillDC);
            this.Controls.Add(this.lb_DC);
            this.Controls.Add(this.txb_BillNet);
            this.Controls.Add(this.lb_Net);
            this.Controls.Add(this.txb_BillTotal);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.cb_Em);
            this.Controls.Add(this.lb_Em);
            this.Controls.Add(this.lb_DateBill);
            this.Controls.Add(this.dTP_ProductSaleDate);
            this.Controls.Add(this.lb_Bill);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBillSerMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ใบเสร็จ ตรวจรักษา บริการ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM341_Load);
            this.TabControlServiceMediBill.ResumeLayout(false);
            this.tp_Service.ResumeLayout(false);
            this.tp_Service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Service)).EndInit();
            this.tp_Medi.ResumeLayout(false);
            this.tp_Medi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Medi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox txb_BillDC;
        private System.Windows.Forms.Label lb_DC;
        private System.Windows.Forms.TextBox txb_BillNet;
        private System.Windows.Forms.Label lb_Net;
        private System.Windows.Forms.TextBox txb_BillTotal;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.ComboBox cb_Em;
        private System.Windows.Forms.Label lb_Em;
        private System.Windows.Forms.Label lb_DateBill;
        private System.Windows.Forms.DateTimePicker dTP_ProductSaleDate;
        private System.Windows.Forms.Label lb_Bill;
        private System.Windows.Forms.Label lb_ReferID;
        private System.Windows.Forms.TabControl TabControlServiceMediBill;
        private System.Windows.Forms.TabPage tp_Service;
        private System.Windows.Forms.DataGridView dGV_Service;
        private System.Windows.Forms.TabPage tp_Medi;
        private System.Windows.Forms.DataGridView dGV_Medi;
        public System.Windows.Forms.TextBox txb_ReferID;
        private System.Windows.Forms.Label Lb_BillID;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label Lb_CoBill;
        private System.Windows.Forms.CheckBox CheckBoxService;
        private System.Windows.Forms.CheckBox CheckBoxMedi;
        private System.Windows.Forms.Button bt_AddBill;
        private System.Windows.Forms.Label lb_ServiceAmtBill;
        private System.Windows.Forms.Label lb_Remark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ccCheckBoxService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_Amt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ccCheckBoxMedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button bt_Refresh;
    }
}