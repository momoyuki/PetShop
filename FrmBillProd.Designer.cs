namespace Petshop
{
    partial class FrmBillProd
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
            this.lb_BillID = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lb_Bill = new System.Windows.Forms.Label();
            this.Bt_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_BillID
            // 
            this.lb_BillID.AutoSize = true;
            this.lb_BillID.Location = new System.Drawing.Point(115, 20);
            this.lb_BillID.Name = "lb_BillID";
            this.lb_BillID.Size = new System.Drawing.Size(0, 18);
            this.lb_BillID.TabIndex = 8;
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
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // lb_Bill
            // 
            this.lb_Bill.AutoSize = true;
            this.lb_Bill.Location = new System.Drawing.Point(21, 20);
            this.lb_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bill.Name = "lb_Bill";
            this.lb_Bill.Size = new System.Drawing.Size(86, 18);
            this.lb_Bill.TabIndex = 6;
            this.lb_Bill.Text = "เลขที่ใบเสร็จ";
            // 
            // Bt_Report
            // 
            this.Bt_Report.Location = new System.Drawing.Point(263, 13);
            this.Bt_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Report.Name = "Bt_Report";
            this.Bt_Report.Size = new System.Drawing.Size(100, 32);
            this.Bt_Report.TabIndex = 5;
            this.Bt_Report.Text = "ค้นหา";
            this.Bt_Report.UseVisualStyleBackColor = true;
            this.Bt_Report.Click += new System.EventHandler(this.Bt_Report_Click);
            // 
            // FrmBillProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.lb_BillID);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lb_Bill);
            this.Controls.Add(this.Bt_Report);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBillProd";
            this.Text = "FrmBillProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_BillID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lb_Bill;
        private System.Windows.Forms.Button Bt_Report;
    }
}