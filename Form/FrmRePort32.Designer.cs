namespace Petshop
{
    partial class FrmRePort32
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
            this.dTP_Date = new System.Windows.Forms.DateTimePicker();
            this.dTP_ToDate = new System.Windows.Forms.DateTimePicker();
            this.lb_DateLb = new System.Windows.Forms.Label();
            this.lb_ToDateLb = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tp_Product = new System.Windows.Forms.TabPage();
            this.crViewerProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tp_Medi = new System.Windows.Forms.TabPage();
            this.crViewerMedi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tp_outlay = new System.Windows.Forms.TabPage();
            this.crViewerOutlay = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Service = new System.Windows.Forms.TabPage();
            this.crViewerService = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tp_Product.SuspendLayout();
            this.tp_Medi.SuspendLayout();
            this.tp_outlay.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_Service.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTP_Date
            // 
            this.dTP_Date.Location = new System.Drawing.Point(264, 15);
            this.dTP_Date.Name = "dTP_Date";
            this.dTP_Date.Size = new System.Drawing.Size(200, 26);
            this.dTP_Date.TabIndex = 1;
            // 
            // dTP_ToDate
            // 
            this.dTP_ToDate.Location = new System.Drawing.Point(554, 15);
            this.dTP_ToDate.Name = "dTP_ToDate";
            this.dTP_ToDate.Size = new System.Drawing.Size(200, 26);
            this.dTP_ToDate.TabIndex = 2;
            // 
            // lb_DateLb
            // 
            this.lb_DateLb.AutoSize = true;
            this.lb_DateLb.Location = new System.Drawing.Point(189, 19);
            this.lb_DateLb.Name = "lb_DateLb";
            this.lb_DateLb.Size = new System.Drawing.Size(69, 18);
            this.lb_DateLb.TabIndex = 3;
            this.lb_DateLb.Text = "ตั้งแต่วันที่";
            // 
            // lb_ToDateLb
            // 
            this.lb_ToDateLb.AutoSize = true;
            this.lb_ToDateLb.Location = new System.Drawing.Point(497, 19);
            this.lb_ToDateLb.Name = "lb_ToDateLb";
            this.lb_ToDateLb.Size = new System.Drawing.Size(51, 18);
            this.lb_ToDateLb.TabIndex = 4;
            this.lb_ToDateLb.Text = "ถึงวันที่";
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Location = new System.Drawing.Point(760, 12);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 32);
            this.bt_Search.TabIndex = 5;
            this.bt_Search.Text = "ค้นหา";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tp_Product
            // 
            this.tp_Product.Controls.Add(this.crViewerProduct);
            this.tp_Product.Location = new System.Drawing.Point(4, 27);
            this.tp_Product.Name = "tp_Product";
            this.tp_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Product.Size = new System.Drawing.Size(976, 566);
            this.tp_Product.TabIndex = 2;
            this.tp_Product.Text = "รายรับ(ขายสินค้า)";
            this.tp_Product.UseVisualStyleBackColor = true;
            // 
            // crViewerProduct
            // 
            this.crViewerProduct.ActiveViewIndex = -1;
            this.crViewerProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerProduct.Location = new System.Drawing.Point(3, 3);
            this.crViewerProduct.Name = "crViewerProduct";
            this.crViewerProduct.ShowCloseButton = false;
            this.crViewerProduct.ShowGroupTreeButton = false;
            this.crViewerProduct.ShowLogo = false;
            this.crViewerProduct.ShowParameterPanelButton = false;
            this.crViewerProduct.Size = new System.Drawing.Size(970, 560);
            this.crViewerProduct.TabIndex = 0;
            this.crViewerProduct.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tp_Medi
            // 
            this.tp_Medi.Controls.Add(this.crViewerMedi);
            this.tp_Medi.Location = new System.Drawing.Point(4, 27);
            this.tp_Medi.Name = "tp_Medi";
            this.tp_Medi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Medi.Size = new System.Drawing.Size(976, 566);
            this.tp_Medi.TabIndex = 1;
            this.tp_Medi.Text = "รายรับ(ยา)";
            this.tp_Medi.UseVisualStyleBackColor = true;
            // 
            // crViewerMedi
            // 
            this.crViewerMedi.ActiveViewIndex = -1;
            this.crViewerMedi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerMedi.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerMedi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerMedi.Location = new System.Drawing.Point(3, 3);
            this.crViewerMedi.Name = "crViewerMedi";
            this.crViewerMedi.ShowCloseButton = false;
            this.crViewerMedi.ShowGroupTreeButton = false;
            this.crViewerMedi.ShowLogo = false;
            this.crViewerMedi.ShowParameterPanelButton = false;
            this.crViewerMedi.Size = new System.Drawing.Size(970, 560);
            this.crViewerMedi.TabIndex = 1;
            this.crViewerMedi.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tp_outlay
            // 
            this.tp_outlay.Controls.Add(this.crViewerOutlay);
            this.tp_outlay.Location = new System.Drawing.Point(4, 27);
            this.tp_outlay.Name = "tp_outlay";
            this.tp_outlay.Padding = new System.Windows.Forms.Padding(3);
            this.tp_outlay.Size = new System.Drawing.Size(976, 566);
            this.tp_outlay.TabIndex = 0;
            this.tp_outlay.Text = "รายจ่าย";
            this.tp_outlay.UseVisualStyleBackColor = true;
            // 
            // crViewerOutlay
            // 
            this.crViewerOutlay.ActiveViewIndex = -1;
            this.crViewerOutlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerOutlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerOutlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerOutlay.Location = new System.Drawing.Point(3, 3);
            this.crViewerOutlay.Name = "crViewerOutlay";
            this.crViewerOutlay.ShowCloseButton = false;
            this.crViewerOutlay.ShowGroupTreeButton = false;
            this.crViewerOutlay.ShowLogo = false;
            this.crViewerOutlay.ShowParameterPanelButton = false;
            this.crViewerOutlay.Size = new System.Drawing.Size(970, 560);
            this.crViewerOutlay.TabIndex = 0;
            this.crViewerOutlay.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_outlay);
            this.tabControl1.Controls.Add(this.tp_Service);
            this.tabControl1.Controls.Add(this.tp_Medi);
            this.tabControl1.Controls.Add(this.tp_Product);
            this.tabControl1.Location = new System.Drawing.Point(12, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 597);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Service
            // 
            this.tp_Service.Controls.Add(this.crViewerService);
            this.tp_Service.Location = new System.Drawing.Point(4, 27);
            this.tp_Service.Name = "tp_Service";
            this.tp_Service.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Service.Size = new System.Drawing.Size(976, 566);
            this.tp_Service.TabIndex = 3;
            this.tp_Service.Text = "รายรับ(บริการ)";
            this.tp_Service.UseVisualStyleBackColor = true;
            // 
            // crViewerService
            // 
            this.crViewerService.ActiveViewIndex = -1;
            this.crViewerService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerService.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerService.Location = new System.Drawing.Point(3, 3);
            this.crViewerService.Name = "crViewerService";
            this.crViewerService.ShowCloseButton = false;
            this.crViewerService.ShowGroupTreeButton = false;
            this.crViewerService.ShowLogo = false;
            this.crViewerService.ShowParameterPanelButton = false;
            this.crViewerService.Size = new System.Drawing.Size(970, 560);
            this.crViewerService.TabIndex = 1;
            this.crViewerService.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmRePort32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.lb_ToDateLb);
            this.Controls.Add(this.lb_DateLb);
            this.Controls.Add(this.dTP_ToDate);
            this.Controls.Add(this.dTP_Date);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRePort32";
            this.Text = "ดูรายรับ-รายจ่าย";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRePort32_Load);
            this.tp_Product.ResumeLayout(false);
            this.tp_Medi.ResumeLayout(false);
            this.tp_outlay.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_Service.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP_Date;
        private System.Windows.Forms.DateTimePicker dTP_ToDate;
        private System.Windows.Forms.Label lb_DateLb;
        private System.Windows.Forms.Label lb_ToDateLb;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TabPage tp_Product;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerProduct;
        private System.Windows.Forms.TabPage tp_Medi;
        private System.Windows.Forms.TabPage tp_outlay;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerOutlay;
        private System.Windows.Forms.TabControl tabControl1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerMedi;
        private System.Windows.Forms.TabPage tp_Service;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerService;
    }
}