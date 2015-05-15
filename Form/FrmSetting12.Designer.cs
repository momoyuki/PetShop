namespace Petshop
{
    partial class FrmSetting12
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting12));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Product = new System.Windows.Forms.DataGridView();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.txb_ProductID = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.txb_ProductName = new System.Windows.Forms.TextBox();
            this.gBoxProductPrice = new System.Windows.Forms.GroupBox();
            this.bt_ProductRefresh = new System.Windows.Forms.Button();
            this.CheckBox_Stock = new System.Windows.Forms.CheckBox();
            this.bt_Unit = new System.Windows.Forms.Button();
            this.cb_ProductUnit = new System.Windows.Forms.ComboBox();
            this.Bt_LoadPD = new System.Windows.Forms.Button();
            this.txb_ProductAmt = new System.Windows.Forms.TextBox();
            this.lb_Product_Unit_Amt = new System.Windows.Forms.Label();
            this.gBoxProducttrack = new System.Windows.Forms.GroupBox();
            this.txb_ProductOrder = new System.Windows.Forms.TextBox();
            this.lb_Product_Unit_Order = new System.Windows.Forms.Label();
            this.dTP_Expired = new System.Windows.Forms.DateTimePicker();
            this.lb_ProductExpired = new System.Windows.Forms.Label();
            this.dTP_Product = new System.Windows.Forms.DateTimePicker();
            this.lb_ProductProduct = new System.Windows.Forms.Label();
            this.lb_Unit = new System.Windows.Forms.Label();
            this.txb_ProductSale = new System.Windows.Forms.TextBox();
            this.lb_ProductSale = new System.Windows.Forms.Label();
            this.txb_ProductPrice = new System.Windows.Forms.TextBox();
            this.lb_ProductPrice = new System.Windows.Forms.Label();
            this.bt_AddProduct = new System.Windows.Forms.Button();
            this.bt_EditProduct = new System.Windows.Forms.Button();
            this.lb_Detail = new System.Windows.Forms.Label();
            this.txb_ProductDetail = new System.Windows.Forms.TextBox();
            this.lb_ProductIDh = new System.Windows.Forms.Label();
            this.bt_DelProduct = new System.Windows.Forms.Button();
            this.bt_reSetProduct = new System.Windows.Forms.Button();
            this.lb_SearchProduct = new System.Windows.Forms.Label();
            this.lb_SearchProductB = new System.Windows.Forms.Label();
            this.lb_SearchProductA = new System.Windows.Forms.Label();
            this.txb_SearchProduct = new System.Windows.Forms.TextBox();
            this.bt_SearchProduct = new System.Windows.Forms.Button();
            this.lb_count = new System.Windows.Forms.Label();
            this.ccProduct_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Unit_Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Unit_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccUnit_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.gBoxProductPrice.SuspendLayout();
            this.gBoxProducttrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Product
            // 
            this.dGV_Product.AllowUserToAddRows = false;
            this.dGV_Product.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Product.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccProduct_ID,
            this.ccProduct_Des,
            this.ccProduct_Detail,
            this.ccProduct_Price,
            this.ccProduct_Sale,
            this.ccProduct_Unit,
            this.ccProduct_Product,
            this.ccProduct_Expired,
            this.ccProduct_Unit_Amt,
            this.ccProduct_Unit_Order,
            this.ccUnit_ID,
            this.ccProduct_Stock});
            this.dGV_Product.Location = new System.Drawing.Point(13, 333);
            this.dGV_Product.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Product.MultiSelect = false;
            this.dGV_Product.Name = "dGV_Product";
            this.dGV_Product.ReadOnly = true;
            this.dGV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Product.Size = new System.Drawing.Size(982, 326);
            this.dGV_Product.TabIndex = 9;
            this.dGV_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_PD_CellClick);
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(13, 29);
            this.lb_ProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(75, 18);
            this.lb_ProductID.TabIndex = 0;
            this.lb_ProductID.Text = "รหัสสินค้า*";
            // 
            // txb_ProductID
            // 
            this.txb_ProductID.Location = new System.Drawing.Point(96, 25);
            this.txb_ProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductID.MaxLength = 16;
            this.txb_ProductID.Name = "txb_ProductID";
            this.txb_ProductID.Size = new System.Drawing.Size(166, 26);
            this.txb_ProductID.TabIndex = 0;
            this.txb_ProductID.TextChanged += new System.EventHandler(this.txb_ProductID_TextChanged);
            this.txb_ProductID.Enter += new System.EventHandler(this.txb_ProductID_Enter);
            this.txb_ProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_ProductID_KeyDown);
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(20, 63);
            this.lb_ProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(68, 18);
            this.lb_ProductName.TabIndex = 2;
            this.lb_ProductName.Text = "ชื่อสินค้า*";
            // 
            // txb_ProductName
            // 
            this.txb_ProductName.Location = new System.Drawing.Point(96, 59);
            this.txb_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductName.MaxLength = 100;
            this.txb_ProductName.Name = "txb_ProductName";
            this.txb_ProductName.Size = new System.Drawing.Size(256, 26);
            this.txb_ProductName.TabIndex = 1;
            this.txb_ProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_ProductName_KeyDown);
            // 
            // gBoxProductPrice
            // 
            this.gBoxProductPrice.Controls.Add(this.bt_ProductRefresh);
            this.gBoxProductPrice.Controls.Add(this.CheckBox_Stock);
            this.gBoxProductPrice.Controls.Add(this.bt_Unit);
            this.gBoxProductPrice.Controls.Add(this.cb_ProductUnit);
            this.gBoxProductPrice.Controls.Add(this.Bt_LoadPD);
            this.gBoxProductPrice.Controls.Add(this.txb_ProductAmt);
            this.gBoxProductPrice.Controls.Add(this.lb_Product_Unit_Amt);
            this.gBoxProductPrice.Controls.Add(this.gBoxProducttrack);
            this.gBoxProductPrice.Controls.Add(this.dTP_Expired);
            this.gBoxProductPrice.Controls.Add(this.lb_ProductExpired);
            this.gBoxProductPrice.Controls.Add(this.dTP_Product);
            this.gBoxProductPrice.Controls.Add(this.lb_ProductProduct);
            this.gBoxProductPrice.Controls.Add(this.lb_Unit);
            this.gBoxProductPrice.Controls.Add(this.txb_ProductSale);
            this.gBoxProductPrice.Controls.Add(this.lb_ProductSale);
            this.gBoxProductPrice.Controls.Add(this.txb_ProductPrice);
            this.gBoxProductPrice.Controls.Add(this.lb_ProductPrice);
            this.gBoxProductPrice.Location = new System.Drawing.Point(452, 13);
            this.gBoxProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxProductPrice.Name = "gBoxProductPrice";
            this.gBoxProductPrice.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxProductPrice.Size = new System.Drawing.Size(533, 277);
            this.gBoxProductPrice.TabIndex = 3;
            this.gBoxProductPrice.TabStop = false;
            this.gBoxProductPrice.Text = "ต้นทุนและราคาขาย";
            // 
            // bt_ProductRefresh
            // 
            this.bt_ProductRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ProductRefresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_ProductRefresh.Image")));
            this.bt_ProductRefresh.Location = new System.Drawing.Point(490, 19);
            this.bt_ProductRefresh.Name = "bt_ProductRefresh";
            this.bt_ProductRefresh.Size = new System.Drawing.Size(36, 36);
            this.bt_ProductRefresh.TabIndex = 8;
            this.bt_ProductRefresh.UseVisualStyleBackColor = true;
            this.bt_ProductRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBox_Stock
            // 
            this.CheckBox_Stock.AutoSize = true;
            this.CheckBox_Stock.Location = new System.Drawing.Point(422, 215);
            this.CheckBox_Stock.Name = "CheckBox_Stock";
            this.CheckBox_Stock.Size = new System.Drawing.Size(104, 22);
            this.CheckBox_Stock.TabIndex = 7;
            this.CheckBox_Stock.Text = "ตัดคลังสินค้า";
            this.CheckBox_Stock.UseVisualStyleBackColor = true;
            // 
            // bt_Unit
            // 
            this.bt_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Unit.Location = new System.Drawing.Point(370, 97);
            this.bt_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Unit.Name = "bt_Unit";
            this.bt_Unit.Size = new System.Drawing.Size(100, 32);
            this.bt_Unit.TabIndex = 9;
            this.bt_Unit.Text = "เพิ่มหน่วย";
            this.bt_Unit.UseVisualStyleBackColor = false;
            this.bt_Unit.Click += new System.EventHandler(this.bt_Unit_Click);
            // 
            // cb_ProductUnit
            // 
            this.cb_ProductUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_ProductUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ProductUnit.FormattingEnabled = true;
            this.cb_ProductUnit.Location = new System.Drawing.Point(366, 25);
            this.cb_ProductUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ProductUnit.Name = "cb_ProductUnit";
            this.cb_ProductUnit.Size = new System.Drawing.Size(104, 26);
            this.cb_ProductUnit.TabIndex = 2;
            this.cb_ProductUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_ProductUnit_KeyDown);
            // 
            // Bt_LoadPD
            // 
            this.Bt_LoadPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_LoadPD.Location = new System.Drawing.Point(370, 133);
            this.Bt_LoadPD.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_LoadPD.Name = "Bt_LoadPD";
            this.Bt_LoadPD.Size = new System.Drawing.Size(100, 32);
            this.Bt_LoadPD.TabIndex = 8;
            this.Bt_LoadPD.Text = "LoadPD";
            this.Bt_LoadPD.UseVisualStyleBackColor = true;
            this.Bt_LoadPD.Visible = false;
            this.Bt_LoadPD.Click += new System.EventHandler(this.Bt_LoadPD_Click);
            // 
            // txb_ProductAmt
            // 
            this.txb_ProductAmt.Location = new System.Drawing.Point(366, 63);
            this.txb_ProductAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductAmt.MaxLength = 4;
            this.txb_ProductAmt.Name = "txb_ProductAmt";
            this.txb_ProductAmt.Size = new System.Drawing.Size(104, 26);
            this.txb_ProductAmt.TabIndex = 3;
            this.txb_ProductAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_ProductAmt_KeyDown);
            // 
            // lb_Product_Unit_Amt
            // 
            this.lb_Product_Unit_Amt.AutoSize = true;
            this.lb_Product_Unit_Amt.Location = new System.Drawing.Point(263, 67);
            this.lb_Product_Unit_Amt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Product_Unit_Amt.Name = "lb_Product_Unit_Amt";
            this.lb_Product_Unit_Amt.Size = new System.Drawing.Size(105, 18);
            this.lb_Product_Unit_Amt.TabIndex = 13;
            this.lb_Product_Unit_Amt.Text = "จำนวนคงเหลือ*";
            // 
            // gBoxProducttrack
            // 
            this.gBoxProducttrack.Controls.Add(this.txb_ProductOrder);
            this.gBoxProducttrack.Controls.Add(this.lb_Product_Unit_Order);
            this.gBoxProducttrack.Location = new System.Drawing.Point(27, 184);
            this.gBoxProducttrack.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxProducttrack.Name = "gBoxProducttrack";
            this.gBoxProducttrack.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxProducttrack.Size = new System.Drawing.Size(388, 70);
            this.gBoxProducttrack.TabIndex = 6;
            this.gBoxProducttrack.TabStop = false;
            this.gBoxProducttrack.Text = "การแจ้งเตือน";
            // 
            // txb_ProductOrder
            // 
            this.txb_ProductOrder.Location = new System.Drawing.Point(265, 27);
            this.txb_ProductOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductOrder.MaxLength = 4;
            this.txb_ProductOrder.Name = "txb_ProductOrder";
            this.txb_ProductOrder.Size = new System.Drawing.Size(104, 26);
            this.txb_ProductOrder.TabIndex = 0;
            this.txb_ProductOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_ProductOrder_KeyDown);
            // 
            // lb_Product_Unit_Order
            // 
            this.lb_Product_Unit_Order.AutoSize = true;
            this.lb_Product_Unit_Order.Location = new System.Drawing.Point(37, 31);
            this.lb_Product_Unit_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Product_Unit_Order.Name = "lb_Product_Unit_Order";
            this.lb_Product_Unit_Order.Size = new System.Drawing.Size(212, 18);
            this.lb_Product_Unit_Order.TabIndex = 13;
            this.lb_Product_Unit_Order.Text = "จำนวนคงเหลือต่ำสุดเพื่อแจ้งเตือน";
            // 
            // dTP_Expired
            // 
            this.dTP_Expired.Location = new System.Drawing.Point(153, 136);
            this.dTP_Expired.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_Expired.Name = "dTP_Expired";
            this.dTP_Expired.Size = new System.Drawing.Size(189, 26);
            this.dTP_Expired.TabIndex = 5;
            // 
            // lb_ProductExpired
            // 
            this.lb_ProductExpired.AutoSize = true;
            this.lb_ProductExpired.Location = new System.Drawing.Point(56, 140);
            this.lb_ProductExpired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductExpired.Name = "lb_ProductExpired";
            this.lb_ProductExpired.Size = new System.Drawing.Size(88, 18);
            this.lb_ProductExpired.TabIndex = 10;
            this.lb_ProductExpired.Text = "วันที่หมดอายุ";
            // 
            // dTP_Product
            // 
            this.dTP_Product.Location = new System.Drawing.Point(153, 100);
            this.dTP_Product.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_Product.Name = "dTP_Product";
            this.dTP_Product.Size = new System.Drawing.Size(189, 26);
            this.dTP_Product.TabIndex = 4;
            // 
            // lb_ProductProduct
            // 
            this.lb_ProductProduct.AutoSize = true;
            this.lb_ProductProduct.Location = new System.Drawing.Point(93, 104);
            this.lb_ProductProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductProduct.Name = "lb_ProductProduct";
            this.lb_ProductProduct.Size = new System.Drawing.Size(51, 18);
            this.lb_ProductProduct.TabIndex = 8;
            this.lb_ProductProduct.Text = "วันผลิต";
            // 
            // lb_Unit
            // 
            this.lb_Unit.AutoSize = true;
            this.lb_Unit.Location = new System.Drawing.Point(263, 29);
            this.lb_Unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Unit.Name = "lb_Unit";
            this.lb_Unit.Size = new System.Drawing.Size(72, 18);
            this.lb_Unit.TabIndex = 6;
            this.lb_Unit.Text = "หน่วยเรียก";
            // 
            // txb_ProductSale
            // 
            this.txb_ProductSale.Location = new System.Drawing.Point(153, 63);
            this.txb_ProductSale.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductSale.MaxLength = 11;
            this.txb_ProductSale.Name = "txb_ProductSale";
            this.txb_ProductSale.Size = new System.Drawing.Size(100, 26);
            this.txb_ProductSale.TabIndex = 1;
            this.txb_ProductSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_ProductSale_KeyDown);
            // 
            // lb_ProductSale
            // 
            this.lb_ProductSale.AutoSize = true;
            this.lb_ProductSale.Location = new System.Drawing.Point(22, 67);
            this.lb_ProductSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductSale.Name = "lb_ProductSale";
            this.lb_ProductSale.Size = new System.Drawing.Size(123, 18);
            this.lb_ProductSale.TabIndex = 4;
            this.lb_ProductSale.Text = "ราคาขายต่อหน่วย*";
            // 
            // txb_ProductPrice
            // 
            this.txb_ProductPrice.Location = new System.Drawing.Point(153, 25);
            this.txb_ProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductPrice.MaxLength = 11;
            this.txb_ProductPrice.Name = "txb_ProductPrice";
            this.txb_ProductPrice.Size = new System.Drawing.Size(100, 26);
            this.txb_ProductPrice.TabIndex = 0;
            this.txb_ProductPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_ProductPrice_KeyDown);
            // 
            // lb_ProductPrice
            // 
            this.lb_ProductPrice.AutoSize = true;
            this.lb_ProductPrice.Location = new System.Drawing.Point(62, 29);
            this.lb_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductPrice.Name = "lb_ProductPrice";
            this.lb_ProductPrice.Size = new System.Drawing.Size(83, 18);
            this.lb_ProductPrice.TabIndex = 2;
            this.lb_ProductPrice.Text = "ราคาต้นทุน*";
            // 
            // bt_AddProduct
            // 
            this.bt_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddProduct.Location = new System.Drawing.Point(116, 220);
            this.bt_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddProduct.Name = "bt_AddProduct";
            this.bt_AddProduct.Size = new System.Drawing.Size(70, 32);
            this.bt_AddProduct.TabIndex = 4;
            this.bt_AddProduct.Text = "เพิ่ม";
            this.bt_AddProduct.UseVisualStyleBackColor = false;
            this.bt_AddProduct.Click += new System.EventHandler(this.bt_AddProduct_Click);
            // 
            // bt_EditProduct
            // 
            this.bt_EditProduct.Enabled = false;
            this.bt_EditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditProduct.Location = new System.Drawing.Point(194, 220);
            this.bt_EditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditProduct.Name = "bt_EditProduct";
            this.bt_EditProduct.Size = new System.Drawing.Size(70, 32);
            this.bt_EditProduct.TabIndex = 5;
            this.bt_EditProduct.Text = "แก้ไข";
            this.bt_EditProduct.UseVisualStyleBackColor = false;
            this.bt_EditProduct.Click += new System.EventHandler(this.bt_EditProduct_Click);
            // 
            // lb_Detail
            // 
            this.lb_Detail.AutoSize = true;
            this.lb_Detail.Location = new System.Drawing.Point(22, 93);
            this.lb_Detail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Detail.Name = "lb_Detail";
            this.lb_Detail.Size = new System.Drawing.Size(66, 18);
            this.lb_Detail.TabIndex = 13;
            this.lb_Detail.Text = "คุณสมบัติ";
            // 
            // txb_ProductDetail
            // 
            this.txb_ProductDetail.Location = new System.Drawing.Point(96, 93);
            this.txb_ProductDetail.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ProductDetail.Multiline = true;
            this.txb_ProductDetail.Name = "txb_ProductDetail";
            this.txb_ProductDetail.Size = new System.Drawing.Size(305, 111);
            this.txb_ProductDetail.TabIndex = 2;
            // 
            // lb_ProductIDh
            // 
            this.lb_ProductIDh.AutoSize = true;
            this.lb_ProductIDh.Location = new System.Drawing.Point(346, 272);
            this.lb_ProductIDh.Name = "lb_ProductIDh";
            this.lb_ProductIDh.Size = new System.Drawing.Size(99, 18);
            this.lb_ProductIDh.TabIndex = 14;
            this.lb_ProductIDh.Text = "lb_ProductIDh";
            this.lb_ProductIDh.Visible = false;
            // 
            // bt_DelProduct
            // 
            this.bt_DelProduct.Enabled = false;
            this.bt_DelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_DelProduct.Location = new System.Drawing.Point(272, 220);
            this.bt_DelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DelProduct.Name = "bt_DelProduct";
            this.bt_DelProduct.Size = new System.Drawing.Size(70, 32);
            this.bt_DelProduct.TabIndex = 6;
            this.bt_DelProduct.Text = "ลบ";
            this.bt_DelProduct.UseVisualStyleBackColor = false;
            this.bt_DelProduct.Click += new System.EventHandler(this.bt_DelProduct_Click);
            // 
            // bt_reSetProduct
            // 
            this.bt_reSetProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reSetProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_reSetProduct.Location = new System.Drawing.Point(374, 26);
            this.bt_reSetProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_reSetProduct.Name = "bt_reSetProduct";
            this.bt_reSetProduct.Size = new System.Drawing.Size(70, 32);
            this.bt_reSetProduct.TabIndex = 10;
            this.bt_reSetProduct.Text = "เริ่มใหม่";
            this.bt_reSetProduct.UseVisualStyleBackColor = false;
            this.bt_reSetProduct.Click += new System.EventHandler(this.bt_reSetProduct_Click);
            // 
            // lb_SearchProduct
            // 
            this.lb_SearchProduct.AutoSize = true;
            this.lb_SearchProduct.Location = new System.Drawing.Point(161, 301);
            this.lb_SearchProduct.Name = "lb_SearchProduct";
            this.lb_SearchProduct.Size = new System.Drawing.Size(16, 18);
            this.lb_SearchProduct.TabIndex = 29;
            this.lb_SearchProduct.Text = "0";
            // 
            // lb_SearchProductB
            // 
            this.lb_SearchProductB.AutoSize = true;
            this.lb_SearchProductB.Location = new System.Drawing.Point(232, 301);
            this.lb_SearchProductB.Name = "lb_SearchProductB";
            this.lb_SearchProductB.Size = new System.Drawing.Size(52, 18);
            this.lb_SearchProductB.TabIndex = 28;
            this.lb_SearchProductB.Text = "รายการ";
            // 
            // lb_SearchProductA
            // 
            this.lb_SearchProductA.AutoSize = true;
            this.lb_SearchProductA.Location = new System.Drawing.Point(50, 301);
            this.lb_SearchProductA.Name = "lb_SearchProductA";
            this.lb_SearchProductA.Size = new System.Drawing.Size(74, 18);
            this.lb_SearchProductA.TabIndex = 27;
            this.lb_SearchProductA.Text = "พบทั้งหมด";
            // 
            // txb_SearchProduct
            // 
            this.txb_SearchProduct.Location = new System.Drawing.Point(550, 300);
            this.txb_SearchProduct.Name = "txb_SearchProduct";
            this.txb_SearchProduct.Size = new System.Drawing.Size(262, 26);
            this.txb_SearchProduct.TabIndex = 7;
            this.txb_SearchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_SearchProduct_KeyDown);
            // 
            // bt_SearchProduct
            // 
            this.bt_SearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SearchProduct.Location = new System.Drawing.Point(818, 297);
            this.bt_SearchProduct.Name = "bt_SearchProduct";
            this.bt_SearchProduct.Size = new System.Drawing.Size(101, 32);
            this.bt_SearchProduct.TabIndex = 8;
            this.bt_SearchProduct.Text = "ค้นหา";
            this.bt_SearchProduct.UseVisualStyleBackColor = false;
            this.bt_SearchProduct.Click += new System.EventHandler(this.bt_SearchProduct_Click);
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(269, 29);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(24, 18);
            this.lb_count.TabIndex = 30;
            this.lb_count.Text = "16";
            // 
            // ccProduct_ID
            // 
            this.ccProduct_ID.DataPropertyName = "Product_ID";
            this.ccProduct_ID.HeaderText = "รหัสสินค้า";
            this.ccProduct_ID.Name = "ccProduct_ID";
            this.ccProduct_ID.ReadOnly = true;
            this.ccProduct_ID.Width = 200;
            // 
            // ccProduct_Des
            // 
            this.ccProduct_Des.DataPropertyName = "Product_Des";
            this.ccProduct_Des.HeaderText = "ชื่อสินค้า";
            this.ccProduct_Des.Name = "ccProduct_Des";
            this.ccProduct_Des.ReadOnly = true;
            this.ccProduct_Des.Width = 200;
            // 
            // ccProduct_Detail
            // 
            this.ccProduct_Detail.DataPropertyName = "Product_Detail";
            this.ccProduct_Detail.HeaderText = "สรรพคุณ";
            this.ccProduct_Detail.Name = "ccProduct_Detail";
            this.ccProduct_Detail.ReadOnly = true;
            this.ccProduct_Detail.Visible = false;
            // 
            // ccProduct_Price
            // 
            this.ccProduct_Price.DataPropertyName = "Product_Price";
            this.ccProduct_Price.HeaderText = "ราคาต้นทุน";
            this.ccProduct_Price.Name = "ccProduct_Price";
            this.ccProduct_Price.ReadOnly = true;
            // 
            // ccProduct_Sale
            // 
            this.ccProduct_Sale.DataPropertyName = "Product_Sale";
            this.ccProduct_Sale.HeaderText = "ราคาขาย";
            this.ccProduct_Sale.Name = "ccProduct_Sale";
            this.ccProduct_Sale.ReadOnly = true;
            // 
            // ccProduct_Unit
            // 
            this.ccProduct_Unit.DataPropertyName = "Unit_Name";
            this.ccProduct_Unit.HeaderText = "หน่วยเรียก";
            this.ccProduct_Unit.Name = "ccProduct_Unit";
            this.ccProduct_Unit.ReadOnly = true;
            this.ccProduct_Unit.Visible = false;
            // 
            // ccProduct_Product
            // 
            this.ccProduct_Product.DataPropertyName = "Product_Product";
            dataGridViewCellStyle2.Format = "d";
            this.ccProduct_Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.ccProduct_Product.HeaderText = "วันที่ผลิต";
            this.ccProduct_Product.Name = "ccProduct_Product";
            this.ccProduct_Product.ReadOnly = true;
            // 
            // ccProduct_Expired
            // 
            this.ccProduct_Expired.DataPropertyName = "Product_Expired";
            dataGridViewCellStyle3.Format = "d";
            this.ccProduct_Expired.DefaultCellStyle = dataGridViewCellStyle3;
            this.ccProduct_Expired.HeaderText = "วันหมดอายุ";
            this.ccProduct_Expired.Name = "ccProduct_Expired";
            this.ccProduct_Expired.ReadOnly = true;
            // 
            // ccProduct_Unit_Amt
            // 
            this.ccProduct_Unit_Amt.DataPropertyName = "Product_Unit_Amt";
            this.ccProduct_Unit_Amt.HeaderText = "คงเหลือ";
            this.ccProduct_Unit_Amt.Name = "ccProduct_Unit_Amt";
            this.ccProduct_Unit_Amt.ReadOnly = true;
            // 
            // ccProduct_Unit_Order
            // 
            this.ccProduct_Unit_Order.DataPropertyName = "Product_Unit_Order";
            this.ccProduct_Unit_Order.HeaderText = "สั่งเมื่อเหลือ";
            this.ccProduct_Unit_Order.Name = "ccProduct_Unit_Order";
            this.ccProduct_Unit_Order.ReadOnly = true;
            this.ccProduct_Unit_Order.Visible = false;
            // 
            // ccUnit_ID
            // 
            this.ccUnit_ID.DataPropertyName = "Unit_ID";
            this.ccUnit_ID.HeaderText = "รหัสหน่วย";
            this.ccUnit_ID.Name = "ccUnit_ID";
            this.ccUnit_ID.ReadOnly = true;
            this.ccUnit_ID.Visible = false;
            // 
            // ccProduct_Stock
            // 
            this.ccProduct_Stock.DataPropertyName = "Product_Stock";
            this.ccProduct_Stock.HeaderText = "สต็อก";
            this.ccProduct_Stock.Name = "ccProduct_Stock";
            this.ccProduct_Stock.ReadOnly = true;
            this.ccProduct_Stock.Visible = false;
            // 
            // FrmSetting12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lb_SearchProduct);
            this.Controls.Add(this.lb_SearchProductB);
            this.Controls.Add(this.lb_SearchProductA);
            this.Controls.Add(this.txb_SearchProduct);
            this.Controls.Add(this.bt_SearchProduct);
            this.Controls.Add(this.bt_reSetProduct);
            this.Controls.Add(this.bt_DelProduct);
            this.Controls.Add(this.lb_ProductIDh);
            this.Controls.Add(this.dGV_Product);
            this.Controls.Add(this.txb_ProductDetail);
            this.Controls.Add(this.lb_Detail);
            this.Controls.Add(this.gBoxProductPrice);
            this.Controls.Add(this.bt_EditProduct);
            this.Controls.Add(this.lb_ProductID);
            this.Controls.Add(this.bt_AddProduct);
            this.Controls.Add(this.txb_ProductID);
            this.Controls.Add(this.lb_ProductName);
            this.Controls.Add(this.txb_ProductName);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSetting12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่า สินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.gBoxProductPrice.ResumeLayout(false);
            this.gBoxProductPrice.PerformLayout();
            this.gBoxProducttrack.ResumeLayout(false);
            this.gBoxProducttrack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Product;
        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.Label lb_ProductIDh;
        private System.Windows.Forms.TextBox txb_ProductDetail;
        private System.Windows.Forms.Label lb_Detail;
        private System.Windows.Forms.GroupBox gBoxProductPrice;
        private System.Windows.Forms.CheckBox CheckBox_Stock;
        private System.Windows.Forms.Button bt_Unit;
        private System.Windows.Forms.ComboBox cb_ProductUnit;
        private System.Windows.Forms.Button Bt_LoadPD;
        private System.Windows.Forms.TextBox txb_ProductAmt;
        private System.Windows.Forms.Label lb_Product_Unit_Amt;
        private System.Windows.Forms.GroupBox gBoxProducttrack;
        private System.Windows.Forms.TextBox txb_ProductOrder;
        private System.Windows.Forms.Label lb_Product_Unit_Order;
        private System.Windows.Forms.DateTimePicker dTP_Expired;
        private System.Windows.Forms.Label lb_ProductExpired;
        private System.Windows.Forms.DateTimePicker dTP_Product;
        private System.Windows.Forms.Label lb_ProductProduct;
        private System.Windows.Forms.Label lb_Unit;
        private System.Windows.Forms.TextBox txb_ProductSale;
        private System.Windows.Forms.Label lb_ProductSale;
        private System.Windows.Forms.TextBox txb_ProductPrice;
        private System.Windows.Forms.Label lb_ProductPrice;
        private System.Windows.Forms.Button bt_EditProduct;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.Button bt_AddProduct;
        private System.Windows.Forms.TextBox txb_ProductID;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.TextBox txb_ProductName;
        private System.Windows.Forms.Button bt_DelProduct;
        private System.Windows.Forms.Button bt_reSetProduct;
        private System.Windows.Forms.Label lb_SearchProduct;
        private System.Windows.Forms.Label lb_SearchProductB;
        private System.Windows.Forms.Label lb_SearchProductA;
        private System.Windows.Forms.TextBox txb_SearchProduct;
        private System.Windows.Forms.Button bt_SearchProduct;
        private System.Windows.Forms.Button bt_ProductRefresh;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Unit_Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Unit_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccUnit_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Stock;
    }
}