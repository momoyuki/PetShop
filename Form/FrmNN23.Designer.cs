namespace Petshop
{
    partial class FrmNN23
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crViewerBloodtest = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bt_Search = new System.Windows.Forms.Button();
            this.lb_BloodTest = new System.Windows.Forms.Label();
            this.lb_BloodTestID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crViewerBloodtest);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 623);
            this.panel1.TabIndex = 20;
            // 
            // crViewerBloodtest
            // 
            this.crViewerBloodtest.ActiveViewIndex = -1;
            this.crViewerBloodtest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerBloodtest.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerBloodtest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerBloodtest.Location = new System.Drawing.Point(0, 0);
            this.crViewerBloodtest.Name = "crViewerBloodtest";
            this.crViewerBloodtest.ShowCloseButton = false;
            this.crViewerBloodtest.ShowGroupTreeButton = false;
            this.crViewerBloodtest.ShowLogo = false;
            this.crViewerBloodtest.ShowParameterPanelButton = false;
            this.crViewerBloodtest.Size = new System.Drawing.Size(990, 623);
            this.crViewerBloodtest.TabIndex = 14;
            this.crViewerBloodtest.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Location = new System.Drawing.Point(273, 6);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 32);
            this.bt_Search.TabIndex = 19;
            this.bt_Search.Text = "ค้นหา";
            this.bt_Search.UseVisualStyleBackColor = true;
            // 
            // lb_BloodTest
            // 
            this.lb_BloodTest.AutoSize = true;
            this.lb_BloodTest.Location = new System.Drawing.Point(33, 13);
            this.lb_BloodTest.Name = "lb_BloodTest";
            this.lb_BloodTest.Size = new System.Drawing.Size(92, 18);
            this.lb_BloodTest.TabIndex = 21;
            this.lb_BloodTest.Text = "เลขที่ผลเลือด";
            // 
            // lb_BloodTestID
            // 
            this.lb_BloodTestID.AutoSize = true;
            this.lb_BloodTestID.Location = new System.Drawing.Point(131, 13);
            this.lb_BloodTestID.Name = "lb_BloodTestID";
            this.lb_BloodTestID.Size = new System.Drawing.Size(16, 18);
            this.lb_BloodTestID.TabIndex = 22;
            this.lb_BloodTestID.Text = "0";
            // 
            // FrmNN23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.lb_BloodTestID);
            this.Controls.Add(this.lb_BloodTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Search);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNN23";
            this.Text = "พิมพ์ผลตรวจเลือด";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerBloodtest;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label lb_BloodTest;
        public System.Windows.Forms.Label lb_BloodTestID;
    }
}