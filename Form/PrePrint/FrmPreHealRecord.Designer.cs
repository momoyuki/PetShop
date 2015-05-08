namespace Petshop
{
    partial class FrmPreHealRecord
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
            this.bt_Search = new System.Windows.Forms.Button();
            this.lb_ToDateLb = new System.Windows.Forms.Label();
            this.lb_DateLb = new System.Windows.Forms.Label();
            this.dTP_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_Date = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crViewerHealRecord = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txb_PetID = new System.Windows.Forms.TextBox();
            this.CheckBox_PetID = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Location = new System.Drawing.Point(870, 6);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 32);
            this.bt_Search.TabIndex = 10;
            this.bt_Search.Text = "ค้นหา";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // lb_ToDateLb
            // 
            this.lb_ToDateLb.AutoSize = true;
            this.lb_ToDateLb.Location = new System.Drawing.Point(308, 13);
            this.lb_ToDateLb.Name = "lb_ToDateLb";
            this.lb_ToDateLb.Size = new System.Drawing.Size(51, 18);
            this.lb_ToDateLb.TabIndex = 9;
            this.lb_ToDateLb.Text = "ถึงวันที่";
            // 
            // lb_DateLb
            // 
            this.lb_DateLb.AutoSize = true;
            this.lb_DateLb.Location = new System.Drawing.Point(18, 13);
            this.lb_DateLb.Name = "lb_DateLb";
            this.lb_DateLb.Size = new System.Drawing.Size(69, 18);
            this.lb_DateLb.TabIndex = 8;
            this.lb_DateLb.Text = "ตั้งแต่วันที่";
            // 
            // dTP_ToDate
            // 
            this.dTP_ToDate.Location = new System.Drawing.Point(365, 9);
            this.dTP_ToDate.Name = "dTP_ToDate";
            this.dTP_ToDate.Size = new System.Drawing.Size(200, 26);
            this.dTP_ToDate.TabIndex = 7;
            // 
            // dTP_Date
            // 
            this.dTP_Date.Location = new System.Drawing.Point(93, 9);
            this.dTP_Date.Name = "dTP_Date";
            this.dTP_Date.Size = new System.Drawing.Size(200, 26);
            this.dTP_Date.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crViewerHealRecord);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 616);
            this.panel1.TabIndex = 11;
            // 
            // crViewerHealRecord
            // 
            this.crViewerHealRecord.ActiveViewIndex = -1;
            this.crViewerHealRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerHealRecord.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerHealRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerHealRecord.Location = new System.Drawing.Point(0, 0);
            this.crViewerHealRecord.Name = "crViewerHealRecord";
            this.crViewerHealRecord.ShowCloseButton = false;
            this.crViewerHealRecord.ShowGroupTreeButton = false;
            this.crViewerHealRecord.ShowLogo = false;
            this.crViewerHealRecord.ShowParameterPanelButton = false;
            this.crViewerHealRecord.Size = new System.Drawing.Size(984, 616);
            this.crViewerHealRecord.TabIndex = 14;
            this.crViewerHealRecord.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txb_PetID
            // 
            this.txb_PetID.Location = new System.Drawing.Point(682, 10);
            this.txb_PetID.Name = "txb_PetID";
            this.txb_PetID.Size = new System.Drawing.Size(181, 26);
            this.txb_PetID.TabIndex = 13;
            // 
            // CheckBox_PetID
            // 
            this.CheckBox_PetID.AutoSize = true;
            this.CheckBox_PetID.Location = new System.Drawing.Point(599, 14);
            this.CheckBox_PetID.Name = "CheckBox_PetID";
            this.CheckBox_PetID.Size = new System.Drawing.Size(77, 22);
            this.CheckBox_PetID.TabIndex = 14;
            this.CheckBox_PetID.Text = "รหัสสัตว์";
            this.CheckBox_PetID.UseVisualStyleBackColor = true;
            // 
            // FrmPreHealRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.CheckBox_PetID);
            this.Controls.Add(this.txb_PetID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.lb_ToDateLb);
            this.Controls.Add(this.lb_DateLb);
            this.Controls.Add(this.dTP_ToDate);
            this.Controls.Add(this.dTP_Date);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPreHealRecord";
            this.Text = "งานรายการรักษา";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label lb_ToDateLb;
        private System.Windows.Forms.Label lb_DateLb;
        private System.Windows.Forms.DateTimePicker dTP_ToDate;
        private System.Windows.Forms.DateTimePicker dTP_Date;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerHealRecord;
        private System.Windows.Forms.TextBox txb_PetID;
        private System.Windows.Forms.CheckBox CheckBox_PetID;

    }
}