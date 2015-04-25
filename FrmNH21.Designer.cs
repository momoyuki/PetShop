namespace Petshop
{
    partial class FrmNH21
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
            this.dGV_Medi = new System.Windows.Forms.DataGridView();
            this.ccHealRecord_ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMedi_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMedi_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMediSale_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMedi_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMediRecord_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_ServiceAmt = new System.Windows.Forms.Label();
            this.lb_MediAmt = new System.Windows.Forms.Label();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_HealRecordID = new System.Windows.Forms.Label();
            this.tabControlServiceMedi = new System.Windows.Forms.TabControl();
            this.tPService = new System.Windows.Forms.TabPage();
            this.dGV_Service = new System.Windows.Forms.DataGridView();
            this.tPMedi = new System.Windows.Forms.TabPage();
            this.lb_HR = new System.Windows.Forms.Label();
            this.lb_ServiceA = new System.Windows.Forms.Label();
            this.lb_MediA = new System.Windows.Forms.Label();
            this.lb_HealRecordRR = new System.Windows.Forms.Label();
            this.lb_RR = new System.Windows.Forms.Label();
            this.lb_HealRecord = new System.Windows.Forms.Label();
            this.lb_HealRecordHR = new System.Windows.Forms.Label();
            this.dTP_HealRecordDate = new System.Windows.Forms.DateTimePicker();
            this.txb_RR = new System.Windows.Forms.TextBox();
            this.lb_HealRecordDate = new System.Windows.Forms.Label();
            this.txb_HR = new System.Windows.Forms.TextBox();
            this.lb_Employee = new System.Windows.Forms.Label();
            this.lb_Weight = new System.Windows.Forms.Label();
            this.txb_HealRecordDC = new System.Windows.Forms.TextBox();
            this.txb_Weight = new System.Windows.Forms.TextBox();
            this.lb_DC = new System.Windows.Forms.Label();
            this.txb_Temp = new System.Windows.Forms.TextBox();
            this.bt_PrintDate = new System.Windows.Forms.Button();
            this.lb_Temp = new System.Windows.Forms.Label();
            this.txb_PetID = new System.Windows.Forms.TextBox();
            this.lb_kg = new System.Windows.Forms.Label();
            this.txb_PetName = new System.Windows.Forms.TextBox();
            this.lb_TempF = new System.Windows.Forms.Label();
            this.lb_PetID = new System.Windows.Forms.Label();
            this.lb_PetName = new System.Windows.Forms.Label();
            this.lb_OwnerName = new System.Windows.Forms.Label();
            this.bt_LoadData = new System.Windows.Forms.Button();
            this.txb_OwnerName = new System.Windows.Forms.TextBox();
            this.txb_HealRecordNet = new System.Windows.Forms.TextBox();
            this.Lb_HealRecordDetail = new System.Windows.Forms.Label();
            this.lb_Net = new System.Windows.Forms.Label();
            this.lb_Remark = new System.Windows.Forms.Label();
            this.bt_PrintBill = new System.Windows.Forms.Button();
            this.txb_HealRecordSymptom = new System.Windows.Forms.TextBox();
            this.txb_HealRecordTotal = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.txb_HealRecordRemark = new System.Windows.Forms.TextBox();
            this.txb_Em = new System.Windows.Forms.TextBox();
            this.ccHealRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccService_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Medi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.tabControlServiceMedi.SuspendLayout();
            this.tPService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Service)).BeginInit();
            this.tPMedi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Medi
            // 
            this.dGV_Medi.AllowUserToAddRows = false;
            this.dGV_Medi.AllowUserToDeleteRows = false;
            this.dGV_Medi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_Medi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Medi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccHealRecord_ID2,
            this.ccMedi_ID,
            this.ccMedi_Des,
            this.ccMediSale_Unit,
            this.ccMedi_Sale,
            this.ccMediRecord_Total});
            this.dGV_Medi.Location = new System.Drawing.Point(8, 8);
            this.dGV_Medi.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Medi.Name = "dGV_Medi";
            this.dGV_Medi.ReadOnly = true;
            this.dGV_Medi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Medi.Size = new System.Drawing.Size(737, 279);
            this.dGV_Medi.TabIndex = 1;
            // 
            // ccHealRecord_ID2
            // 
            this.ccHealRecord_ID2.DataPropertyName = "HealRecord_ID";
            this.ccHealRecord_ID2.HeaderText = "เลขที่ทำการรักษา";
            this.ccHealRecord_ID2.Name = "ccHealRecord_ID2";
            this.ccHealRecord_ID2.ReadOnly = true;
            this.ccHealRecord_ID2.Visible = false;
            // 
            // ccMedi_ID
            // 
            this.ccMedi_ID.DataPropertyName = "Medi_ID";
            this.ccMedi_ID.FillWeight = 130F;
            this.ccMedi_ID.HeaderText = "รหัสยา";
            this.ccMedi_ID.Name = "ccMedi_ID";
            this.ccMedi_ID.ReadOnly = true;
            this.ccMedi_ID.Width = 130;
            // 
            // ccMedi_Des
            // 
            this.ccMedi_Des.DataPropertyName = "Medi_Des";
            this.ccMedi_Des.FillWeight = 240F;
            this.ccMedi_Des.HeaderText = "ชื่อยา";
            this.ccMedi_Des.Name = "ccMedi_Des";
            this.ccMedi_Des.ReadOnly = true;
            this.ccMedi_Des.Width = 240;
            // 
            // ccMediSale_Unit
            // 
            this.ccMediSale_Unit.DataPropertyName = "MediSale_Unit";
            this.ccMediSale_Unit.FillWeight = 80F;
            this.ccMediSale_Unit.HeaderText = "จำนวน";
            this.ccMediSale_Unit.Name = "ccMediSale_Unit";
            this.ccMediSale_Unit.ReadOnly = true;
            this.ccMediSale_Unit.Width = 80;
            // 
            // ccMedi_Sale
            // 
            this.ccMedi_Sale.DataPropertyName = "Medi_Sale";
            this.ccMedi_Sale.FillWeight = 120F;
            this.ccMedi_Sale.HeaderText = "ค่ายาต่อหน่วย";
            this.ccMedi_Sale.Name = "ccMedi_Sale";
            this.ccMedi_Sale.ReadOnly = true;
            this.ccMedi_Sale.Width = 120;
            // 
            // ccMediRecord_Total
            // 
            this.ccMediRecord_Total.DataPropertyName = "MediRecord_Total";
            this.ccMediRecord_Total.FillWeight = 120F;
            this.ccMediRecord_Total.HeaderText = "ราคารวม";
            this.ccMediRecord_Total.Name = "ccMediRecord_Total";
            this.ccMediRecord_Total.ReadOnly = true;
            this.ccMediRecord_Total.Width = 120;
            // 
            // lb_ServiceAmt
            // 
            this.lb_ServiceAmt.AutoSize = true;
            this.lb_ServiceAmt.Location = new System.Drawing.Point(369, 246);
            this.lb_ServiceAmt.Name = "lb_ServiceAmt";
            this.lb_ServiceAmt.Size = new System.Drawing.Size(37, 18);
            this.lb_ServiceAmt.TabIndex = 115;
            this.lb_ServiceAmt.Text = "0.00";
            // 
            // lb_MediAmt
            // 
            this.lb_MediAmt.AutoSize = true;
            this.lb_MediAmt.Location = new System.Drawing.Point(369, 274);
            this.lb_MediAmt.Name = "lb_MediAmt";
            this.lb_MediAmt.Size = new System.Drawing.Size(37, 18);
            this.lb_MediAmt.TabIndex = 120;
            this.lb_MediAmt.Text = "0.00";
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // lb_HealRecordID
            // 
            this.lb_HealRecordID.AutoSize = true;
            this.lb_HealRecordID.Location = new System.Drawing.Point(135, 8);
            this.lb_HealRecordID.Name = "lb_HealRecordID";
            this.lb_HealRecordID.Size = new System.Drawing.Size(0, 18);
            this.lb_HealRecordID.TabIndex = 130;
            this.lb_HealRecordID.TextChanged += new System.EventHandler(this.lb_HealRecordID_TextChanged);
            // 
            // tabControlServiceMedi
            // 
            this.tabControlServiceMedi.Controls.Add(this.tPService);
            this.tabControlServiceMedi.Controls.Add(this.tPMedi);
            this.tabControlServiceMedi.Location = new System.Drawing.Point(12, 332);
            this.tabControlServiceMedi.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlServiceMedi.Name = "tabControlServiceMedi";
            this.tabControlServiceMedi.SelectedIndex = 0;
            this.tabControlServiceMedi.Size = new System.Drawing.Size(978, 326);
            this.tabControlServiceMedi.TabIndex = 86;
            // 
            // tPService
            // 
            this.tPService.Controls.Add(this.dGV_Service);
            this.tPService.Location = new System.Drawing.Point(4, 27);
            this.tPService.Margin = new System.Windows.Forms.Padding(4);
            this.tPService.Name = "tPService";
            this.tPService.Padding = new System.Windows.Forms.Padding(4);
            this.tPService.Size = new System.Drawing.Size(970, 295);
            this.tPService.TabIndex = 0;
            this.tPService.Text = "บริการ";
            this.tPService.UseVisualStyleBackColor = true;
            // 
            // dGV_Service
            // 
            this.dGV_Service.AllowUserToAddRows = false;
            this.dGV_Service.AllowUserToDeleteRows = false;
            this.dGV_Service.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccHealRecord_ID,
            this.ccService_ID,
            this.ccService_Des,
            this.ccService_Price,
            this.ccService_Amt});
            this.dGV_Service.Location = new System.Drawing.Point(8, 8);
            this.dGV_Service.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Service.Name = "dGV_Service";
            this.dGV_Service.ReadOnly = true;
            this.dGV_Service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Service.Size = new System.Drawing.Size(737, 279);
            this.dGV_Service.TabIndex = 0;
            // 
            // tPMedi
            // 
            this.tPMedi.Controls.Add(this.dGV_Medi);
            this.tPMedi.Location = new System.Drawing.Point(4, 27);
            this.tPMedi.Margin = new System.Windows.Forms.Padding(4);
            this.tPMedi.Name = "tPMedi";
            this.tPMedi.Padding = new System.Windows.Forms.Padding(4);
            this.tPMedi.Size = new System.Drawing.Size(970, 295);
            this.tPMedi.TabIndex = 1;
            this.tPMedi.Text = "ยา";
            this.tPMedi.UseVisualStyleBackColor = true;
            // 
            // lb_HR
            // 
            this.lb_HR.AutoSize = true;
            this.lb_HR.Location = new System.Drawing.Point(934, 89);
            this.lb_HR.Name = "lb_HR";
            this.lb_HR.Size = new System.Drawing.Size(27, 18);
            this.lb_HR.TabIndex = 129;
            this.lb_HR.Text = "HR";
            // 
            // lb_ServiceA
            // 
            this.lb_ServiceA.AutoSize = true;
            this.lb_ServiceA.Location = new System.Drawing.Point(292, 246);
            this.lb_ServiceA.Name = "lb_ServiceA";
            this.lb_ServiceA.Size = new System.Drawing.Size(61, 18);
            this.lb_ServiceA.TabIndex = 113;
            this.lb_ServiceA.Text = "ค่าบริการ";
            // 
            // lb_MediA
            // 
            this.lb_MediA.AutoSize = true;
            this.lb_MediA.Location = new System.Drawing.Point(313, 274);
            this.lb_MediA.Name = "lb_MediA";
            this.lb_MediA.Size = new System.Drawing.Size(40, 18);
            this.lb_MediA.TabIndex = 118;
            this.lb_MediA.Text = "ค่ายา";
            // 
            // lb_HealRecordRR
            // 
            this.lb_HealRecordRR.AutoSize = true;
            this.lb_HealRecordRR.Location = new System.Drawing.Point(758, 121);
            this.lb_HealRecordRR.Name = "lb_HealRecordRR";
            this.lb_HealRecordRR.Size = new System.Drawing.Size(102, 18);
            this.lb_HealRecordRR.TabIndex = 128;
            this.lb_HealRecordRR.Text = "อัตราการหายใจ";
            // 
            // lb_RR
            // 
            this.lb_RR.AutoSize = true;
            this.lb_RR.Location = new System.Drawing.Point(934, 121);
            this.lb_RR.Name = "lb_RR";
            this.lb_RR.Size = new System.Drawing.Size(26, 18);
            this.lb_RR.TabIndex = 127;
            this.lb_RR.Text = "RR";
            // 
            // lb_HealRecord
            // 
            this.lb_HealRecord.AutoSize = true;
            this.lb_HealRecord.Location = new System.Drawing.Point(13, 8);
            this.lb_HealRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HealRecord.Name = "lb_HealRecord";
            this.lb_HealRecord.Size = new System.Drawing.Size(115, 18);
            this.lb_HealRecord.TabIndex = 101;
            this.lb_HealRecord.Text = "เลขที่ทำการรักษา";
            // 
            // lb_HealRecordHR
            // 
            this.lb_HealRecordHR.AutoSize = true;
            this.lb_HealRecordHR.Location = new System.Drawing.Point(744, 89);
            this.lb_HealRecordHR.Name = "lb_HealRecordHR";
            this.lb_HealRecordHR.Size = new System.Drawing.Size(116, 18);
            this.lb_HealRecordHR.TabIndex = 126;
            this.lb_HealRecordHR.Text = "อัตราการเต้นหัวใจ";
            // 
            // dTP_HealRecordDate
            // 
            this.dTP_HealRecordDate.Enabled = false;
            this.dTP_HealRecordDate.Location = new System.Drawing.Point(132, 71);
            this.dTP_HealRecordDate.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_HealRecordDate.Name = "dTP_HealRecordDate";
            this.dTP_HealRecordDate.Size = new System.Drawing.Size(178, 26);
            this.dTP_HealRecordDate.TabIndex = 85;
            // 
            // txb_RR
            // 
            this.txb_RR.Enabled = false;
            this.txb_RR.Location = new System.Drawing.Point(867, 117);
            this.txb_RR.Margin = new System.Windows.Forms.Padding(4);
            this.txb_RR.Name = "txb_RR";
            this.txb_RR.Size = new System.Drawing.Size(60, 26);
            this.txb_RR.TabIndex = 125;
            // 
            // lb_HealRecordDate
            // 
            this.lb_HealRecordDate.AutoSize = true;
            this.lb_HealRecordDate.Location = new System.Drawing.Point(20, 75);
            this.lb_HealRecordDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HealRecordDate.Name = "lb_HealRecordDate";
            this.lb_HealRecordDate.Size = new System.Drawing.Size(108, 18);
            this.lb_HealRecordDate.TabIndex = 87;
            this.lb_HealRecordDate.Text = "วันที่ทำการรักษา";
            // 
            // txb_HR
            // 
            this.txb_HR.Enabled = false;
            this.txb_HR.Location = new System.Drawing.Point(867, 85);
            this.txb_HR.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HR.Name = "txb_HR";
            this.txb_HR.Size = new System.Drawing.Size(60, 26);
            this.txb_HR.TabIndex = 124;
            // 
            // lb_Employee
            // 
            this.lb_Employee.AutoSize = true;
            this.lb_Employee.Location = new System.Drawing.Point(330, 75);
            this.lb_Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Employee.Name = "lb_Employee";
            this.lb_Employee.Size = new System.Drawing.Size(65, 18);
            this.lb_Employee.TabIndex = 88;
            this.lb_Employee.Text = "เจ้าหน้าที่";
            // 
            // lb_Weight
            // 
            this.lb_Weight.AutoSize = true;
            this.lb_Weight.Location = new System.Drawing.Point(808, 57);
            this.lb_Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Weight.Name = "lb_Weight";
            this.lb_Weight.Size = new System.Drawing.Size(52, 18);
            this.lb_Weight.TabIndex = 91;
            this.lb_Weight.Text = "น้ำหนัก";
            // 
            // txb_HealRecordDC
            // 
            this.txb_HealRecordDC.Enabled = false;
            this.txb_HealRecordDC.Location = new System.Drawing.Point(502, 298);
            this.txb_HealRecordDC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HealRecordDC.Name = "txb_HealRecordDC";
            this.txb_HealRecordDC.Size = new System.Drawing.Size(59, 26);
            this.txb_HealRecordDC.TabIndex = 122;
            this.txb_HealRecordDC.Text = "0.00";
            // 
            // txb_Weight
            // 
            this.txb_Weight.Enabled = false;
            this.txb_Weight.Location = new System.Drawing.Point(867, 53);
            this.txb_Weight.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Weight.Name = "txb_Weight";
            this.txb_Weight.Size = new System.Drawing.Size(60, 26);
            this.txb_Weight.TabIndex = 92;
            // 
            // lb_DC
            // 
            this.lb_DC.AutoSize = true;
            this.lb_DC.Location = new System.Drawing.Point(436, 302);
            this.lb_DC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DC.Name = "lb_DC";
            this.lb_DC.Size = new System.Drawing.Size(51, 18);
            this.lb_DC.TabIndex = 121;
            this.lb_DC.Text = "ส่วนลด";
            // 
            // txb_Temp
            // 
            this.txb_Temp.Enabled = false;
            this.txb_Temp.Location = new System.Drawing.Point(867, 21);
            this.txb_Temp.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Temp.Name = "txb_Temp";
            this.txb_Temp.Size = new System.Drawing.Size(60, 26);
            this.txb_Temp.TabIndex = 94;
            // 
            // bt_PrintDate
            // 
            this.bt_PrintDate.Enabled = false;
            this.bt_PrintDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrintDate.Location = new System.Drawing.Point(752, 276);
            this.bt_PrintDate.Margin = new System.Windows.Forms.Padding(4);
            this.bt_PrintDate.Name = "bt_PrintDate";
            this.bt_PrintDate.Size = new System.Drawing.Size(100, 46);
            this.bt_PrintDate.TabIndex = 119;
            this.bt_PrintDate.Text = "พิมพ์ใบนัด";
            this.bt_PrintDate.UseVisualStyleBackColor = true;
            this.bt_PrintDate.Click += new System.EventHandler(this.bt_PrintDate_Click);
            // 
            // lb_Temp
            // 
            this.lb_Temp.AutoSize = true;
            this.lb_Temp.Location = new System.Drawing.Point(802, 25);
            this.lb_Temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Temp.Name = "lb_Temp";
            this.lb_Temp.Size = new System.Drawing.Size(58, 18);
            this.lb_Temp.TabIndex = 95;
            this.lb_Temp.Text = "อุณหภูมิ";
            // 
            // txb_PetID
            // 
            this.txb_PetID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txb_PetID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txb_PetID.Enabled = false;
            this.txb_PetID.Location = new System.Drawing.Point(403, 5);
            this.txb_PetID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PetID.Name = "txb_PetID";
            this.txb_PetID.Size = new System.Drawing.Size(178, 26);
            this.txb_PetID.TabIndex = 117;
            // 
            // lb_kg
            // 
            this.lb_kg.AutoSize = true;
            this.lb_kg.Location = new System.Drawing.Point(934, 57);
            this.lb_kg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kg.Name = "lb_kg";
            this.lb_kg.Size = new System.Drawing.Size(30, 18);
            this.lb_kg.TabIndex = 93;
            this.lb_kg.Text = "Kg.";
            // 
            // txb_PetName
            // 
            this.txb_PetName.Enabled = false;
            this.txb_PetName.Location = new System.Drawing.Point(132, 39);
            this.txb_PetName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PetName.Name = "txb_PetName";
            this.txb_PetName.Size = new System.Drawing.Size(178, 26);
            this.txb_PetName.TabIndex = 116;
            // 
            // lb_TempF
            // 
            this.lb_TempF.AutoSize = true;
            this.lb_TempF.Location = new System.Drawing.Point(934, 25);
            this.lb_TempF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TempF.Name = "lb_TempF";
            this.lb_TempF.Size = new System.Drawing.Size(23, 18);
            this.lb_TempF.TabIndex = 96;
            this.lb_TempF.Text = "°F";
            // 
            // lb_PetID
            // 
            this.lb_PetID.AutoSize = true;
            this.lb_PetID.Location = new System.Drawing.Point(338, 9);
            this.lb_PetID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PetID.Name = "lb_PetID";
            this.lb_PetID.Size = new System.Drawing.Size(58, 18);
            this.lb_PetID.TabIndex = 114;
            this.lb_PetID.Text = "รหัสสัตว์";
            // 
            // lb_PetName
            // 
            this.lb_PetName.AutoSize = true;
            this.lb_PetName.Location = new System.Drawing.Point(79, 43);
            this.lb_PetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PetName.Name = "lb_PetName";
            this.lb_PetName.Size = new System.Drawing.Size(50, 18);
            this.lb_PetName.TabIndex = 97;
            this.lb_PetName.Text = "สัตว์ไข้";
            // 
            // lb_OwnerName
            // 
            this.lb_OwnerName.AutoSize = true;
            this.lb_OwnerName.Location = new System.Drawing.Point(326, 43);
            this.lb_OwnerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_OwnerName.Name = "lb_OwnerName";
            this.lb_OwnerName.Size = new System.Drawing.Size(71, 18);
            this.lb_OwnerName.TabIndex = 99;
            this.lb_OwnerName.Text = "เจ้าของชื่อ";
            // 
            // bt_LoadData
            // 
            this.bt_LoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoadData.Location = new System.Drawing.Point(553, 210);
            this.bt_LoadData.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadData.Name = "bt_LoadData";
            this.bt_LoadData.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadData.TabIndex = 110;
            this.bt_LoadData.Text = "LoadData";
            this.bt_LoadData.UseVisualStyleBackColor = true;
            this.bt_LoadData.Visible = false;
            this.bt_LoadData.Click += new System.EventHandler(this.bt_LoadData_Click);
            // 
            // txb_OwnerName
            // 
            this.txb_OwnerName.Enabled = false;
            this.txb_OwnerName.Location = new System.Drawing.Point(403, 39);
            this.txb_OwnerName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_OwnerName.Name = "txb_OwnerName";
            this.txb_OwnerName.Size = new System.Drawing.Size(178, 26);
            this.txb_OwnerName.TabIndex = 100;
            // 
            // txb_HealRecordNet
            // 
            this.txb_HealRecordNet.Enabled = false;
            this.txb_HealRecordNet.Location = new System.Drawing.Point(627, 298);
            this.txb_HealRecordNet.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HealRecordNet.Name = "txb_HealRecordNet";
            this.txb_HealRecordNet.Size = new System.Drawing.Size(59, 26);
            this.txb_HealRecordNet.TabIndex = 109;
            this.txb_HealRecordNet.Text = "0.00";
            // 
            // Lb_HealRecordDetail
            // 
            this.Lb_HealRecordDetail.AutoSize = true;
            this.Lb_HealRecordDetail.Location = new System.Drawing.Point(80, 115);
            this.Lb_HealRecordDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_HealRecordDetail.Name = "Lb_HealRecordDetail";
            this.Lb_HealRecordDetail.Size = new System.Drawing.Size(46, 18);
            this.Lb_HealRecordDetail.TabIndex = 102;
            this.Lb_HealRecordDetail.Text = "อาการ";
            // 
            // lb_Net
            // 
            this.lb_Net.AutoSize = true;
            this.lb_Net.Location = new System.Drawing.Point(576, 302);
            this.lb_Net.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Net.Name = "lb_Net";
            this.lb_Net.Size = new System.Drawing.Size(36, 18);
            this.lb_Net.TabIndex = 108;
            this.lb_Net.Text = "สุทธิ";
            // 
            // lb_Remark
            // 
            this.lb_Remark.AutoSize = true;
            this.lb_Remark.Location = new System.Drawing.Point(57, 217);
            this.lb_Remark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Remark.Name = "lb_Remark";
            this.lb_Remark.Size = new System.Drawing.Size(67, 18);
            this.lb_Remark.TabIndex = 103;
            this.lb_Remark.Text = "หมายเหตุ";
            // 
            // bt_PrintBill
            // 
            this.bt_PrintBill.Enabled = false;
            this.bt_PrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PrintBill.Location = new System.Drawing.Point(860, 276);
            this.bt_PrintBill.Margin = new System.Windows.Forms.Padding(4);
            this.bt_PrintBill.Name = "bt_PrintBill";
            this.bt_PrintBill.Size = new System.Drawing.Size(100, 46);
            this.bt_PrintBill.TabIndex = 90;
            this.bt_PrintBill.Text = "พิมพ์ใบเสร็จ";
            this.bt_PrintBill.UseVisualStyleBackColor = true;
            this.bt_PrintBill.Click += new System.EventHandler(this.bt_PrintBill_Click);
            // 
            // txb_HealRecordSymptom
            // 
            this.txb_HealRecordSymptom.Enabled = false;
            this.txb_HealRecordSymptom.Location = new System.Drawing.Point(134, 115);
            this.txb_HealRecordSymptom.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HealRecordSymptom.Multiline = true;
            this.txb_HealRecordSymptom.Name = "txb_HealRecordSymptom";
            this.txb_HealRecordSymptom.Size = new System.Drawing.Size(552, 90);
            this.txb_HealRecordSymptom.TabIndex = 104;
            // 
            // txb_HealRecordTotal
            // 
            this.txb_HealRecordTotal.Enabled = false;
            this.txb_HealRecordTotal.Location = new System.Drawing.Point(362, 298);
            this.txb_HealRecordTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HealRecordTotal.Name = "txb_HealRecordTotal";
            this.txb_HealRecordTotal.Size = new System.Drawing.Size(59, 26);
            this.txb_HealRecordTotal.TabIndex = 107;
            this.txb_HealRecordTotal.Text = "0.00";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(317, 302);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(30, 18);
            this.lb_Total.TabIndex = 106;
            this.lb_Total.Text = "รวม";
            // 
            // txb_HealRecordRemark
            // 
            this.txb_HealRecordRemark.Enabled = false;
            this.txb_HealRecordRemark.Location = new System.Drawing.Point(134, 213);
            this.txb_HealRecordRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HealRecordRemark.Name = "txb_HealRecordRemark";
            this.txb_HealRecordRemark.Size = new System.Drawing.Size(411, 26);
            this.txb_HealRecordRemark.TabIndex = 105;
            // 
            // txb_Em
            // 
            this.txb_Em.Enabled = false;
            this.txb_Em.Location = new System.Drawing.Point(403, 72);
            this.txb_Em.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Em.Name = "txb_Em";
            this.txb_Em.Size = new System.Drawing.Size(178, 26);
            this.txb_Em.TabIndex = 131;
            // 
            // ccHealRecord_ID
            // 
            this.ccHealRecord_ID.DataPropertyName = "HealRecord_ID";
            this.ccHealRecord_ID.HeaderText = "รหัสประวัติรักษา";
            this.ccHealRecord_ID.Name = "ccHealRecord_ID";
            this.ccHealRecord_ID.ReadOnly = true;
            this.ccHealRecord_ID.Visible = false;
            this.ccHealRecord_ID.Width = 120;
            // 
            // ccService_ID
            // 
            this.ccService_ID.DataPropertyName = "Service_ID";
            this.ccService_ID.HeaderText = "รหัสบริการ";
            this.ccService_ID.Name = "ccService_ID";
            this.ccService_ID.ReadOnly = true;
            this.ccService_ID.Width = 140;
            // 
            // ccService_Des
            // 
            this.ccService_Des.DataPropertyName = "Service_Des";
            this.ccService_Des.HeaderText = "บริการ";
            this.ccService_Des.Name = "ccService_Des";
            this.ccService_Des.ReadOnly = true;
            this.ccService_Des.Width = 350;
            // 
            // ccService_Price
            // 
            this.ccService_Price.DataPropertyName = "Service_Price";
            this.ccService_Price.HeaderText = "ค่าบริการต้น";
            this.ccService_Price.Name = "ccService_Price";
            this.ccService_Price.ReadOnly = true;
            this.ccService_Price.Visible = false;
            this.ccService_Price.Width = 140;
            // 
            // ccService_Amt
            // 
            this.ccService_Amt.DataPropertyName = "Service_Amt";
            this.ccService_Amt.HeaderText = "ค่าบริการ";
            this.ccService_Amt.Name = "ccService_Amt";
            this.ccService_Amt.ReadOnly = true;
            this.ccService_Amt.Width = 140;
            // 
            // FrmNH21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.txb_Em);
            this.Controls.Add(this.lb_ServiceAmt);
            this.Controls.Add(this.lb_MediAmt);
            this.Controls.Add(this.lb_HealRecordID);
            this.Controls.Add(this.tabControlServiceMedi);
            this.Controls.Add(this.lb_HR);
            this.Controls.Add(this.lb_ServiceA);
            this.Controls.Add(this.lb_MediA);
            this.Controls.Add(this.lb_HealRecordRR);
            this.Controls.Add(this.lb_RR);
            this.Controls.Add(this.lb_HealRecord);
            this.Controls.Add(this.lb_HealRecordHR);
            this.Controls.Add(this.dTP_HealRecordDate);
            this.Controls.Add(this.txb_RR);
            this.Controls.Add(this.lb_HealRecordDate);
            this.Controls.Add(this.txb_HR);
            this.Controls.Add(this.lb_Employee);
            this.Controls.Add(this.lb_Weight);
            this.Controls.Add(this.txb_HealRecordDC);
            this.Controls.Add(this.txb_Weight);
            this.Controls.Add(this.lb_DC);
            this.Controls.Add(this.txb_Temp);
            this.Controls.Add(this.bt_PrintDate);
            this.Controls.Add(this.lb_Temp);
            this.Controls.Add(this.txb_PetID);
            this.Controls.Add(this.lb_kg);
            this.Controls.Add(this.txb_PetName);
            this.Controls.Add(this.lb_TempF);
            this.Controls.Add(this.lb_PetID);
            this.Controls.Add(this.lb_PetName);
            this.Controls.Add(this.lb_OwnerName);
            this.Controls.Add(this.bt_LoadData);
            this.Controls.Add(this.txb_OwnerName);
            this.Controls.Add(this.txb_HealRecordNet);
            this.Controls.Add(this.Lb_HealRecordDetail);
            this.Controls.Add(this.lb_Net);
            this.Controls.Add(this.lb_Remark);
            this.Controls.Add(this.bt_PrintBill);
            this.Controls.Add(this.txb_HealRecordSymptom);
            this.Controls.Add(this.txb_HealRecordTotal);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.txb_HealRecordRemark);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNH21";
            this.Text = "FrmNH21";
            this.Load += new System.EventHandler(this.FrmNH21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Medi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.tabControlServiceMedi.ResumeLayout(false);
            this.tPService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Service)).EndInit();
            this.tPMedi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Medi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealRecord_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMedi_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMedi_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMediSale_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMedi_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMediRecord_Total;
        private System.Windows.Forms.Label lb_ServiceAmt;
        private System.Windows.Forms.Label lb_MediAmt;
        private System.Windows.Forms.ErrorProvider epCheck;
        public System.Windows.Forms.Label lb_HealRecordID;
        private System.Windows.Forms.TabControl tabControlServiceMedi;
        private System.Windows.Forms.TabPage tPService;
        private System.Windows.Forms.DataGridView dGV_Service;
        private System.Windows.Forms.TabPage tPMedi;
        private System.Windows.Forms.Label lb_HR;
        private System.Windows.Forms.Label lb_ServiceA;
        private System.Windows.Forms.Label lb_MediA;
        private System.Windows.Forms.Label lb_HealRecordRR;
        private System.Windows.Forms.Label lb_RR;
        private System.Windows.Forms.Label lb_HealRecord;
        private System.Windows.Forms.Label lb_HealRecordHR;
        private System.Windows.Forms.DateTimePicker dTP_HealRecordDate;
        private System.Windows.Forms.TextBox txb_RR;
        private System.Windows.Forms.Label lb_HealRecordDate;
        private System.Windows.Forms.TextBox txb_HR;
        private System.Windows.Forms.Label lb_Employee;
        private System.Windows.Forms.Label lb_Weight;
        private System.Windows.Forms.TextBox txb_HealRecordDC;
        private System.Windows.Forms.TextBox txb_Weight;
        private System.Windows.Forms.Label lb_DC;
        private System.Windows.Forms.TextBox txb_Temp;
        private System.Windows.Forms.Button bt_PrintDate;
        private System.Windows.Forms.Label lb_Temp;
        internal System.Windows.Forms.TextBox txb_PetID;
        private System.Windows.Forms.Label lb_kg;
        private System.Windows.Forms.TextBox txb_PetName;
        private System.Windows.Forms.Label lb_TempF;
        private System.Windows.Forms.Label lb_PetID;
        private System.Windows.Forms.Label lb_PetName;
        private System.Windows.Forms.Label lb_OwnerName;
        private System.Windows.Forms.Button bt_LoadData;
        private System.Windows.Forms.TextBox txb_OwnerName;
        private System.Windows.Forms.TextBox txb_HealRecordNet;
        private System.Windows.Forms.Label Lb_HealRecordDetail;
        private System.Windows.Forms.Label lb_Net;
        private System.Windows.Forms.Label lb_Remark;
        private System.Windows.Forms.Button bt_PrintBill;
        private System.Windows.Forms.TextBox txb_HealRecordSymptom;
        private System.Windows.Forms.TextBox txb_HealRecordTotal;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.TextBox txb_HealRecordRemark;
        private System.Windows.Forms.TextBox txb_Em;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccService_Amt;
    }
}