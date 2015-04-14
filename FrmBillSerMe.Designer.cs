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
            this.Bt_Report = new System.Windows.Forms.Button();
            this.lb_Bill = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lb_BillID = new System.Windows.Forms.Label();
            this.CheckBox_Print = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Bt_Report
            // 
            this.Bt_Report.Location = new System.Drawing.Point(264, 13);
            this.Bt_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Report.Name = "Bt_Report";
            this.Bt_Report.Size = new System.Drawing.Size(100, 32);
            this.Bt_Report.TabIndex = 0;
            this.Bt_Report.Text = "ค้นหา";
            this.Bt_Report.UseVisualStyleBackColor = true;
            this.Bt_Report.Click += new System.EventHandler(this.Bt_Report_Click);
            // 
            // lb_Bill
            // 
            this.lb_Bill.AutoSize = true;
            this.lb_Bill.Location = new System.Drawing.Point(22, 20);
            this.lb_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bill.Name = "lb_Bill";
            this.lb_Bill.Size = new System.Drawing.Size(86, 18);
            this.lb_Bill.TabIndex = 2;
            this.lb_Bill.Text = "เลขที่ใบเสร็จ";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(13, 50);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(982, 609);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // lb_BillID
            // 
            this.lb_BillID.AutoSize = true;
            this.lb_BillID.Location = new System.Drawing.Point(116, 20);
            this.lb_BillID.Name = "lb_BillID";
            this.lb_BillID.Size = new System.Drawing.Size(0, 18);
            this.lb_BillID.TabIndex = 4;
            // 
            // CheckBox_Print
            // 
            this.CheckBox_Print.AutoSize = true;
            this.CheckBox_Print.Location = new System.Drawing.Point(371, 19);
            this.CheckBox_Print.Name = "CheckBox_Print";
            this.CheckBox_Print.Size = new System.Drawing.Size(64, 22);
            this.CheckBox_Print.TabIndex = 13;
            this.CheckBox_Print.Text = "สำเนา";
            this.CheckBox_Print.UseVisualStyleBackColor = true;
            // 
            // FrmBillSerMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.CheckBox_Print);
            this.Controls.Add(this.lb_BillID);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lb_Bill);
            this.Controls.Add(this.Bt_Report);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBillSerMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตัวอย่างก่อนพิมพ์ ใบเสร็จ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBillreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Report;
        private System.Windows.Forms.Label lb_Bill;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public System.Windows.Forms.Label lb_BillID;
        private System.Windows.Forms.CheckBox CheckBox_Print;
    }
}