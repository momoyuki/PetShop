namespace Petshop
{
    partial class FrmRecorD22
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecorD22));
            this.lb_HealDate = new System.Windows.Forms.Label();
            this.lb_HealRecord = new System.Windows.Forms.Label();
            this.Txb_Remark = new System.Windows.Forms.TextBox();
            this.lb_RemarkDate = new System.Windows.Forms.Label();
            this.dTP_HealDate = new System.Windows.Forms.DateTimePicker();
            this.lb_HealDateTP = new System.Windows.Forms.Label();
            this.cb_Service = new System.Windows.Forms.ComboBox();
            this.bt_Load = new System.Windows.Forms.Button();
            this.bt_AddHealDate = new System.Windows.Forms.Button();
            this.bt_HealDateEdit = new System.Windows.Forms.Button();
            this.lb_Service = new System.Windows.Forms.Label();
            this.bt_PrintDate = new System.Windows.Forms.Button();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tP_All = new System.Windows.Forms.TabPage();
            this.rBt_Today = new System.Windows.Forms.RadioButton();
            this.bt_contract = new System.Windows.Forms.Button();
            this.rBt_contracted = new System.Windows.Forms.RadioButton();
            this.bt_contracted = new System.Windows.Forms.Button();
            this.rBt_contract = new System.Windows.Forms.RadioButton();
            this.rBt_All = new System.Windows.Forms.RadioButton();
            this.dGV_HealDate = new System.Windows.Forms.DataGridView();
            this.CheckBoxStats = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ccHealDate_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPet_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccOwner_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccOwner_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHealRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHeadDate_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHealDate_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPet_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHealDate_Stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHealDate_Remind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tP_Detail = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dGV_HealRecord = new System.Windows.Forms.DataGridView();
            this.ccHealRecord_ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccServiceMedi_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccServiceMedi_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_CountHealRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Remind = new System.Windows.Forms.TextBox();
            this.lb_Pet = new System.Windows.Forms.Label();
            this.lb_RemindDay = new System.Windows.Forms.Label();
            this.lb_HealDateID = new System.Windows.Forms.Label();
            this.lb_PetID = new System.Windows.Forms.Label();
            this.lb_HealRecordID = new System.Windows.Forms.Label();
            this.bt_HealDateDel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBox_Contract = new System.Windows.Forms.CheckBox();
            this.bt_PrintBill = new System.Windows.Forms.Button();
            this.bt_ResetRecord = new System.Windows.Forms.Button();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tP_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HealDate)).BeginInit();
            this.tP_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HealRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_HealDate
            // 
            this.lb_HealDate.AutoSize = true;
            this.lb_HealDate.Location = new System.Drawing.Point(754, 9);
            this.lb_HealDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HealDate.Name = "lb_HealDate";
            this.lb_HealDate.Size = new System.Drawing.Size(86, 18);
            this.lb_HealDate.TabIndex = 0;
            this.lb_HealDate.Text = "รหัสนัดหมาย";
            // 
            // lb_HealRecord
            // 
            this.lb_HealRecord.AutoSize = true;
            this.lb_HealRecord.Location = new System.Drawing.Point(266, 21);
            this.lb_HealRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HealRecord.Name = "lb_HealRecord";
            this.lb_HealRecord.Size = new System.Drawing.Size(104, 18);
            this.lb_HealRecord.TabIndex = 2;
            this.lb_HealRecord.Text = "รหัสประวัติรักษา";
            // 
            // Txb_Remark
            // 
            this.Txb_Remark.Location = new System.Drawing.Point(124, 120);
            this.Txb_Remark.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_Remark.MaxLength = 400;
            this.Txb_Remark.Multiline = true;
            this.Txb_Remark.Name = "Txb_Remark";
            this.Txb_Remark.Size = new System.Drawing.Size(351, 102);
            this.Txb_Remark.TabIndex = 3;
            // 
            // lb_RemarkDate
            // 
            this.lb_RemarkDate.AutoSize = true;
            this.lb_RemarkDate.Location = new System.Drawing.Point(47, 120);
            this.lb_RemarkDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_RemarkDate.Name = "lb_RemarkDate";
            this.lb_RemarkDate.Size = new System.Drawing.Size(67, 18);
            this.lb_RemarkDate.TabIndex = 5;
            this.lb_RemarkDate.Text = "หมายเหตุ";
            // 
            // dTP_HealDate
            // 
            this.dTP_HealDate.Location = new System.Drawing.Point(124, 86);
            this.dTP_HealDate.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_HealDate.Name = "dTP_HealDate";
            this.dTP_HealDate.Size = new System.Drawing.Size(189, 26);
            this.dTP_HealDate.TabIndex = 1;
            // 
            // lb_HealDateTP
            // 
            this.lb_HealDateTP.AutoSize = true;
            this.lb_HealDateTP.Location = new System.Drawing.Point(26, 90);
            this.lb_HealDateTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HealDateTP.Name = "lb_HealDateTP";
            this.lb_HealDateTP.Size = new System.Drawing.Size(88, 18);
            this.lb_HealDateTP.TabIndex = 7;
            this.lb_HealDateTP.Text = "นัดหมายวันที่";
            // 
            // cb_Service
            // 
            this.cb_Service.FormattingEnabled = true;
            this.cb_Service.Location = new System.Drawing.Point(126, 52);
            this.cb_Service.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Service.Name = "cb_Service";
            this.cb_Service.Size = new System.Drawing.Size(349, 26);
            this.cb_Service.TabIndex = 0;
            this.cb_Service.SelectionChangeCommitted += new System.EventHandler(this.cb_Service_SelectionChangeCommitted);
            // 
            // bt_Load
            // 
            this.bt_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Load.Location = new System.Drawing.Point(14, 154);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(100, 32);
            this.bt_Load.TabIndex = 10;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Visible = false;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // bt_AddHealDate
            // 
            this.bt_AddHealDate.Enabled = false;
            this.bt_AddHealDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddHealDate.Location = new System.Drawing.Point(743, 172);
            this.bt_AddHealDate.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddHealDate.Name = "bt_AddHealDate";
            this.bt_AddHealDate.Size = new System.Drawing.Size(97, 46);
            this.bt_AddHealDate.TabIndex = 5;
            this.bt_AddHealDate.Text = "เพิ่ม";
            this.bt_AddHealDate.UseVisualStyleBackColor = true;
            this.bt_AddHealDate.Click += new System.EventHandler(this.bt_AddHealDate_Click);
            // 
            // bt_HealDateEdit
            // 
            this.bt_HealDateEdit.Enabled = false;
            this.bt_HealDateEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_HealDateEdit.Location = new System.Drawing.Point(483, 126);
            this.bt_HealDateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HealDateEdit.Name = "bt_HealDateEdit";
            this.bt_HealDateEdit.Size = new System.Drawing.Size(97, 32);
            this.bt_HealDateEdit.TabIndex = 6;
            this.bt_HealDateEdit.Text = "แก้ไข";
            this.bt_HealDateEdit.UseVisualStyleBackColor = true;
            this.bt_HealDateEdit.Click += new System.EventHandler(this.bt_HealDateEdit_Click);
            // 
            // lb_Service
            // 
            this.lb_Service.AutoSize = true;
            this.lb_Service.Location = new System.Drawing.Point(79, 56);
            this.lb_Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Service.Name = "lb_Service";
            this.lb_Service.Size = new System.Drawing.Size(35, 18);
            this.lb_Service.TabIndex = 13;
            this.lb_Service.Text = "เรื่อง";
            // 
            // bt_PrintDate
            // 
            this.bt_PrintDate.Enabled = false;
            this.bt_PrintDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrintDate.Location = new System.Drawing.Point(848, 146);
            this.bt_PrintDate.Margin = new System.Windows.Forms.Padding(4);
            this.bt_PrintDate.Name = "bt_PrintDate";
            this.bt_PrintDate.Size = new System.Drawing.Size(100, 72);
            this.bt_PrintDate.TabIndex = 9;
            this.bt_PrintDate.Text = "พิมพ์ใบนัด";
            this.bt_PrintDate.UseVisualStyleBackColor = true;
            this.bt_PrintDate.Click += new System.EventHandler(this.bt_PrintDate_Click);
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(656, 10);
            this.txb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(177, 26);
            this.txb_Search.TabIndex = 6;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(605, 14);
            this.lb_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(43, 18);
            this.lb_Search.TabIndex = 8;
            this.lb_Search.Text = "ค้นหา";
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Location = new System.Drawing.Point(841, 7);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(100, 32);
            this.bt_Search.TabIndex = 7;
            this.bt_Search.Text = "ค้นหา";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tP_All);
            this.tabControl1.Controls.Add(this.tP_Detail);
            this.tabControl1.Location = new System.Drawing.Point(3, 226);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 434);
            this.tabControl1.TabIndex = 10;
            // 
            // tP_All
            // 
            this.tP_All.Controls.Add(this.rBt_Today);
            this.tP_All.Controls.Add(this.bt_contract);
            this.tP_All.Controls.Add(this.rBt_contracted);
            this.tP_All.Controls.Add(this.bt_contracted);
            this.tP_All.Controls.Add(this.rBt_contract);
            this.tP_All.Controls.Add(this.rBt_All);
            this.tP_All.Controls.Add(this.dGV_HealDate);
            this.tP_All.Controls.Add(this.lb_Search);
            this.tP_All.Controls.Add(this.txb_Search);
            this.tP_All.Controls.Add(this.bt_Search);
            this.tP_All.Location = new System.Drawing.Point(4, 27);
            this.tP_All.Name = "tP_All";
            this.tP_All.Padding = new System.Windows.Forms.Padding(3);
            this.tP_All.Size = new System.Drawing.Size(951, 403);
            this.tP_All.TabIndex = 1;
            this.tP_All.Text = "ทั้งหมด";
            this.tP_All.UseVisualStyleBackColor = true;
            // 
            // rBt_Today
            // 
            this.rBt_Today.AutoSize = true;
            this.rBt_Today.Checked = true;
            this.rBt_Today.Location = new System.Drawing.Point(255, 12);
            this.rBt_Today.Name = "rBt_Today";
            this.rBt_Today.Size = new System.Drawing.Size(51, 22);
            this.rBt_Today.TabIndex = 2;
            this.rBt_Today.TabStop = true;
            this.rBt_Today.Text = "วันนี้";
            this.rBt_Today.UseVisualStyleBackColor = true;
            this.rBt_Today.CheckedChanged += new System.EventHandler(this.rBt_Today_CheckedChanged);
            // 
            // bt_contract
            // 
            this.bt_contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_contract.Location = new System.Drawing.Point(119, 7);
            this.bt_contract.Margin = new System.Windows.Forms.Padding(4);
            this.bt_contract.Name = "bt_contract";
            this.bt_contract.Size = new System.Drawing.Size(97, 32);
            this.bt_contract.TabIndex = 1;
            this.bt_contract.Text = "ยังไม่ติดต่อ";
            this.bt_contract.UseVisualStyleBackColor = true;
            this.bt_contract.Click += new System.EventHandler(this.bt_contract_Click);
            // 
            // rBt_contracted
            // 
            this.rBt_contracted.AutoSize = true;
            this.rBt_contracted.Location = new System.Drawing.Point(511, 12);
            this.rBt_contracted.Name = "rBt_contracted";
            this.rBt_contracted.Size = new System.Drawing.Size(87, 22);
            this.rBt_contracted.TabIndex = 5;
            this.rBt_contracted.Text = "ติดต่อแล้ว";
            this.rBt_contracted.UseVisualStyleBackColor = true;
            this.rBt_contracted.CheckedChanged += new System.EventHandler(this.rBt_contracted_CheckedChanged);
            // 
            // bt_contracted
            // 
            this.bt_contracted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_contracted.Location = new System.Drawing.Point(14, 7);
            this.bt_contracted.Margin = new System.Windows.Forms.Padding(4);
            this.bt_contracted.Name = "bt_contracted";
            this.bt_contracted.Size = new System.Drawing.Size(97, 32);
            this.bt_contracted.TabIndex = 0;
            this.bt_contracted.Text = "ติดต่อแล้ว";
            this.bt_contracted.UseVisualStyleBackColor = true;
            this.bt_contracted.Click += new System.EventHandler(this.bt_contracted_Click);
            // 
            // rBt_contract
            // 
            this.rBt_contract.AutoSize = true;
            this.rBt_contract.Location = new System.Drawing.Point(396, 12);
            this.rBt_contract.Name = "rBt_contract";
            this.rBt_contract.Size = new System.Drawing.Size(112, 22);
            this.rBt_contract.TabIndex = 4;
            this.rBt_contract.Text = "ยังไม่ได้ติดต่อ";
            this.rBt_contract.UseVisualStyleBackColor = true;
            this.rBt_contract.CheckedChanged += new System.EventHandler(this.rBt_contract_CheckedChanged);
            // 
            // rBt_All
            // 
            this.rBt_All.AutoSize = true;
            this.rBt_All.Location = new System.Drawing.Point(318, 12);
            this.rBt_All.Name = "rBt_All";
            this.rBt_All.Size = new System.Drawing.Size(72, 22);
            this.rBt_All.TabIndex = 3;
            this.rBt_All.Text = "ทั้งหมด";
            this.rBt_All.UseVisualStyleBackColor = true;
            this.rBt_All.CheckedChanged += new System.EventHandler(this.rBt_All_CheckedChanged);
            // 
            // dGV_HealDate
            // 
            this.dGV_HealDate.AllowUserToAddRows = false;
            this.dGV_HealDate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_HealDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_HealDate.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_HealDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_HealDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxStats,
            this.ccHealDate_ID,
            this.ccPet_ID,
            this.ccService_Des,
            this.ccOwner_Name,
            this.ccOwner_Tel,
            this.ccHealRecord_ID,
            this.ccService_ID,
            this.ccHeadDate_Remark,
            this.ccHealDate_Day,
            this.ccPet_Name,
            this.ccHealDate_Stats,
            this.ccHealDate_Remind});
            this.dGV_HealDate.Location = new System.Drawing.Point(7, 45);
            this.dGV_HealDate.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_HealDate.MultiSelect = false;
            this.dGV_HealDate.Name = "dGV_HealDate";
            this.dGV_HealDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_HealDate.Size = new System.Drawing.Size(937, 351);
            this.dGV_HealDate.TabIndex = 9;
            this.dGV_HealDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_HealDate_CellClick);
            // 
            // CheckBoxStats
            // 
            this.CheckBoxStats.FillWeight = 30F;
            this.CheckBoxStats.HeaderText = "";
            this.CheckBoxStats.Name = "CheckBoxStats";
            this.CheckBoxStats.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckBoxStats.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBoxStats.Width = 30;
            // 
            // ccHealDate_ID
            // 
            this.ccHealDate_ID.DataPropertyName = "HealDate_ID";
            this.ccHealDate_ID.FillWeight = 120F;
            this.ccHealDate_ID.HeaderText = "รหัสนัดหมาย";
            this.ccHealDate_ID.Name = "ccHealDate_ID";
            this.ccHealDate_ID.ReadOnly = true;
            this.ccHealDate_ID.Visible = false;
            this.ccHealDate_ID.Width = 120;
            // 
            // ccPet_ID
            // 
            this.ccPet_ID.DataPropertyName = "Pet_ID";
            this.ccPet_ID.FillWeight = 120F;
            this.ccPet_ID.HeaderText = "รหัสสัตว์";
            this.ccPet_ID.Name = "ccPet_ID";
            this.ccPet_ID.ReadOnly = true;
            this.ccPet_ID.Width = 120;
            // 
            // ccService_Des
            // 
            this.ccService_Des.DataPropertyName = "Service_Des";
            this.ccService_Des.FillWeight = 150F;
            this.ccService_Des.HeaderText = "นัดเรื่อง";
            this.ccService_Des.Name = "ccService_Des";
            this.ccService_Des.Width = 150;
            // 
            // ccOwner_Name
            // 
            this.ccOwner_Name.DataPropertyName = "Owner_Name";
            this.ccOwner_Name.FillWeight = 200F;
            this.ccOwner_Name.HeaderText = "ชื่อเจ้าของ";
            this.ccOwner_Name.Name = "ccOwner_Name";
            this.ccOwner_Name.ReadOnly = true;
            this.ccOwner_Name.Width = 200;
            // 
            // ccOwner_Tel
            // 
            this.ccOwner_Tel.DataPropertyName = "Owner_Tel";
            this.ccOwner_Tel.FillWeight = 120F;
            this.ccOwner_Tel.HeaderText = "เบอร์ติดต่อ";
            this.ccOwner_Tel.Name = "ccOwner_Tel";
            this.ccOwner_Tel.ReadOnly = true;
            this.ccOwner_Tel.Width = 120;
            // 
            // ccHealRecord_ID
            // 
            this.ccHealRecord_ID.DataPropertyName = "HealRecord_ID";
            this.ccHealRecord_ID.HeaderText = "รหัสรักษา";
            this.ccHealRecord_ID.Name = "ccHealRecord_ID";
            this.ccHealRecord_ID.ReadOnly = true;
            this.ccHealRecord_ID.Visible = false;
            // 
            // ccService_ID
            // 
            this.ccService_ID.DataPropertyName = "Service_ID";
            this.ccService_ID.HeaderText = "รหัสบริการ";
            this.ccService_ID.Name = "ccService_ID";
            this.ccService_ID.ReadOnly = true;
            this.ccService_ID.Visible = false;
            // 
            // ccHeadDate_Remark
            // 
            this.ccHeadDate_Remark.DataPropertyName = "HealDate_Remark";
            this.ccHeadDate_Remark.FillWeight = 140F;
            this.ccHeadDate_Remark.HeaderText = "หมายเหตุ";
            this.ccHeadDate_Remark.Name = "ccHeadDate_Remark";
            this.ccHeadDate_Remark.ReadOnly = true;
            this.ccHeadDate_Remark.Visible = false;
            this.ccHeadDate_Remark.Width = 140;
            // 
            // ccHealDate_Day
            // 
            this.ccHealDate_Day.DataPropertyName = "HealDate_Day";
            this.ccHealDate_Day.FillWeight = 120F;
            this.ccHealDate_Day.HeaderText = "วันที่นัดหมาย";
            this.ccHealDate_Day.Name = "ccHealDate_Day";
            this.ccHealDate_Day.ReadOnly = true;
            this.ccHealDate_Day.Width = 120;
            // 
            // ccPet_Name
            // 
            this.ccPet_Name.DataPropertyName = "Pet_Name";
            this.ccPet_Name.HeaderText = "ชื่อสัตว์";
            this.ccPet_Name.Name = "ccPet_Name";
            this.ccPet_Name.ReadOnly = true;
            // 
            // ccHealDate_Stats
            // 
            this.ccHealDate_Stats.DataPropertyName = "HealDate_Status";
            this.ccHealDate_Stats.HeaderText = "สถานะ";
            this.ccHealDate_Stats.Name = "ccHealDate_Stats";
            this.ccHealDate_Stats.ReadOnly = true;
            this.ccHealDate_Stats.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ccHealDate_Stats.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ccHealDate_Remind
            // 
            this.ccHealDate_Remind.DataPropertyName = "HealDate_Remind";
            this.ccHealDate_Remind.HeaderText = "เตือนก่อน";
            this.ccHealDate_Remind.Name = "ccHealDate_Remind";
            this.ccHealDate_Remind.ReadOnly = true;
            this.ccHealDate_Remind.Visible = false;
            // 
            // tP_Detail
            // 
            this.tP_Detail.Controls.Add(this.label9);
            this.tP_Detail.Controls.Add(this.label7);
            this.tP_Detail.Controls.Add(this.dGV_HealRecord);
            this.tP_Detail.Controls.Add(this.lb_CountHealRecord);
            this.tP_Detail.Controls.Add(this.label3);
            this.tP_Detail.Location = new System.Drawing.Point(4, 27);
            this.tP_Detail.Name = "tP_Detail";
            this.tP_Detail.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Detail.Size = new System.Drawing.Size(951, 403);
            this.tP_Detail.TabIndex = 4;
            this.tP_Detail.Text = "ประวัติการรักษาก่อนหน้า";
            this.tP_Detail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(739, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "รายการ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "มีประวัติการรักษาก่อนหน้า";
            // 
            // dGV_HealRecord
            // 
            this.dGV_HealRecord.AllowUserToAddRows = false;
            this.dGV_HealRecord.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_HealRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_HealRecord.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_HealRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_HealRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccHealRecord_ID2,
            this.ccServiceMedi_ID,
            this.ccServiceMedi_Des});
            this.dGV_HealRecord.Location = new System.Drawing.Point(7, 55);
            this.dGV_HealRecord.MultiSelect = false;
            this.dGV_HealRecord.Name = "dGV_HealRecord";
            this.dGV_HealRecord.ReadOnly = true;
            this.dGV_HealRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_HealRecord.Size = new System.Drawing.Size(934, 342);
            this.dGV_HealRecord.TabIndex = 3;
            // 
            // ccHealRecord_ID2
            // 
            this.ccHealRecord_ID2.DataPropertyName = "HealRecord_ID";
            this.ccHealRecord_ID2.HeaderText = "HealRecord_ID";
            this.ccHealRecord_ID2.Name = "ccHealRecord_ID2";
            this.ccHealRecord_ID2.ReadOnly = true;
            this.ccHealRecord_ID2.Visible = false;
            // 
            // ccServiceMedi_ID
            // 
            this.ccServiceMedi_ID.DataPropertyName = "ServiceMedi_ID";
            this.ccServiceMedi_ID.FillWeight = 140F;
            this.ccServiceMedi_ID.HeaderText = "รหัส";
            this.ccServiceMedi_ID.Name = "ccServiceMedi_ID";
            this.ccServiceMedi_ID.ReadOnly = true;
            this.ccServiceMedi_ID.Width = 140;
            // 
            // ccServiceMedi_Des
            // 
            this.ccServiceMedi_Des.DataPropertyName = "ServiceMedi_Des";
            this.ccServiceMedi_Des.FillWeight = 400F;
            this.ccServiceMedi_Des.HeaderText = "รายละเอียด";
            this.ccServiceMedi_Des.Name = "ccServiceMedi_Des";
            this.ccServiceMedi_Des.ReadOnly = true;
            this.ccServiceMedi_Des.Width = 400;
            // 
            // lb_CountHealRecord
            // 
            this.lb_CountHealRecord.AutoSize = true;
            this.lb_CountHealRecord.Location = new System.Drawing.Point(651, 18);
            this.lb_CountHealRecord.Name = "lb_CountHealRecord";
            this.lb_CountHealRecord.Size = new System.Drawing.Size(0, 18);
            this.lb_CountHealRecord.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 0;
            // 
            // txb_Remind
            // 
            this.txb_Remind.Location = new System.Drawing.Point(395, 88);
            this.txb_Remind.Name = "txb_Remind";
            this.txb_Remind.Size = new System.Drawing.Size(51, 26);
            this.txb_Remind.TabIndex = 2;
            this.txb_Remind.Text = "1";
            // 
            // lb_Pet
            // 
            this.lb_Pet.AutoSize = true;
            this.lb_Pet.Location = new System.Drawing.Point(60, 21);
            this.lb_Pet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Pet.Name = "lb_Pet";
            this.lb_Pet.Size = new System.Drawing.Size(58, 18);
            this.lb_Pet.TabIndex = 22;
            this.lb_Pet.Text = "รหัสสัตว์";
            // 
            // lb_RemindDay
            // 
            this.lb_RemindDay.AutoSize = true;
            this.lb_RemindDay.Location = new System.Drawing.Point(321, 92);
            this.lb_RemindDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_RemindDay.Name = "lb_RemindDay";
            this.lb_RemindDay.Size = new System.Drawing.Size(67, 18);
            this.lb_RemindDay.TabIndex = 24;
            this.lb_RemindDay.Text = "เตือนก่อน";
            // 
            // lb_HealDateID
            // 
            this.lb_HealDateID.AutoSize = true;
            this.lb_HealDateID.Location = new System.Drawing.Point(847, 9);
            this.lb_HealDateID.Name = "lb_HealDateID";
            this.lb_HealDateID.Size = new System.Drawing.Size(0, 18);
            this.lb_HealDateID.TabIndex = 25;
            this.lb_HealDateID.TextChanged += new System.EventHandler(this.lb_HealDateID_TextChanged);
            // 
            // lb_PetID
            // 
            this.lb_PetID.AutoSize = true;
            this.lb_PetID.Location = new System.Drawing.Point(126, 21);
            this.lb_PetID.Name = "lb_PetID";
            this.lb_PetID.Size = new System.Drawing.Size(0, 18);
            this.lb_PetID.TabIndex = 26;
            this.lb_PetID.TextChanged += new System.EventHandler(this.lb_PetID_TextChanged);
            // 
            // lb_HealRecordID
            // 
            this.lb_HealRecordID.AutoSize = true;
            this.lb_HealRecordID.Location = new System.Drawing.Point(377, 21);
            this.lb_HealRecordID.Name = "lb_HealRecordID";
            this.lb_HealRecordID.Size = new System.Drawing.Size(0, 18);
            this.lb_HealRecordID.TabIndex = 27;
            this.lb_HealRecordID.TextChanged += new System.EventHandler(this.lb_HealRecordID_TextChanged);
            // 
            // bt_HealDateDel
            // 
            this.bt_HealDateDel.Enabled = false;
            this.bt_HealDateDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_HealDateDel.Location = new System.Drawing.Point(483, 166);
            this.bt_HealDateDel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HealDateDel.Name = "bt_HealDateDel";
            this.bt_HealDateDel.Size = new System.Drawing.Size(97, 32);
            this.bt_HealDateDel.TabIndex = 7;
            this.bt_HealDateDel.Text = "ลบ";
            this.bt_HealDateDel.UseVisualStyleBackColor = true;
            this.bt_HealDateDel.Click += new System.EventHandler(this.bt_HealDateDel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "วัน";
            // 
            // CheckBox_Contract
            // 
            this.CheckBox_Contract.AutoSize = true;
            this.CheckBox_Contract.Location = new System.Drawing.Point(483, 200);
            this.CheckBox_Contract.Name = "CheckBox_Contract";
            this.CheckBox_Contract.Size = new System.Drawing.Size(88, 22);
            this.CheckBox_Contract.TabIndex = 4;
            this.CheckBox_Contract.Text = "ติดต่อแล้ว";
            this.CheckBox_Contract.UseVisualStyleBackColor = true;
            // 
            // bt_PrintBill
            // 
            this.bt_PrintBill.Enabled = false;
            this.bt_PrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrintBill.Location = new System.Drawing.Point(848, 66);
            this.bt_PrintBill.Margin = new System.Windows.Forms.Padding(4);
            this.bt_PrintBill.Name = "bt_PrintBill";
            this.bt_PrintBill.Size = new System.Drawing.Size(100, 72);
            this.bt_PrintBill.TabIndex = 8;
            this.bt_PrintBill.Text = "พิมพ์ใบเสร็จ";
            this.bt_PrintBill.UseVisualStyleBackColor = true;
            this.bt_PrintBill.Click += new System.EventHandler(this.bt_PrintBill_Click);
            // 
            // bt_ResetRecord
            // 
            this.bt_ResetRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ResetRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ResetRecord.Location = new System.Drawing.Point(483, 14);
            this.bt_ResetRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ResetRecord.Name = "bt_ResetRecord";
            this.bt_ResetRecord.Size = new System.Drawing.Size(70, 32);
            this.bt_ResetRecord.TabIndex = 33;
            this.bt_ResetRecord.Text = "เริ่มใหม่";
            this.bt_ResetRecord.UseVisualStyleBackColor = true;
            this.bt_ResetRecord.Click += new System.EventHandler(this.bt_ResetRecord_Click);
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_Refresh.Image")));
            this.bt_Refresh.Location = new System.Drawing.Point(483, 53);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(36, 36);
            this.bt_Refresh.TabIndex = 34;
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "0.ยังไม่ได้ติดต่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "1.ติดต่อแล้ว";
            // 
            // FrmRecorD22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_ResetRecord);
            this.Controls.Add(this.bt_PrintBill);
            this.Controls.Add(this.CheckBox_Contract);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_HealDateDel);
            this.Controls.Add(this.lb_HealRecordID);
            this.Controls.Add(this.lb_PetID);
            this.Controls.Add(this.lb_HealDateID);
            this.Controls.Add(this.lb_RemindDay);
            this.Controls.Add(this.lb_Pet);
            this.Controls.Add(this.txb_Remind);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_PrintDate);
            this.Controls.Add(this.lb_Service);
            this.Controls.Add(this.bt_HealDateEdit);
            this.Controls.Add(this.bt_AddHealDate);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.cb_Service);
            this.Controls.Add(this.lb_HealDateTP);
            this.Controls.Add(this.dTP_HealDate);
            this.Controls.Add(this.lb_RemarkDate);
            this.Controls.Add(this.Txb_Remark);
            this.Controls.Add(this.lb_HealRecord);
            this.Controls.Add(this.lb_HealDate);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecorD22";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บันทึกประจำวัน ติดตามการรักษา";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM23_Load);
            this.tabControl1.ResumeLayout(false);
            this.tP_All.ResumeLayout(false);
            this.tP_All.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HealDate)).EndInit();
            this.tP_Detail.ResumeLayout(false);
            this.tP_Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HealRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_HealDate;
        private System.Windows.Forms.Label lb_HealRecord;
        private System.Windows.Forms.TextBox Txb_Remark;
        private System.Windows.Forms.Label lb_RemarkDate;
        private System.Windows.Forms.DateTimePicker dTP_HealDate;
        private System.Windows.Forms.Label lb_HealDateTP;
        private System.Windows.Forms.ComboBox cb_Service;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Button bt_AddHealDate;
        private System.Windows.Forms.Button bt_HealDateEdit;
        private System.Windows.Forms.Label lb_Service;
        private System.Windows.Forms.Button bt_PrintDate;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tP_All;
        private System.Windows.Forms.DataGridView dGV_HealDate;
        private System.Windows.Forms.TextBox txb_Remind;
        private System.Windows.Forms.Label lb_Pet;
        private System.Windows.Forms.Label lb_RemindDay;
        private System.Windows.Forms.Label lb_HealDateID;
        public System.Windows.Forms.Label lb_PetID;
        public System.Windows.Forms.Label lb_HealRecordID;
        private System.Windows.Forms.Button bt_contract;
        private System.Windows.Forms.Button bt_contracted;
        private System.Windows.Forms.Button bt_HealDateDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tP_Detail;
        private System.Windows.Forms.DataGridView dGV_HealRecord;
        private System.Windows.Forms.Label lb_CountHealRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rBt_contracted;
        private System.Windows.Forms.RadioButton rBt_contract;
        private System.Windows.Forms.RadioButton rBt_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealRecord_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccServiceMedi_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccServiceMedi_Des;
        private System.Windows.Forms.CheckBox CheckBox_Contract;
        private System.Windows.Forms.Button bt_PrintBill;
        private System.Windows.Forms.RadioButton rBt_Today;
        private System.Windows.Forms.Button bt_ResetRecord;
        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealDate_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPet_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccOwner_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccOwner_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHeadDate_Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealDate_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPet_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealDate_Stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealDate_Remind;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}