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
            this.cb_outlay = new System.Windows.Forms.ComboBox();
            this.Lb_ListService = new System.Windows.Forms.Label();
            this.dGV_outlay = new System.Windows.Forms.DataGridView();
            this.bt_DeloutlayDetail = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.txb_outlayAmt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_outlayRemark = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_Em = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.dTP_outlayDate = new System.Windows.Forms.DateTimePicker();
            this.lb_outlayDetail = new System.Windows.Forms.Label();
            this.bt_AddoutlayDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_outlay)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_outlay
            // 
            this.cb_outlay.FormattingEnabled = true;
            this.cb_outlay.Location = new System.Drawing.Point(125, 142);
            this.cb_outlay.Name = "cb_outlay";
            this.cb_outlay.Size = new System.Drawing.Size(408, 26);
            this.cb_outlay.TabIndex = 87;
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
            // dGV_outlay
            // 
            this.dGV_outlay.AllowUserToAddRows = false;
            this.dGV_outlay.AllowUserToDeleteRows = false;
            this.dGV_outlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_outlay.Location = new System.Drawing.Point(13, 184);
            this.dGV_outlay.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_outlay.Name = "dGV_outlay";
            this.dGV_outlay.ReadOnly = true;
            this.dGV_outlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_outlay.Size = new System.Drawing.Size(982, 368);
            this.dGV_outlay.TabIndex = 80;
            // 
            // bt_DeloutlayDetail
            // 
            this.bt_DeloutlayDetail.Enabled = false;
            this.bt_DeloutlayDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DeloutlayDetail.Location = new System.Drawing.Point(803, 136);
            this.bt_DeloutlayDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_DeloutlayDetail.Name = "bt_DeloutlayDetail";
            this.bt_DeloutlayDetail.Size = new System.Drawing.Size(112, 37);
            this.bt_DeloutlayDetail.TabIndex = 156;
            this.bt_DeloutlayDetail.Text = "ลบรายการ";
            this.bt_DeloutlayDetail.UseVisualStyleBackColor = true;
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
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // txb_outlayAmt
            // 
            this.txb_outlayAmt.Enabled = false;
            this.txb_outlayAmt.Location = new System.Drawing.Point(605, 143);
            this.txb_outlayAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_outlayAmt.Name = "txb_outlayAmt";
            this.txb_outlayAmt.Size = new System.Drawing.Size(66, 26);
            this.txb_outlayAmt.TabIndex = 153;
            this.txb_outlayAmt.Text = "0.00";
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
            // txb_outlayRemark
            // 
            this.txb_outlayRemark.Location = new System.Drawing.Point(125, 76);
            this.txb_outlayRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_outlayRemark.Multiline = true;
            this.txb_outlayRemark.Name = "txb_outlayRemark";
            this.txb_outlayRemark.Size = new System.Drawing.Size(408, 58);
            this.txb_outlayRemark.TabIndex = 149;
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
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Location = new System.Drawing.Point(373, 13);
            this.lb_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(100, 18);
            this.lb_Date.TabIndex = 144;
            this.lb_Date.Text = "วันที่ทำการขาย";
            // 
            // dTP_outlayDate
            // 
            this.dTP_outlayDate.Location = new System.Drawing.Point(481, 7);
            this.dTP_outlayDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTP_outlayDate.Name = "dTP_outlayDate";
            this.dTP_outlayDate.Size = new System.Drawing.Size(211, 26);
            this.dTP_outlayDate.TabIndex = 143;
            // 
            // lb_outlayDetail
            // 
            this.lb_outlayDetail.AutoSize = true;
            this.lb_outlayDetail.Location = new System.Drawing.Point(13, 13);
            this.lb_outlayDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_outlayDetail.Name = "lb_outlayDetail";
            this.lb_outlayDetail.Size = new System.Drawing.Size(107, 18);
            this.lb_outlayDetail.TabIndex = 147;
            this.lb_outlayDetail.Text = "เลขที่ทำการขาย";
            // 
            // bt_AddoutlayDetail
            // 
            this.bt_AddoutlayDetail.Enabled = false;
            this.bt_AddoutlayDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddoutlayDetail.Location = new System.Drawing.Point(683, 136);
            this.bt_AddoutlayDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_AddoutlayDetail.Name = "bt_AddoutlayDetail";
            this.bt_AddoutlayDetail.Size = new System.Drawing.Size(112, 37);
            this.bt_AddoutlayDetail.TabIndex = 142;
            this.bt_AddoutlayDetail.Text = "เพิ่มรายการ";
            this.bt_AddoutlayDetail.UseVisualStyleBackColor = true;
            // 
            // FrmRecorD24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.bt_DeloutlayDetail);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.txb_outlayAmt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txb_outlayRemark);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_Em);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.dTP_outlayDate);
            this.Controls.Add(this.lb_outlayDetail);
            this.Controls.Add(this.bt_AddoutlayDetail);
            this.Controls.Add(this.cb_outlay);
            this.Controls.Add(this.Lb_ListService);
            this.Controls.Add(this.dGV_outlay);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecorD24";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmincomeDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dGV_outlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_outlay;
        private System.Windows.Forms.Label Lb_ListService;
        private System.Windows.Forms.DataGridView dGV_outlay;
        private System.Windows.Forms.Button bt_DeloutlayDetail;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox txb_outlayAmt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txb_outlayRemark;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_Em;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.DateTimePicker dTP_outlayDate;
        private System.Windows.Forms.Label lb_outlayDetail;
        private System.Windows.Forms.Button bt_AddoutlayDetail;
    }
}