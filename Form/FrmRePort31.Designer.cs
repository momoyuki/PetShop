namespace Petshop
{
    partial class FrmRePort31
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRePort31));
            this.TabControlBill = new System.Windows.Forms.TabControl();
            this.tp_AllBill = new System.Windows.Forms.TabPage();
            this.dGV_Bill = new System.Windows.Forms.DataGridView();
            this.ccBill_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccRefer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBill_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBillSale_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBillSale_DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBillSale_Net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_Medi = new System.Windows.Forms.TabPage();
            this.dGV_Detail = new System.Windows.Forms.DataGridView();
            this.ccBill_IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccItem_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccItem_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBill_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBill_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccBill_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lb_BillID = new System.Windows.Forms.Label();
            this.txb_ReferID = new System.Windows.Forms.TextBox();
            this.lb_ReferID = new System.Windows.Forms.Label();
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.txb_BillDC = new System.Windows.Forms.TextBox();
            this.lb_DC = new System.Windows.Forms.Label();
            this.txb_BillNet = new System.Windows.Forms.TextBox();
            this.lb_Net = new System.Windows.Forms.Label();
            this.txb_BillTotal = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_Em = new System.Windows.Forms.Label();
            this.lb_DateBill = new System.Windows.Forms.Label();
            this.dTP_BillDate = new System.Windows.Forms.DateTimePicker();
            this.lb_Bill = new System.Windows.Forms.Label();
            this.lb_EmID = new System.Windows.Forms.Label();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.TabControlBill.SuspendLayout();
            this.tp_AllBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Bill)).BeginInit();
            this.tp_Medi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlBill
            // 
            this.TabControlBill.Controls.Add(this.tp_AllBill);
            this.TabControlBill.Controls.Add(this.tp_Medi);
            this.TabControlBill.Location = new System.Drawing.Point(12, 135);
            this.TabControlBill.Name = "TabControlBill";
            this.TabControlBill.SelectedIndex = 0;
            this.TabControlBill.Size = new System.Drawing.Size(984, 525);
            this.TabControlBill.TabIndex = 182;
            // 
            // tp_AllBill
            // 
            this.tp_AllBill.Controls.Add(this.dGV_Bill);
            this.tp_AllBill.Location = new System.Drawing.Point(4, 27);
            this.tp_AllBill.Name = "tp_AllBill";
            this.tp_AllBill.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AllBill.Size = new System.Drawing.Size(976, 494);
            this.tp_AllBill.TabIndex = 1;
            this.tp_AllBill.Text = "ใบเสร็จทั้งหมด";
            this.tp_AllBill.UseVisualStyleBackColor = true;
            // 
            // dGV_Bill
            // 
            this.dGV_Bill.AllowUserToAddRows = false;
            this.dGV_Bill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_Bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Bill.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGV_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccBill_ID,
            this.ccRefer_ID,
            this.ccEm_ID,
            this.ccEm_Name,
            this.ccBill_Date,
            this.ccBillSale_Total,
            this.ccBillSale_DC,
            this.ccBillSale_Net});
            this.dGV_Bill.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dGV_Bill.Location = new System.Drawing.Point(7, 7);
            this.dGV_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Bill.MultiSelect = false;
            this.dGV_Bill.Name = "dGV_Bill";
            this.dGV_Bill.ReadOnly = true;
            this.dGV_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Bill.Size = new System.Drawing.Size(962, 480);
            this.dGV_Bill.TabIndex = 111;
            this.dGV_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Bill_CellClick);
            // 
            // ccBill_ID
            // 
            this.ccBill_ID.DataPropertyName = "Bill_ID";
            this.ccBill_ID.FillWeight = 120F;
            this.ccBill_ID.HeaderText = "รหัสใบเสร็จ";
            this.ccBill_ID.Name = "ccBill_ID";
            this.ccBill_ID.ReadOnly = true;
            this.ccBill_ID.Width = 120;
            // 
            // ccRefer_ID
            // 
            this.ccRefer_ID.DataPropertyName = "Refer_ID";
            this.ccRefer_ID.FillWeight = 140F;
            this.ccRefer_ID.HeaderText = "รหัสอ้างอิง";
            this.ccRefer_ID.Name = "ccRefer_ID";
            this.ccRefer_ID.ReadOnly = true;
            this.ccRefer_ID.Width = 140;
            // 
            // ccEm_ID
            // 
            this.ccEm_ID.DataPropertyName = "Em_ID";
            this.ccEm_ID.HeaderText = "รหัสเจ้าหน้าที่";
            this.ccEm_ID.Name = "ccEm_ID";
            this.ccEm_ID.ReadOnly = true;
            this.ccEm_ID.Visible = false;
            // 
            // ccEm_Name
            // 
            this.ccEm_Name.DataPropertyName = "Em_Name";
            this.ccEm_Name.FillWeight = 200F;
            this.ccEm_Name.HeaderText = "ชื่อพนักงาน";
            this.ccEm_Name.Name = "ccEm_Name";
            this.ccEm_Name.ReadOnly = true;
            this.ccEm_Name.Width = 200;
            // 
            // ccBill_Date
            // 
            this.ccBill_Date.DataPropertyName = "Bill_Date";
            this.ccBill_Date.FillWeight = 140F;
            this.ccBill_Date.HeaderText = "ออกใบเสร็จเมื่อ";
            this.ccBill_Date.Name = "ccBill_Date";
            this.ccBill_Date.ReadOnly = true;
            this.ccBill_Date.Width = 140;
            // 
            // ccBillSale_Total
            // 
            this.ccBillSale_Total.DataPropertyName = "BillSale_Total";
            this.ccBillSale_Total.HeaderText = "รวม";
            this.ccBillSale_Total.Name = "ccBillSale_Total";
            this.ccBillSale_Total.ReadOnly = true;
            // 
            // ccBillSale_DC
            // 
            this.ccBillSale_DC.DataPropertyName = "BillSale_DC";
            this.ccBillSale_DC.HeaderText = "ส่วนลด";
            this.ccBillSale_DC.Name = "ccBillSale_DC";
            this.ccBillSale_DC.ReadOnly = true;
            // 
            // ccBillSale_Net
            // 
            this.ccBillSale_Net.DataPropertyName = "BillSale_Net";
            this.ccBillSale_Net.HeaderText = "สุทธิ";
            this.ccBillSale_Net.Name = "ccBillSale_Net";
            this.ccBillSale_Net.ReadOnly = true;
            // 
            // tp_Medi
            // 
            this.tp_Medi.Controls.Add(this.dGV_Detail);
            this.tp_Medi.Location = new System.Drawing.Point(4, 27);
            this.tp_Medi.Name = "tp_Medi";
            this.tp_Medi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Medi.Size = new System.Drawing.Size(976, 494);
            this.tp_Medi.TabIndex = 2;
            this.tp_Medi.Text = "รายละเอียด";
            this.tp_Medi.UseVisualStyleBackColor = true;
            // 
            // dGV_Detail
            // 
            this.dGV_Detail.AllowUserToAddRows = false;
            this.dGV_Detail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_Detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Detail.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGV_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccBill_IDd,
            this.ccItem_ID,
            this.ccItem_Detail,
            this.ccBill_Unit,
            this.ccBill_Price,
            this.ccBill_Amt});
            this.dGV_Detail.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dGV_Detail.Location = new System.Drawing.Point(7, 7);
            this.dGV_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Detail.MultiSelect = false;
            this.dGV_Detail.Name = "dGV_Detail";
            this.dGV_Detail.ReadOnly = true;
            this.dGV_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Detail.Size = new System.Drawing.Size(962, 480);
            this.dGV_Detail.TabIndex = 111;
            // 
            // ccBill_IDd
            // 
            this.ccBill_IDd.DataPropertyName = "Bill_ID";
            this.ccBill_IDd.HeaderText = "เลขที่ใบเสร็จ";
            this.ccBill_IDd.Name = "ccBill_IDd";
            this.ccBill_IDd.ReadOnly = true;
            this.ccBill_IDd.Visible = false;
            // 
            // ccItem_ID
            // 
            this.ccItem_ID.DataPropertyName = "Item_ID";
            this.ccItem_ID.HeaderText = "รหัสสินค้าบริการ";
            this.ccItem_ID.Name = "ccItem_ID";
            this.ccItem_ID.ReadOnly = true;
            this.ccItem_ID.Width = 150;
            // 
            // ccItem_Detail
            // 
            this.ccItem_Detail.DataPropertyName = "Item_Detail";
            this.ccItem_Detail.HeaderText = "รายการ";
            this.ccItem_Detail.Name = "ccItem_Detail";
            this.ccItem_Detail.ReadOnly = true;
            this.ccItem_Detail.Width = 400;
            // 
            // ccBill_Unit
            // 
            this.ccBill_Unit.DataPropertyName = "Bill_Unit";
            this.ccBill_Unit.HeaderText = "จำนวน";
            this.ccBill_Unit.Name = "ccBill_Unit";
            this.ccBill_Unit.ReadOnly = true;
            this.ccBill_Unit.Width = 120;
            // 
            // ccBill_Price
            // 
            this.ccBill_Price.DataPropertyName = "Bill_Price";
            this.ccBill_Price.HeaderText = "ราคาต่อหน่วย";
            this.ccBill_Price.Name = "ccBill_Price";
            this.ccBill_Price.ReadOnly = true;
            this.ccBill_Price.Width = 120;
            // 
            // ccBill_Amt
            // 
            this.ccBill_Amt.DataPropertyName = "Bill_Amt";
            this.ccBill_Amt.HeaderText = "ราคาสุทธิ";
            this.ccBill_Amt.Name = "ccBill_Amt";
            this.ccBill_Amt.ReadOnly = true;
            // 
            // Lb_BillID
            // 
            this.Lb_BillID.AutoSize = true;
            this.Lb_BillID.Location = new System.Drawing.Point(106, 9);
            this.Lb_BillID.Name = "Lb_BillID";
            this.Lb_BillID.Size = new System.Drawing.Size(0, 18);
            this.Lb_BillID.TabIndex = 181;
            this.Lb_BillID.TextChanged += new System.EventHandler(this.Lb_BillID_TextChanged);
            // 
            // txb_ReferID
            // 
            this.txb_ReferID.Enabled = false;
            this.txb_ReferID.Location = new System.Drawing.Point(109, 44);
            this.txb_ReferID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ReferID.MaxLength = 9;
            this.txb_ReferID.Name = "txb_ReferID";
            this.txb_ReferID.Size = new System.Drawing.Size(142, 26);
            this.txb_ReferID.TabIndex = 179;
            // 
            // lb_ReferID
            // 
            this.lb_ReferID.AutoSize = true;
            this.lb_ReferID.Location = new System.Drawing.Point(21, 48);
            this.lb_ReferID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ReferID.Name = "lb_ReferID";
            this.lb_ReferID.Size = new System.Drawing.Size(81, 18);
            this.lb_ReferID.TabIndex = 180;
            this.lb_ReferID.Text = "เลขที่อ้างอิง";
            // 
            // bt_Print
            // 
            this.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Print.Location = new System.Drawing.Point(889, 50);
            this.bt_Print.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(100, 79);
            this.bt_Print.TabIndex = 178;
            this.bt_Print.Text = "พิมพ์ใบเสร็จ";
            this.bt_Print.UseVisualStyleBackColor = true;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Load.Location = new System.Drawing.Point(846, 9);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(100, 32);
            this.bt_Load.TabIndex = 177;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Visible = false;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // txb_BillDC
            // 
            this.txb_BillDC.Enabled = false;
            this.txb_BillDC.Location = new System.Drawing.Point(506, 107);
            this.txb_BillDC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillDC.Name = "txb_BillDC";
            this.txb_BillDC.Size = new System.Drawing.Size(70, 26);
            this.txb_BillDC.TabIndex = 176;
            this.txb_BillDC.Text = "0.00";
            // 
            // lb_DC
            // 
            this.lb_DC.AutoSize = true;
            this.lb_DC.Location = new System.Drawing.Point(436, 111);
            this.lb_DC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DC.Name = "lb_DC";
            this.lb_DC.Size = new System.Drawing.Size(51, 18);
            this.lb_DC.TabIndex = 175;
            this.lb_DC.Text = "ส่วนลด";
            // 
            // txb_BillNet
            // 
            this.txb_BillNet.Enabled = false;
            this.txb_BillNet.Location = new System.Drawing.Point(650, 107);
            this.txb_BillNet.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillNet.Name = "txb_BillNet";
            this.txb_BillNet.Size = new System.Drawing.Size(70, 26);
            this.txb_BillNet.TabIndex = 174;
            this.txb_BillNet.Text = "0.00";
            // 
            // lb_Net
            // 
            this.lb_Net.AutoSize = true;
            this.lb_Net.Location = new System.Drawing.Point(595, 111);
            this.lb_Net.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Net.Name = "lb_Net";
            this.lb_Net.Size = new System.Drawing.Size(36, 18);
            this.lb_Net.TabIndex = 173;
            this.lb_Net.Text = "สุทธิ";
            // 
            // txb_BillTotal
            // 
            this.txb_BillTotal.Enabled = false;
            this.txb_BillTotal.Location = new System.Drawing.Point(347, 107);
            this.txb_BillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillTotal.Name = "txb_BillTotal";
            this.txb_BillTotal.Size = new System.Drawing.Size(70, 26);
            this.txb_BillTotal.TabIndex = 172;
            this.txb_BillTotal.Text = "0.00";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(258, 111);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(70, 18);
            this.lb_Total.TabIndex = 171;
            this.lb_Total.Text = "จำนวนรวม";
            // 
            // lb_Em
            // 
            this.lb_Em.AutoSize = true;
            this.lb_Em.Location = new System.Drawing.Point(283, 9);
            this.lb_Em.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Em.Name = "lb_Em";
            this.lb_Em.Size = new System.Drawing.Size(60, 18);
            this.lb_Em.TabIndex = 168;
            this.lb_Em.Text = "ออกโดย";
            // 
            // lb_DateBill
            // 
            this.lb_DateBill.AutoSize = true;
            this.lb_DateBill.Location = new System.Drawing.Point(258, 48);
            this.lb_DateBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DateBill.Name = "lb_DateBill";
            this.lb_DateBill.Size = new System.Drawing.Size(85, 18);
            this.lb_DateBill.TabIndex = 167;
            this.lb_DateBill.Text = "ออกเมื่อวันที่";
            // 
            // dTP_BillDate
            // 
            this.dTP_BillDate.Enabled = false;
            this.dTP_BillDate.Location = new System.Drawing.Point(350, 44);
            this.dTP_BillDate.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_BillDate.Name = "dTP_BillDate";
            this.dTP_BillDate.Size = new System.Drawing.Size(188, 26);
            this.dTP_BillDate.TabIndex = 166;
            // 
            // lb_Bill
            // 
            this.lb_Bill.AutoSize = true;
            this.lb_Bill.Location = new System.Drawing.Point(13, 9);
            this.lb_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bill.Name = "lb_Bill";
            this.lb_Bill.Size = new System.Drawing.Size(86, 18);
            this.lb_Bill.TabIndex = 170;
            this.lb_Bill.Text = "เลขที่ใบเสร็จ";
            // 
            // lb_EmID
            // 
            this.lb_EmID.AutoSize = true;
            this.lb_EmID.Location = new System.Drawing.Point(352, 9);
            this.lb_EmID.Name = "lb_EmID";
            this.lb_EmID.Size = new System.Drawing.Size(65, 18);
            this.lb_EmID.TabIndex = 183;
            this.lb_EmID.Text = "เจ้าหน้าที่";
            // 
            // bt_Reset
            // 
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Reset.Location = new System.Drawing.Point(546, 40);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(70, 32);
            this.bt_Reset.TabIndex = 184;
            this.bt_Reset.Text = "เริ่มใหม่";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_Refresh.Image")));
            this.bt_Refresh.Location = new System.Drawing.Point(953, 7);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(36, 36);
            this.bt_Refresh.TabIndex = 185;
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // FrmRePort31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.lb_EmID);
            this.Controls.Add(this.TabControlBill);
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
            this.Controls.Add(this.lb_Em);
            this.Controls.Add(this.lb_DateBill);
            this.Controls.Add(this.dTP_BillDate);
            this.Controls.Add(this.lb_Bill);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRePort31";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "พิมพ์ใบเสร็จ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRePort31_Load);
            this.TabControlBill.ResumeLayout(false);
            this.tp_AllBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Bill)).EndInit();
            this.tp_Medi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlBill;
        private System.Windows.Forms.TabPage tp_AllBill;
        private System.Windows.Forms.DataGridView dGV_Bill;
        private System.Windows.Forms.TabPage tp_Medi;
        private System.Windows.Forms.DataGridView dGV_Detail;
        public System.Windows.Forms.TextBox txb_ReferID;
        private System.Windows.Forms.Label lb_ReferID;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox txb_BillDC;
        private System.Windows.Forms.Label lb_DC;
        private System.Windows.Forms.TextBox txb_BillNet;
        private System.Windows.Forms.Label lb_Net;
        private System.Windows.Forms.TextBox txb_BillTotal;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_Em;
        private System.Windows.Forms.Label lb_DateBill;
        private System.Windows.Forms.DateTimePicker dTP_BillDate;
        private System.Windows.Forms.Label lb_Bill;
        private System.Windows.Forms.Label lb_EmID;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBill_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccRefer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBill_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBillSale_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBillSale_DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBillSale_Net;
        public System.Windows.Forms.Label Lb_BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBill_IDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccItem_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccItem_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBill_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBill_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccBill_Amt;
        private System.Windows.Forms.Button bt_Refresh;
    }
}