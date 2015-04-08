namespace Petshop
{
    partial class FrmSetting13
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
            this.components = new System.ComponentModel.Container();
            this.lb_Searchoutlay = new System.Windows.Forms.Label();
            this.lb_SearchoutlayB = new System.Windows.Forms.Label();
            this.lb_SearchoutlayA = new System.Windows.Forms.Label();
            this.txb_Searchoutlay = new System.Windows.Forms.TextBox();
            this.bt_Searchoutlay = new System.Windows.Forms.Button();
            this.bt_Resetoutlay = new System.Windows.Forms.Button();
            this.bt_Deloutlay = new System.Windows.Forms.Button();
            this.lb_Remarkincomeid = new System.Windows.Forms.Label();
            this.Bt_Loadoutlay = new System.Windows.Forms.Button();
            this.bt_Editoutlay = new System.Windows.Forms.Button();
            this.bt_Addoutlay = new System.Windows.Forms.Button();
            this.txb_outlayRemark = new System.Windows.Forms.TextBox();
            this.lb_Remarkoutlay = new System.Windows.Forms.Label();
            this.txb_outlayDetail = new System.Windows.Forms.TextBox();
            this.lb_outlay = new System.Windows.Forms.Label();
            this.txb_outlayID = new System.Windows.Forms.TextBox();
            this.lb_incomeID = new System.Windows.Forms.Label();
            this.dGV_outlay = new System.Windows.Forms.DataGridView();
            this.ccoutlay_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoutlay_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoutlay_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_outlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Searchoutlay
            // 
            this.lb_Searchoutlay.AutoSize = true;
            this.lb_Searchoutlay.Location = new System.Drawing.Point(193, 185);
            this.lb_Searchoutlay.Name = "lb_Searchoutlay";
            this.lb_Searchoutlay.Size = new System.Drawing.Size(16, 18);
            this.lb_Searchoutlay.TabIndex = 42;
            this.lb_Searchoutlay.Text = "0";
            // 
            // lb_SearchoutlayB
            // 
            this.lb_SearchoutlayB.AutoSize = true;
            this.lb_SearchoutlayB.Location = new System.Drawing.Point(264, 185);
            this.lb_SearchoutlayB.Name = "lb_SearchoutlayB";
            this.lb_SearchoutlayB.Size = new System.Drawing.Size(52, 18);
            this.lb_SearchoutlayB.TabIndex = 41;
            this.lb_SearchoutlayB.Text = "รายการ";
            // 
            // lb_SearchoutlayA
            // 
            this.lb_SearchoutlayA.AutoSize = true;
            this.lb_SearchoutlayA.Location = new System.Drawing.Point(82, 185);
            this.lb_SearchoutlayA.Name = "lb_SearchoutlayA";
            this.lb_SearchoutlayA.Size = new System.Drawing.Size(74, 18);
            this.lb_SearchoutlayA.TabIndex = 40;
            this.lb_SearchoutlayA.Text = "พบทั้งหมด";
            // 
            // txb_Searchoutlay
            // 
            this.txb_Searchoutlay.Location = new System.Drawing.Point(586, 182);
            this.txb_Searchoutlay.Name = "txb_Searchoutlay";
            this.txb_Searchoutlay.Size = new System.Drawing.Size(262, 26);
            this.txb_Searchoutlay.TabIndex = 6;
            // 
            // bt_Searchoutlay
            // 
            this.bt_Searchoutlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Searchoutlay.Location = new System.Drawing.Point(854, 178);
            this.bt_Searchoutlay.Name = "bt_Searchoutlay";
            this.bt_Searchoutlay.Size = new System.Drawing.Size(101, 32);
            this.bt_Searchoutlay.TabIndex = 7;
            this.bt_Searchoutlay.Text = "ค้นหา";
            this.bt_Searchoutlay.UseVisualStyleBackColor = true;
            // 
            // bt_Resetoutlay
            // 
            this.bt_Resetoutlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Resetoutlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Resetoutlay.Location = new System.Drawing.Point(237, 9);
            this.bt_Resetoutlay.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Resetoutlay.Name = "bt_Resetoutlay";
            this.bt_Resetoutlay.Size = new System.Drawing.Size(70, 32);
            this.bt_Resetoutlay.TabIndex = 8;
            this.bt_Resetoutlay.Text = "เริ่มใหม่";
            this.bt_Resetoutlay.UseVisualStyleBackColor = true;
            this.bt_Resetoutlay.Click += new System.EventHandler(this.bt_Resetoutlay_Click);
            // 
            // bt_Deloutlay
            // 
            this.bt_Deloutlay.Enabled = false;
            this.bt_Deloutlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Deloutlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Deloutlay.Location = new System.Drawing.Point(542, 143);
            this.bt_Deloutlay.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Deloutlay.Name = "bt_Deloutlay";
            this.bt_Deloutlay.Size = new System.Drawing.Size(70, 32);
            this.bt_Deloutlay.TabIndex = 5;
            this.bt_Deloutlay.Text = "ลบ";
            this.bt_Deloutlay.UseVisualStyleBackColor = true;
            this.bt_Deloutlay.Click += new System.EventHandler(this.bt_Deloutlay_Click);
            // 
            // lb_Remarkincomeid
            // 
            this.lb_Remarkincomeid.AutoSize = true;
            this.lb_Remarkincomeid.Location = new System.Drawing.Point(12, 43);
            this.lb_Remarkincomeid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Remarkincomeid.Name = "lb_Remarkincomeid";
            this.lb_Remarkincomeid.Size = new System.Drawing.Size(283, 18);
            this.lb_Remarkincomeid.TabIndex = 28;
            this.lb_Remarkincomeid.Text = "*รหัสบริการจะทำการสร้างขึ้นใหม่โดยอัตโนมัติ";
            // 
            // Bt_Loadoutlay
            // 
            this.Bt_Loadoutlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Loadoutlay.Location = new System.Drawing.Point(464, 7);
            this.Bt_Loadoutlay.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Loadoutlay.Name = "Bt_Loadoutlay";
            this.Bt_Loadoutlay.Size = new System.Drawing.Size(100, 32);
            this.Bt_Loadoutlay.TabIndex = 38;
            this.Bt_Loadoutlay.Text = "LoadService";
            this.Bt_Loadoutlay.UseVisualStyleBackColor = true;
            this.Bt_Loadoutlay.Visible = false;
            this.Bt_Loadoutlay.Click += new System.EventHandler(this.Bt_Loadoutlay_Click);
            // 
            // bt_Editoutlay
            // 
            this.bt_Editoutlay.Enabled = false;
            this.bt_Editoutlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Editoutlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Editoutlay.Location = new System.Drawing.Point(464, 143);
            this.bt_Editoutlay.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Editoutlay.Name = "bt_Editoutlay";
            this.bt_Editoutlay.Size = new System.Drawing.Size(70, 32);
            this.bt_Editoutlay.TabIndex = 4;
            this.bt_Editoutlay.Text = "แก้ไข";
            this.bt_Editoutlay.UseVisualStyleBackColor = true;
            this.bt_Editoutlay.Click += new System.EventHandler(this.bt_Editoutlay_Click);
            // 
            // bt_Addoutlay
            // 
            this.bt_Addoutlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Addoutlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Addoutlay.Location = new System.Drawing.Point(386, 143);
            this.bt_Addoutlay.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Addoutlay.Name = "bt_Addoutlay";
            this.bt_Addoutlay.Size = new System.Drawing.Size(70, 32);
            this.bt_Addoutlay.TabIndex = 3;
            this.bt_Addoutlay.Text = "เพิ่ม";
            this.bt_Addoutlay.UseVisualStyleBackColor = true;
            this.bt_Addoutlay.Click += new System.EventHandler(this.bt_Addoutlay_Click);
            // 
            // txb_outlayRemark
            // 
            this.txb_outlayRemark.Location = new System.Drawing.Point(89, 99);
            this.txb_outlayRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txb_outlayRemark.MaxLength = 11;
            this.txb_outlayRemark.Multiline = true;
            this.txb_outlayRemark.Name = "txb_outlayRemark";
            this.txb_outlayRemark.Size = new System.Drawing.Size(289, 76);
            this.txb_outlayRemark.TabIndex = 2;
            // 
            // lb_Remarkoutlay
            // 
            this.lb_Remarkoutlay.AutoSize = true;
            this.lb_Remarkoutlay.Location = new System.Drawing.Point(13, 105);
            this.lb_Remarkoutlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Remarkoutlay.Name = "lb_Remarkoutlay";
            this.lb_Remarkoutlay.Size = new System.Drawing.Size(67, 18);
            this.lb_Remarkoutlay.TabIndex = 27;
            this.lb_Remarkoutlay.Text = "หมายเหตุ";
            // 
            // txb_outlayDetail
            // 
            this.txb_outlayDetail.Location = new System.Drawing.Point(89, 65);
            this.txb_outlayDetail.Margin = new System.Windows.Forms.Padding(4);
            this.txb_outlayDetail.MaxLength = 100;
            this.txb_outlayDetail.Name = "txb_outlayDetail";
            this.txb_outlayDetail.Size = new System.Drawing.Size(289, 26);
            this.txb_outlayDetail.TabIndex = 1;
            // 
            // lb_outlay
            // 
            this.lb_outlay.AutoSize = true;
            this.lb_outlay.Location = new System.Drawing.Point(31, 69);
            this.lb_outlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_outlay.Name = "lb_outlay";
            this.lb_outlay.Size = new System.Drawing.Size(53, 18);
            this.lb_outlay.TabIndex = 26;
            this.lb_outlay.Text = "บริการ*";
            // 
            // txb_outlayID
            // 
            this.txb_outlayID.Enabled = false;
            this.txb_outlayID.Location = new System.Drawing.Point(89, 13);
            this.txb_outlayID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_outlayID.MaxLength = 16;
            this.txb_outlayID.Name = "txb_outlayID";
            this.txb_outlayID.Size = new System.Drawing.Size(140, 26);
            this.txb_outlayID.TabIndex = 0;
            this.txb_outlayID.TextChanged += new System.EventHandler(this.txb_outlayID_TextChanged);
            // 
            // lb_incomeID
            // 
            this.lb_incomeID.AutoSize = true;
            this.lb_incomeID.Location = new System.Drawing.Point(12, 17);
            this.lb_incomeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_incomeID.Name = "lb_incomeID";
            this.lb_incomeID.Size = new System.Drawing.Size(78, 18);
            this.lb_incomeID.TabIndex = 25;
            this.lb_incomeID.Text = "รหัสบริการ*";
            // 
            // dGV_outlay
            // 
            this.dGV_outlay.AllowUserToAddRows = false;
            this.dGV_outlay.AllowUserToDeleteRows = false;
            this.dGV_outlay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_outlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_outlay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccoutlay_ID,
            this.ccoutlay_detail,
            this.ccoutlay_Remark});
            this.dGV_outlay.Location = new System.Drawing.Point(13, 217);
            this.dGV_outlay.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_outlay.MultiSelect = false;
            this.dGV_outlay.Name = "dGV_outlay";
            this.dGV_outlay.ReadOnly = true;
            this.dGV_outlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_outlay.Size = new System.Drawing.Size(982, 442);
            this.dGV_outlay.TabIndex = 43;
            this.dGV_outlay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_outlay_CellClick);
            // 
            // ccoutlay_ID
            // 
            this.ccoutlay_ID.DataPropertyName = "outlay_ID";
            this.ccoutlay_ID.HeaderText = "รหัส";
            this.ccoutlay_ID.Name = "ccoutlay_ID";
            this.ccoutlay_ID.ReadOnly = true;
            // 
            // ccoutlay_detail
            // 
            this.ccoutlay_detail.DataPropertyName = "outlay_detail";
            this.ccoutlay_detail.FillWeight = 240F;
            this.ccoutlay_detail.HeaderText = "รายละเอียด";
            this.ccoutlay_detail.Name = "ccoutlay_detail";
            this.ccoutlay_detail.ReadOnly = true;
            this.ccoutlay_detail.Width = 240;
            // 
            // ccoutlay_Remark
            // 
            this.ccoutlay_Remark.DataPropertyName = "outlay_Remark";
            this.ccoutlay_Remark.FillWeight = 250F;
            this.ccoutlay_Remark.HeaderText = "หมายเหตุ";
            this.ccoutlay_Remark.Name = "ccoutlay_Remark";
            this.ccoutlay_Remark.ReadOnly = true;
            this.ccoutlay_Remark.Width = 250;
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // FrmSetting13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.dGV_outlay);
            this.Controls.Add(this.lb_Searchoutlay);
            this.Controls.Add(this.lb_SearchoutlayB);
            this.Controls.Add(this.lb_SearchoutlayA);
            this.Controls.Add(this.txb_Searchoutlay);
            this.Controls.Add(this.bt_Searchoutlay);
            this.Controls.Add(this.bt_Resetoutlay);
            this.Controls.Add(this.bt_Deloutlay);
            this.Controls.Add(this.lb_Remarkincomeid);
            this.Controls.Add(this.Bt_Loadoutlay);
            this.Controls.Add(this.bt_Editoutlay);
            this.Controls.Add(this.bt_Addoutlay);
            this.Controls.Add(this.txb_outlayRemark);
            this.Controls.Add(this.lb_Remarkoutlay);
            this.Controls.Add(this.txb_outlayDetail);
            this.Controls.Add(this.lb_outlay);
            this.Controls.Add(this.txb_outlayID);
            this.Controls.Add(this.lb_incomeID);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSetting13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "income";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSetting13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_outlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Searchoutlay;
        private System.Windows.Forms.Label lb_SearchoutlayB;
        private System.Windows.Forms.Label lb_SearchoutlayA;
        private System.Windows.Forms.TextBox txb_Searchoutlay;
        private System.Windows.Forms.Button bt_Searchoutlay;
        private System.Windows.Forms.Button bt_Resetoutlay;
        private System.Windows.Forms.Button bt_Deloutlay;
        private System.Windows.Forms.Label lb_Remarkincomeid;
        private System.Windows.Forms.Button Bt_Loadoutlay;
        private System.Windows.Forms.Button bt_Editoutlay;
        private System.Windows.Forms.Button bt_Addoutlay;
        private System.Windows.Forms.TextBox txb_outlayRemark;
        private System.Windows.Forms.Label lb_Remarkoutlay;
        private System.Windows.Forms.TextBox txb_outlayDetail;
        private System.Windows.Forms.Label lb_outlay;
        private System.Windows.Forms.TextBox txb_outlayID;
        private System.Windows.Forms.Label lb_incomeID;
        private System.Windows.Forms.DataGridView dGV_outlay;
        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoutlay_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoutlay_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoutlay_Remark;
    }
}