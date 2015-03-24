namespace Petshop
{
    partial class FrmMM24
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
            this.nUD_ProductUnit = new System.Windows.Forms.NumericUpDown();
            this.lbyear = new System.Windows.Forms.Label();
            this.bt_CancelBuy = new System.Windows.Forms.Button();
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.txb_ProductSaleNet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_ProductSaleTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_Remark = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_Em = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccProduct_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProduct_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProductSale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccProductSale_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTP_ProductSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ccProductSale_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_AddProductSale = new System.Windows.Forms.Button();
            this.txb_ProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dGV_Product = new System.Windows.Forms.DataGridView();
            this.txb_ProductSaleDC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.lb_ProductSaleID = new System.Windows.Forms.Label();
            this.bt_RecordBuy = new System.Windows.Forms.Button();
            this.lb_ProductUnit = new System.Windows.Forms.Label();
            this.lb_PriceAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_ProductUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD_ProductUnit
            // 
            this.nUD_ProductUnit.Location = new System.Drawing.Point(561, 160);
            this.nUD_ProductUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nUD_ProductUnit.Name = "nUD_ProductUnit";
            this.nUD_ProductUnit.Size = new System.Drawing.Size(72, 26);
            this.nUD_ProductUnit.TabIndex = 131;
            this.nUD_ProductUnit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbyear
            // 
            this.lbyear.AutoSize = true;
            this.lbyear.Location = new System.Drawing.Point(681, 18);
            this.lbyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyear.Name = "lbyear";
            this.lbyear.Size = new System.Drawing.Size(16, 18);
            this.lbyear.TabIndex = 130;
            this.lbyear.Text = "y";
            this.lbyear.Visible = false;
            // 
            // bt_CancelBuy
            // 
            this.bt_CancelBuy.Location = new System.Drawing.Point(883, 155);
            this.bt_CancelBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_CancelBuy.Name = "bt_CancelBuy";
            this.bt_CancelBuy.Size = new System.Drawing.Size(112, 37);
            this.bt_CancelBuy.TabIndex = 129;
            this.bt_CancelBuy.Text = "ลบ";
            this.bt_CancelBuy.UseVisualStyleBackColor = true;
            this.bt_CancelBuy.Click += new System.EventHandler(this.bt_CancelBuy_Click);
            // 
            // bt_Print
            // 
            this.bt_Print.Location = new System.Drawing.Point(883, 50);
            this.bt_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(112, 92);
            this.bt_Print.TabIndex = 127;
            this.bt_Print.Text = "พิมพ์ใบเสร็จ";
            this.bt_Print.UseVisualStyleBackColor = true;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.Location = new System.Drawing.Point(883, 8);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(111, 37);
            this.bt_Load.TabIndex = 125;
            this.bt_Load.Text = "LoadProduct";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // txb_ProductSaleNet
            // 
            this.txb_ProductSaleNet.Enabled = false;
            this.txb_ProductSaleNet.Location = new System.Drawing.Point(567, 124);
            this.txb_ProductSaleNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ProductSaleNet.Name = "txb_ProductSaleNet";
            this.txb_ProductSaleNet.Size = new System.Drawing.Size(66, 26);
            this.txb_ProductSaleNet.TabIndex = 122;
            this.txb_ProductSaleNet.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(523, 128);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 18);
            this.label16.TabIndex = 121;
            this.label16.Text = "สุทธิ";
            // 
            // txb_ProductSaleTotal
            // 
            this.txb_ProductSaleTotal.Enabled = false;
            this.txb_ProductSaleTotal.Location = new System.Drawing.Point(316, 124);
            this.txb_ProductSaleTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ProductSaleTotal.Name = "txb_ProductSaleTotal";
            this.txb_ProductSaleTotal.Size = new System.Drawing.Size(66, 26);
            this.txb_ProductSaleTotal.TabIndex = 120;
            this.txb_ProductSaleTotal.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 119;
            this.label14.Text = "จำนวนรวม";
            // 
            // txb_Remark
            // 
            this.txb_Remark.Location = new System.Drawing.Point(159, 86);
            this.txb_Remark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Remark.Name = "txb_Remark";
            this.txb_Remark.Size = new System.Drawing.Size(408, 26);
            this.txb_Remark.TabIndex = 118;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 117;
            this.label13.Text = "หมายเหตุ";
            // 
            // cb_Em
            // 
            this.cb_Em.FormattingEnabled = true;
            this.cb_Em.Location = new System.Drawing.Point(159, 50);
            this.cb_Em.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Em.Name = "cb_Em";
            this.cb_Em.Size = new System.Drawing.Size(238, 26);
            this.cb_Em.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 114;
            this.label3.Text = "ผู้ทำการขาย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 113;
            this.label2.Text = "วันที่ทำการขาย";
            // 
            // ccProduct_ID
            // 
            this.ccProduct_ID.DataPropertyName = "Product_ID";
            this.ccProduct_ID.HeaderText = "รหัสสินค้า";
            this.ccProduct_ID.Name = "ccProduct_ID";
            this.ccProduct_ID.ReadOnly = true;
            this.ccProduct_ID.Width = 120;
            // 
            // ccProduct_Des
            // 
            this.ccProduct_Des.DataPropertyName = "Product_Des";
            this.ccProduct_Des.HeaderText = "รายการสินค้า";
            this.ccProduct_Des.Name = "ccProduct_Des";
            this.ccProduct_Des.ReadOnly = true;
            this.ccProduct_Des.Width = 120;
            // 
            // ccProduct_Sale
            // 
            this.ccProduct_Sale.DataPropertyName = "Product_Sale";
            this.ccProduct_Sale.HeaderText = "ราคาขาย";
            this.ccProduct_Sale.Name = "ccProduct_Sale";
            this.ccProduct_Sale.ReadOnly = true;
            // 
            // ccProductSale_ID
            // 
            this.ccProductSale_ID.DataPropertyName = "ProductSale_ID";
            this.ccProductSale_ID.HeaderText = "เลขที่ทำการขาย";
            this.ccProductSale_ID.Name = "ccProductSale_ID";
            this.ccProductSale_ID.ReadOnly = true;
            this.ccProductSale_ID.Visible = false;
            // 
            // ccProductSale_Total
            // 
            this.ccProductSale_Total.DataPropertyName = "ProductSale_Total";
            this.ccProductSale_Total.HeaderText = "ราคารวม";
            this.ccProductSale_Total.Name = "ccProductSale_Total";
            this.ccProductSale_Total.ReadOnly = true;
            // 
            // dTP_ProductSaleDate
            // 
            this.dTP_ProductSaleDate.Location = new System.Drawing.Point(449, 14);
            this.dTP_ProductSaleDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTP_ProductSaleDate.Name = "dTP_ProductSaleDate";
            this.dTP_ProductSaleDate.Size = new System.Drawing.Size(211, 26);
            this.dTP_ProductSaleDate.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 116;
            this.label1.Text = "เลขที่ทำการขาย";
            // 
            // ccProductSale_Unit
            // 
            this.ccProductSale_Unit.DataPropertyName = "ProductSale_Unit";
            this.ccProductSale_Unit.HeaderText = "จำนวน";
            this.ccProductSale_Unit.Name = "ccProductSale_Unit";
            this.ccProductSale_Unit.ReadOnly = true;
            // 
            // bt_AddProductSale
            // 
            this.bt_AddProductSale.Location = new System.Drawing.Point(763, 155);
            this.bt_AddProductSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_AddProductSale.Name = "bt_AddProductSale";
            this.bt_AddProductSale.Size = new System.Drawing.Size(112, 37);
            this.bt_AddProductSale.TabIndex = 110;
            this.bt_AddProductSale.Text = "ซื้อ";
            this.bt_AddProductSale.UseVisualStyleBackColor = true;
            this.bt_AddProductSale.Click += new System.EventHandler(this.bt_AddProductSale_Click);
            // 
            // txb_ProductID
            // 
            this.txb_ProductID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txb_ProductID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txb_ProductID.Location = new System.Drawing.Point(161, 160);
            this.txb_ProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ProductID.Name = "txb_ProductID";
            this.txb_ProductID.Size = new System.Drawing.Size(325, 26);
            this.txb_ProductID.TabIndex = 107;
            this.txb_ProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Buy_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 106;
            this.label4.Text = "สินค้า";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(495, 164);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 18);
            this.label15.TabIndex = 108;
            this.label15.Text = "จำนวน";
            // 
            // dGV_Product
            // 
            this.dGV_Product.AllowUserToAddRows = false;
            this.dGV_Product.AllowUserToDeleteRows = false;
            this.dGV_Product.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccProductSale_ID,
            this.ccProduct_ID,
            this.ccProduct_Des,
            this.ccProduct_Sale,
            this.ccProductSale_Unit,
            this.ccProductSale_Total});
            this.dGV_Product.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dGV_Product.Location = new System.Drawing.Point(13, 202);
            this.dGV_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGV_Product.MultiSelect = false;
            this.dGV_Product.Name = "dGV_Product";
            this.dGV_Product.ReadOnly = true;
            this.dGV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Product.Size = new System.Drawing.Size(982, 456);
            this.dGV_Product.TabIndex = 109;
            this.dGV_Product.SelectionChanged += new System.EventHandler(this.dGV_Product_SelectionChanged);
            // 
            // txb_ProductSaleDC
            // 
            this.txb_ProductSaleDC.Location = new System.Drawing.Point(449, 124);
            this.txb_ProductSaleDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ProductSaleDC.Name = "txb_ProductSaleDC";
            this.txb_ProductSaleDC.Size = new System.Drawing.Size(66, 26);
            this.txb_ProductSaleDC.TabIndex = 133;
            this.txb_ProductSaleDC.Text = "0.00";
            this.txb_ProductSaleDC.TextChanged += new System.EventHandler(this.txb_ProductSaleDC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 132;
            this.label6.Text = "ส่วนลด";
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(640, 127);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(91, 18);
            this.lb_ProductID.TabIndex = 134;
            this.lb_ProductID.Text = "lb_ProductID";
            // 
            // lb_ProductSaleID
            // 
            this.lb_ProductSaleID.AutoSize = true;
            this.lb_ProductSaleID.Location = new System.Drawing.Point(161, 18);
            this.lb_ProductSaleID.Name = "lb_ProductSaleID";
            this.lb_ProductSaleID.Size = new System.Drawing.Size(0, 18);
            this.lb_ProductSaleID.TabIndex = 135;
            // 
            // bt_RecordBuy
            // 
            this.bt_RecordBuy.Location = new System.Drawing.Point(763, 50);
            this.bt_RecordBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_RecordBuy.Name = "bt_RecordBuy";
            this.bt_RecordBuy.Size = new System.Drawing.Size(112, 92);
            this.bt_RecordBuy.TabIndex = 136;
            this.bt_RecordBuy.Text = "บันทึก";
            this.bt_RecordBuy.UseVisualStyleBackColor = true;
            // 
            // lb_ProductUnit
            // 
            this.lb_ProductUnit.AutoSize = true;
            this.lb_ProductUnit.Location = new System.Drawing.Point(640, 164);
            this.lb_ProductUnit.Name = "lb_ProductUnit";
            this.lb_ProductUnit.Size = new System.Drawing.Size(100, 18);
            this.lb_ProductUnit.TabIndex = 137;
            this.lb_ProductUnit.Text = "lb_ProductUnit";
            // 
            // lb_PriceAmt
            // 
            this.lb_PriceAmt.AutoSize = true;
            this.lb_PriceAmt.Location = new System.Drawing.Point(148, 128);
            this.lb_PriceAmt.Name = "lb_PriceAmt";
            this.lb_PriceAmt.Size = new System.Drawing.Size(83, 18);
            this.lb_PriceAmt.TabIndex = 138;
            this.lb_PriceAmt.Text = "lb_PriceAmt";
            // 
            // FrmMM24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.lb_PriceAmt);
            this.Controls.Add(this.lb_ProductUnit);
            this.Controls.Add(this.bt_RecordBuy);
            this.Controls.Add(this.lb_ProductSaleID);
            this.Controls.Add(this.lb_ProductID);
            this.Controls.Add(this.txb_ProductSaleDC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nUD_ProductUnit);
            this.Controls.Add(this.lbyear);
            this.Controls.Add(this.bt_CancelBuy);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.txb_ProductSaleNet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txb_ProductSaleTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txb_Remark);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_Em);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTP_ProductSaleDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_AddProductSale);
            this.Controls.Add(this.txb_ProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dGV_Product);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMM24";
            this.Text = "บันทึกประจำวัน ขายสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM22_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_ProductUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD_ProductUnit;
        private System.Windows.Forms.Label lbyear;
        private System.Windows.Forms.Button bt_CancelBuy;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox txb_ProductSaleNet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txb_ProductSaleTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb_Remark;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_Em;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProduct_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProductSale_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProductSale_Total;
        private System.Windows.Forms.DateTimePicker dTP_ProductSaleDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccProductSale_Unit;
        private System.Windows.Forms.Button bt_AddProductSale;
        private System.Windows.Forms.TextBox txb_ProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dGV_Product;
        private System.Windows.Forms.TextBox txb_ProductSaleDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.Label lb_ProductSaleID;
        private System.Windows.Forms.Button bt_RecordBuy;
        private System.Windows.Forms.Label lb_ProductUnit;
        private System.Windows.Forms.Label lb_PriceAmt;
    }
}