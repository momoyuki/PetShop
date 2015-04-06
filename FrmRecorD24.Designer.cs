namespace Petshop
{
    partial class FrmRecorD24
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
            this.cb_Medi = new System.Windows.Forms.ComboBox();
            this.Lb_ListService = new System.Windows.Forms.Label();
            this.dGV_Medi = new System.Windows.Forms.DataGridView();
            this.ccHealRecord_ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMedi_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMedi_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMediSale_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMedi_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccMediRecord_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_CancelBuy = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.txb_ProductSaleNet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_Remark = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_Em = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTP_ProductSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_AddProductSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Medi)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Medi
            // 
            this.cb_Medi.FormattingEnabled = true;
            this.cb_Medi.Location = new System.Drawing.Point(125, 142);
            this.cb_Medi.Name = "cb_Medi";
            this.cb_Medi.Size = new System.Drawing.Size(408, 26);
            this.cb_Medi.TabIndex = 87;
            // 
            // Lb_ListService
            // 
            this.Lb_ListService.AutoSize = true;
            this.Lb_ListService.Location = new System.Drawing.Point(66, 147);
            this.Lb_ListService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_ListService.Name = "Lb_ListService";
            this.Lb_ListService.Size = new System.Drawing.Size(52, 18);
            this.Lb_ListService.TabIndex = 81;
            this.Lb_ListService.Text = "รายการ";
            // 
            // dGV_Medi
            // 
            this.dGV_Medi.AllowUserToAddRows = false;
            this.dGV_Medi.AllowUserToDeleteRows = false;
            this.dGV_Medi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Medi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccHealRecord_ID2,
            this.ccMedi_ID,
            this.ccMedi_Des,
            this.ccMediSale_Unit,
            this.ccMedi_Sale,
            this.ccMediRecord_Total});
            this.dGV_Medi.Location = new System.Drawing.Point(13, 184);
            this.dGV_Medi.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Medi.Name = "dGV_Medi";
            this.dGV_Medi.ReadOnly = true;
            this.dGV_Medi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Medi.Size = new System.Drawing.Size(982, 368);
            this.dGV_Medi.TabIndex = 80;
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
            // bt_CancelBuy
            // 
            this.bt_CancelBuy.Enabled = false;
            this.bt_CancelBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CancelBuy.Location = new System.Drawing.Point(803, 136);
            this.bt_CancelBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_CancelBuy.Name = "bt_CancelBuy";
            this.bt_CancelBuy.Size = new System.Drawing.Size(112, 37);
            this.bt_CancelBuy.TabIndex = 156;
            this.bt_CancelBuy.Text = "ลบรายการ";
            this.bt_CancelBuy.UseVisualStyleBackColor = true;
            // 
            // bt_Load
            // 
            this.bt_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Load.Location = new System.Drawing.Point(804, 4);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(111, 37);
            this.bt_Load.TabIndex = 154;
            this.bt_Load.Text = "LoadProduct";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Visible = false;
            // 
            // txb_ProductSaleNet
            // 
            this.txb_ProductSaleNet.Enabled = false;
            this.txb_ProductSaleNet.Location = new System.Drawing.Point(605, 143);
            this.txb_ProductSaleNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ProductSaleNet.Name = "txb_ProductSaleNet";
            this.txb_ProductSaleNet.Size = new System.Drawing.Size(66, 26);
            this.txb_ProductSaleNet.TabIndex = 153;
            this.txb_ProductSaleNet.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(561, 147);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 18);
            this.label16.TabIndex = 152;
            this.label16.Text = "สุทธิ";
            // 
            // txb_Remark
            // 
            this.txb_Remark.Location = new System.Drawing.Point(125, 76);
            this.txb_Remark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Remark.Multiline = true;
            this.txb_Remark.Name = "txb_Remark";
            this.txb_Remark.Size = new System.Drawing.Size(408, 58);
            this.txb_Remark.TabIndex = 149;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 148;
            this.label13.Text = "หมายเหตุ";
            // 
            // cb_Em
            // 
            this.cb_Em.FormattingEnabled = true;
            this.cb_Em.Location = new System.Drawing.Point(125, 40);
            this.cb_Em.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Em.Name = "cb_Em";
            this.cb_Em.Size = new System.Drawing.Size(238, 26);
            this.cb_Em.TabIndex = 146;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 145;
            this.label3.Text = "ผู้ทำการขาย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 144;
            this.label2.Text = "วันที่ทำการขาย";
            // 
            // dTP_ProductSaleDate
            // 
            this.dTP_ProductSaleDate.Location = new System.Drawing.Point(481, 7);
            this.dTP_ProductSaleDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTP_ProductSaleDate.Name = "dTP_ProductSaleDate";
            this.dTP_ProductSaleDate.Size = new System.Drawing.Size(211, 26);
            this.dTP_ProductSaleDate.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 147;
            this.label1.Text = "เลขที่ทำการขาย";
            // 
            // bt_AddProductSale
            // 
            this.bt_AddProductSale.Enabled = false;
            this.bt_AddProductSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddProductSale.Location = new System.Drawing.Point(683, 136);
            this.bt_AddProductSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_AddProductSale.Name = "bt_AddProductSale";
            this.bt_AddProductSale.Size = new System.Drawing.Size(112, 37);
            this.bt_AddProductSale.TabIndex = 142;
            this.bt_AddProductSale.Text = "เพิ่มรายการ";
            this.bt_AddProductSale.UseVisualStyleBackColor = true;
            // 
            // FrmincomeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.bt_CancelBuy);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.txb_ProductSaleNet);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txb_Remark);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_Em);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTP_ProductSaleDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_AddProductSale);
            this.Controls.Add(this.cb_Medi);
            this.Controls.Add(this.Lb_ListService);
            this.Controls.Add(this.dGV_Medi);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmincomeDetail";
            this.Text = "FrmincomeDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Medi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Medi;
        private System.Windows.Forms.Label Lb_ListService;
        private System.Windows.Forms.DataGridView dGV_Medi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHealRecord_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMedi_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMedi_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMediSale_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMedi_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccMediRecord_Total;
        private System.Windows.Forms.Button bt_CancelBuy;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox txb_ProductSaleNet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txb_Remark;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_Em;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP_ProductSaleDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_AddProductSale;
    }
}