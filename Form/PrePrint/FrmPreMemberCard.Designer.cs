namespace Petshop
{
    partial class FrmPreMemberCard
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
            this.txb_PetID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crViewerBloodtest);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 606);
            this.panel1.TabIndex = 0;
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
            this.crViewerBloodtest.Size = new System.Drawing.Size(982, 606);
            this.crViewerBloodtest.TabIndex = 15;
            this.crViewerBloodtest.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // bt_Search
            // 
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Search.Location = new System.Drawing.Point(243, 14);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(104, 32);
            this.bt_Search.TabIndex = 25;
            this.bt_Search.Text = "แสดงตัวอย่าง";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // txb_PetID
            // 
            this.txb_PetID.Location = new System.Drawing.Point(84, 18);
            this.txb_PetID.Name = "txb_PetID";
            this.txb_PetID.Size = new System.Drawing.Size(152, 26);
            this.txb_PetID.TabIndex = 26;
            this.txb_PetID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "บัตรเลขที่";
            // 
            // FrmPreMemberCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_PetID);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPreMemberCard";
            this.Text = "พิมพ์บัตรสมาชิก";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Search;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerBloodtest;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txb_PetID;
    }
}