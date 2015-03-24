namespace Petshop
{
    partial class FrmMM32
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb_ReferID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.txb_BillDC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_BillNet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_BillTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_Em = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTP_ProductSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Product = new System.Windows.Forms.DataGridView();
            this.ccCheckBoxProduct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ccProductSale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProductSale_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProductSale_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lb_BillID = new System.Windows.Forms.Label();
            this.Lb_CoBill = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.CheckBoxProduct = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 155;
            this.button1.Text = "ค้นหา";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txb_ReferID
            // 
            this.txb_ReferID.Location = new System.Drawing.Point(107, 34);
            this.txb_ReferID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ReferID.MaxLength = 9;
            this.txb_ReferID.Name = "txb_ReferID";
            this.txb_ReferID.Size = new System.Drawing.Size(132, 26);
            this.txb_ReferID.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 154;
            this.label4.Text = "เลขที่อ้างอิง";
            // 
            // bt_Print
            // 
            this.bt_Print.Location = new System.Drawing.Point(895, 47);
            this.bt_Print.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(100, 79);
            this.bt_Print.TabIndex = 151;
            this.bt_Print.Text = "พิมพ์ใบเสร็จ";
            this.bt_Print.UseVisualStyleBackColor = true;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.Location = new System.Drawing.Point(895, 7);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(100, 32);
            this.bt_Load.TabIndex = 149;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // txb_BillDC
            // 
            this.txb_BillDC.Location = new System.Drawing.Point(397, 118);
            this.txb_BillDC.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillDC.Name = "txb_BillDC";
            this.txb_BillDC.Size = new System.Drawing.Size(59, 26);
            this.txb_BillDC.TabIndex = 148;
            this.txb_BillDC.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 147;
            this.label5.Text = "ส่วนลด";
            // 
            // txb_BillNet
            // 
            this.txb_BillNet.Location = new System.Drawing.Point(508, 118);
            this.txb_BillNet.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillNet.Name = "txb_BillNet";
            this.txb_BillNet.Size = new System.Drawing.Size(132, 26);
            this.txb_BillNet.TabIndex = 146;
            this.txb_BillNet.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(465, 122);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 18);
            this.label16.TabIndex = 145;
            this.label16.Text = "สุทธิ";
            // 
            // txb_BillTotal
            // 
            this.txb_BillTotal.Location = new System.Drawing.Point(200, 118);
            this.txb_BillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BillTotal.Name = "txb_BillTotal";
            this.txb_BillTotal.Size = new System.Drawing.Size(132, 26);
            this.txb_BillTotal.TabIndex = 144;
            this.txb_BillTotal.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 143;
            this.label14.Text = "จำนวนรวม";
            // 
            // cb_Em
            // 
            this.cb_Em.FormattingEnabled = true;
            this.cb_Em.Location = new System.Drawing.Point(107, 68);
            this.cb_Em.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Em.Name = "cb_Em";
            this.cb_Em.Size = new System.Drawing.Size(244, 26);
            this.cb_Em.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 140;
            this.label3.Text = "ออกโดย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 139;
            this.label2.Text = "ออกเมื่อวันที่";
            // 
            // dTP_ProductSaleDate
            // 
            this.dTP_ProductSaleDate.Location = new System.Drawing.Point(452, 29);
            this.dTP_ProductSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.dTP_ProductSaleDate.Name = "dTP_ProductSaleDate";
            this.dTP_ProductSaleDate.Size = new System.Drawing.Size(188, 26);
            this.dTP_ProductSaleDate.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 142;
            this.label1.Text = "เลขที่ใบเสร็จ";
            // 
            // dGV_Product
            // 
            this.dGV_Product.AllowUserToAddRows = false;
            this.dGV_Product.AllowUserToDeleteRows = false;
            this.dGV_Product.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccCheckBoxProduct,
            this.ccProductSale_ID,
            this.ccProduct_ID,
            this.ccProduct_Des,
            this.ccProduct_Sale,
            this.ccProductSale_Unit,
            this.ccProductSale_Total});
            this.dGV_Product.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dGV_Product.Location = new System.Drawing.Point(13, 173);
            this.dGV_Product.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Product.MultiSelect = false;
            this.dGV_Product.Name = "dGV_Product";
            this.dGV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Product.Size = new System.Drawing.Size(982, 486);
            this.dGV_Product.TabIndex = 136;
            // 
            // ccCheckBoxProduct
            // 
            this.ccCheckBoxProduct.FillWeight = 30F;
            this.ccCheckBoxProduct.HeaderText = "";
            this.ccCheckBoxProduct.Name = "ccCheckBoxProduct";
            this.ccCheckBoxProduct.Width = 30;
            // 
            // ccProductSale_ID
            // 
            this.ccProductSale_ID.DataPropertyName = "ProductSale_ID";
            this.ccProductSale_ID.HeaderText = "เลขที่ทำการขาย";
            this.ccProductSale_ID.Name = "ccProductSale_ID";
            this.ccProductSale_ID.ReadOnly = true;
            this.ccProductSale_ID.Visible = false;
            // 
            // ccProduct_ID
            // 
            this.ccProduct_ID.DataPropertyName = "Product_ID";
            this.ccProduct_ID.FillWeight = 150F;
            this.ccProduct_ID.HeaderText = "รหัสสินค้า";
            this.ccProduct_ID.Name = "ccProduct_ID";
            this.ccProduct_ID.ReadOnly = true;
            this.ccProduct_ID.Width = 150;
            // 
            // ccProduct_Des
            // 
            this.ccProduct_Des.DataPropertyName = "Product_Des";
            this.ccProduct_Des.FillWeight = 200F;
            this.ccProduct_Des.HeaderText = "รายการสินค้า";
            this.ccProduct_Des.Name = "ccProduct_Des";
            this.ccProduct_Des.ReadOnly = true;
            this.ccProduct_Des.Width = 200;
            // 
            // ccProduct_Sale
            // 
            this.ccProduct_Sale.DataPropertyName = "Product_Sale";
            this.ccProduct_Sale.HeaderText = "ราคาขาย";
            this.ccProduct_Sale.Name = "ccProduct_Sale";
            this.ccProduct_Sale.ReadOnly = true;
            // 
            // ccProductSale_Unit
            // 
            this.ccProductSale_Unit.DataPropertyName = "ProductSale_Unit";
            this.ccProductSale_Unit.HeaderText = "จำนวน";
            this.ccProductSale_Unit.Name = "ccProductSale_Unit";
            this.ccProductSale_Unit.ReadOnly = true;
            // 
            // ccProductSale_Total
            // 
            this.ccProductSale_Total.DataPropertyName = "ProductSale_Total";
            this.ccProductSale_Total.HeaderText = "ราคารวม";
            this.ccProductSale_Total.Name = "ccProductSale_Total";
            this.ccProductSale_Total.ReadOnly = true;
            // 
            // Lb_BillID
            // 
            this.Lb_BillID.AutoSize = true;
            this.Lb_BillID.Location = new System.Drawing.Point(107, 9);
            this.Lb_BillID.Name = "Lb_BillID";
            this.Lb_BillID.Size = new System.Drawing.Size(0, 18);
            this.Lb_BillID.TabIndex = 156;
            // 
            // Lb_CoBill
            // 
            this.Lb_CoBill.AutoSize = true;
            this.Lb_CoBill.Location = new System.Drawing.Point(379, 7);
            this.Lb_CoBill.Name = "Lb_CoBill";
            this.Lb_CoBill.Size = new System.Drawing.Size(63, 18);
            this.Lb_CoBill.TabIndex = 157;
            this.Lb_CoBill.Text = "Lb_CoBill";
            this.Lb_CoBill.Visible = false;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(448, 7);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(49, 18);
            this.lbYear.TabIndex = 158;
            this.lbYear.Text = "lbYear";
            this.lbYear.Visible = false;
            // 
            // CheckBoxProduct
            // 
            this.CheckBoxProduct.AutoSize = true;
            this.CheckBoxProduct.Location = new System.Drawing.Point(78, 180);
            this.CheckBoxProduct.Name = "CheckBoxProduct";
            this.CheckBoxProduct.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxProduct.TabIndex = 159;
            this.CheckBoxProduct.UseVisualStyleBackColor = true;
            this.CheckBoxProduct.CheckedChanged += new System.EventHandler(this.CheckBoxProduct_CheckedChanged);
            // 
            // FrmMM32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.CheckBoxProduct);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.Lb_CoBill);
            this.Controls.Add(this.Lb_BillID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_ReferID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.txb_BillDC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_BillNet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txb_BillTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_Em);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTP_ProductSaleDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Product);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMM32";
            this.Text = "ใบเสร็จ ขายสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox txb_BillDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_BillNet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txb_BillTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_Em;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP_ProductSaleDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Product;
        private System.Windows.Forms.Label Lb_BillID;
        private System.Windows.Forms.Label Lb_CoBill;
        private System.Windows.Forms.Label lbYear;
        public System.Windows.Forms.TextBox txb_ReferID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ccCheckBoxProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProductSale_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProductSale_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProductSale_Total;
        private System.Windows.Forms.CheckBox CheckBoxProduct;
    }
}