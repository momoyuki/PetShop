namespace Petshop
{
    partial class FrmPreBillDate
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
            this.lb_PetID = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lb_HealDate = new System.Windows.Forms.Label();
            this.Bt_Report = new System.Windows.Forms.Button();
            this.txb_UnitList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_PetID
            // 
            this.lb_PetID.AutoSize = true;
            this.lb_PetID.Location = new System.Drawing.Point(123, 20);
            this.lb_PetID.Name = "lb_PetID";
            this.lb_PetID.Size = new System.Drawing.Size(0, 18);
            this.lb_PetID.TabIndex = 8;
            this.lb_PetID.TextChanged += new System.EventHandler(this.lb_PetID_TextChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(13, 50);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(982, 609);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // lb_HealDate
            // 
            this.lb_HealDate.AutoSize = true;
            this.lb_HealDate.Location = new System.Drawing.Point(21, 20);
            this.lb_HealDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HealDate.Name = "lb_HealDate";
            this.lb_HealDate.Size = new System.Drawing.Size(58, 18);
            this.lb_HealDate.TabIndex = 6;
            this.lb_HealDate.Text = "รหัสสัตว์";
            // 
            // Bt_Report
            // 
            this.Bt_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Report.Location = new System.Drawing.Point(392, 13);
            this.Bt_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Report.Name = "Bt_Report";
            this.Bt_Report.Size = new System.Drawing.Size(100, 32);
            this.Bt_Report.TabIndex = 5;
            this.Bt_Report.Text = "แสดงตัวอย่าง";
            this.Bt_Report.UseVisualStyleBackColor = true;
            this.Bt_Report.Click += new System.EventHandler(this.Bt_Report_Click);
            // 
            // txb_UnitList
            // 
            this.txb_UnitList.Location = new System.Drawing.Point(287, 16);
            this.txb_UnitList.MaxLength = 2;
            this.txb_UnitList.Name = "txb_UnitList";
            this.txb_UnitList.Size = new System.Drawing.Size(40, 26);
            this.txb_UnitList.TabIndex = 9;
            this.txb_UnitList.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "รายการ";
            // 
            // FrmPreBillDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_UnitList);
            this.Controls.Add(this.lb_PetID);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lb_HealDate);
            this.Controls.Add(this.Bt_Report);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPreBillDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตัวอย่างก่อนพิมพ์ ใบนัดหมาย";
            this.Load += new System.EventHandler(this.FrmBillDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_PetID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lb_HealDate;
        private System.Windows.Forms.Button Bt_Report;
        private System.Windows.Forms.TextBox txb_UnitList;
        private System.Windows.Forms.Label label1;
    }
}