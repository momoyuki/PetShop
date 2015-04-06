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
            this.lb_Searchincome = new System.Windows.Forms.Label();
            this.lb_SearchincomeB = new System.Windows.Forms.Label();
            this.lb_SearchincomeA = new System.Windows.Forms.Label();
            this.txb_Searchincome = new System.Windows.Forms.TextBox();
            this.bt_Searchincome = new System.Windows.Forms.Button();
            this.bt_Resetincome = new System.Windows.Forms.Button();
            this.bt_Delincome = new System.Windows.Forms.Button();
            this.lb_Remarkincomeid = new System.Windows.Forms.Label();
            this.Bt_Loadincome = new System.Windows.Forms.Button();
            this.bt_Editincome = new System.Windows.Forms.Button();
            this.bt_Addincome = new System.Windows.Forms.Button();
            this.txb_incomeRemark = new System.Windows.Forms.TextBox();
            this.lb_Remarkincome = new System.Windows.Forms.Label();
            this.txb_incomeDetail = new System.Windows.Forms.TextBox();
            this.lb_income = new System.Windows.Forms.Label();
            this.txb_incomeID = new System.Windows.Forms.TextBox();
            this.lb_incomeID = new System.Windows.Forms.Label();
            this.dGV_income = new System.Windows.Forms.DataGridView();
            this.ccincome_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccincome_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccincome_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_income)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Searchincome
            // 
            this.lb_Searchincome.AutoSize = true;
            this.lb_Searchincome.Location = new System.Drawing.Point(193, 185);
            this.lb_Searchincome.Name = "lb_Searchincome";
            this.lb_Searchincome.Size = new System.Drawing.Size(16, 18);
            this.lb_Searchincome.TabIndex = 42;
            this.lb_Searchincome.Text = "0";
            // 
            // lb_SearchincomeB
            // 
            this.lb_SearchincomeB.AutoSize = true;
            this.lb_SearchincomeB.Location = new System.Drawing.Point(264, 185);
            this.lb_SearchincomeB.Name = "lb_SearchincomeB";
            this.lb_SearchincomeB.Size = new System.Drawing.Size(52, 18);
            this.lb_SearchincomeB.TabIndex = 41;
            this.lb_SearchincomeB.Text = "รายการ";
            // 
            // lb_SearchincomeA
            // 
            this.lb_SearchincomeA.AutoSize = true;
            this.lb_SearchincomeA.Location = new System.Drawing.Point(82, 185);
            this.lb_SearchincomeA.Name = "lb_SearchincomeA";
            this.lb_SearchincomeA.Size = new System.Drawing.Size(74, 18);
            this.lb_SearchincomeA.TabIndex = 40;
            this.lb_SearchincomeA.Text = "พบทั้งหมด";
            // 
            // txb_Searchincome
            // 
            this.txb_Searchincome.Location = new System.Drawing.Point(586, 182);
            this.txb_Searchincome.Name = "txb_Searchincome";
            this.txb_Searchincome.Size = new System.Drawing.Size(262, 26);
            this.txb_Searchincome.TabIndex = 36;
            // 
            // bt_Searchincome
            // 
            this.bt_Searchincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Searchincome.Location = new System.Drawing.Point(854, 178);
            this.bt_Searchincome.Name = "bt_Searchincome";
            this.bt_Searchincome.Size = new System.Drawing.Size(101, 32);
            this.bt_Searchincome.TabIndex = 37;
            this.bt_Searchincome.Text = "ค้นหา";
            this.bt_Searchincome.UseVisualStyleBackColor = true;
            // 
            // bt_Resetincome
            // 
            this.bt_Resetincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Resetincome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Resetincome.Location = new System.Drawing.Point(237, 9);
            this.bt_Resetincome.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Resetincome.Name = "bt_Resetincome";
            this.bt_Resetincome.Size = new System.Drawing.Size(70, 32);
            this.bt_Resetincome.TabIndex = 39;
            this.bt_Resetincome.Text = "เริ่มใหม่";
            this.bt_Resetincome.UseVisualStyleBackColor = true;
            // 
            // bt_Delincome
            // 
            this.bt_Delincome.Enabled = false;
            this.bt_Delincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delincome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Delincome.Location = new System.Drawing.Point(542, 143);
            this.bt_Delincome.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Delincome.Name = "bt_Delincome";
            this.bt_Delincome.Size = new System.Drawing.Size(70, 32);
            this.bt_Delincome.TabIndex = 35;
            this.bt_Delincome.Text = "ลบ";
            this.bt_Delincome.UseVisualStyleBackColor = true;
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
            // Bt_Loadincome
            // 
            this.Bt_Loadincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Loadincome.Location = new System.Drawing.Point(464, 7);
            this.Bt_Loadincome.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Loadincome.Name = "Bt_Loadincome";
            this.Bt_Loadincome.Size = new System.Drawing.Size(100, 32);
            this.Bt_Loadincome.TabIndex = 38;
            this.Bt_Loadincome.Text = "LoadService";
            this.Bt_Loadincome.UseVisualStyleBackColor = true;
            this.Bt_Loadincome.Visible = false;
            // 
            // bt_Editincome
            // 
            this.bt_Editincome.Enabled = false;
            this.bt_Editincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Editincome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Editincome.Location = new System.Drawing.Point(464, 143);
            this.bt_Editincome.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Editincome.Name = "bt_Editincome";
            this.bt_Editincome.Size = new System.Drawing.Size(70, 32);
            this.bt_Editincome.TabIndex = 34;
            this.bt_Editincome.Text = "แก้ไข";
            this.bt_Editincome.UseVisualStyleBackColor = true;
            // 
            // bt_Addincome
            // 
            this.bt_Addincome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Addincome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Addincome.Location = new System.Drawing.Point(386, 143);
            this.bt_Addincome.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Addincome.Name = "bt_Addincome";
            this.bt_Addincome.Size = new System.Drawing.Size(70, 32);
            this.bt_Addincome.TabIndex = 33;
            this.bt_Addincome.Text = "เพิ่ม";
            this.bt_Addincome.UseVisualStyleBackColor = true;
            // 
            // txb_incomeRemark
            // 
            this.txb_incomeRemark.Location = new System.Drawing.Point(89, 99);
            this.txb_incomeRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txb_incomeRemark.MaxLength = 11;
            this.txb_incomeRemark.Multiline = true;
            this.txb_incomeRemark.Name = "txb_incomeRemark";
            this.txb_incomeRemark.Size = new System.Drawing.Size(289, 76);
            this.txb_incomeRemark.TabIndex = 31;
            // 
            // lb_Remarkincome
            // 
            this.lb_Remarkincome.AutoSize = true;
            this.lb_Remarkincome.Location = new System.Drawing.Point(13, 105);
            this.lb_Remarkincome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Remarkincome.Name = "lb_Remarkincome";
            this.lb_Remarkincome.Size = new System.Drawing.Size(67, 18);
            this.lb_Remarkincome.TabIndex = 27;
            this.lb_Remarkincome.Text = "หมายเหตุ";
            // 
            // txb_incomeDetail
            // 
            this.txb_incomeDetail.Location = new System.Drawing.Point(89, 65);
            this.txb_incomeDetail.Margin = new System.Windows.Forms.Padding(4);
            this.txb_incomeDetail.MaxLength = 100;
            this.txb_incomeDetail.Name = "txb_incomeDetail";
            this.txb_incomeDetail.Size = new System.Drawing.Size(289, 26);
            this.txb_incomeDetail.TabIndex = 30;
            // 
            // lb_income
            // 
            this.lb_income.AutoSize = true;
            this.lb_income.Location = new System.Drawing.Point(31, 69);
            this.lb_income.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_income.Name = "lb_income";
            this.lb_income.Size = new System.Drawing.Size(53, 18);
            this.lb_income.TabIndex = 26;
            this.lb_income.Text = "บริการ*";
            // 
            // txb_incomeID
            // 
            this.txb_incomeID.Enabled = false;
            this.txb_incomeID.Location = new System.Drawing.Point(89, 13);
            this.txb_incomeID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_incomeID.MaxLength = 16;
            this.txb_incomeID.Name = "txb_incomeID";
            this.txb_incomeID.Size = new System.Drawing.Size(140, 26);
            this.txb_incomeID.TabIndex = 29;
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
            // dGV_income
            // 
            this.dGV_income.AllowUserToAddRows = false;
            this.dGV_income.AllowUserToDeleteRows = false;
            this.dGV_income.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_income.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccincome_ID,
            this.ccincome_detail,
            this.ccincome_Remark});
            this.dGV_income.Location = new System.Drawing.Point(13, 217);
            this.dGV_income.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_income.MultiSelect = false;
            this.dGV_income.Name = "dGV_income";
            this.dGV_income.ReadOnly = true;
            this.dGV_income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_income.Size = new System.Drawing.Size(982, 442);
            this.dGV_income.TabIndex = 43;
            // 
            // ccincome_ID
            // 
            this.ccincome_ID.HeaderText = "รหัส";
            this.ccincome_ID.Name = "ccincome_ID";
            this.ccincome_ID.ReadOnly = true;
            // 
            // ccincome_detail
            // 
            this.ccincome_detail.FillWeight = 240F;
            this.ccincome_detail.HeaderText = "รายละเอียด";
            this.ccincome_detail.Name = "ccincome_detail";
            this.ccincome_detail.ReadOnly = true;
            this.ccincome_detail.Width = 240;
            // 
            // ccincome_Remark
            // 
            this.ccincome_Remark.FillWeight = 250F;
            this.ccincome_Remark.HeaderText = "หมายเหตุ";
            this.ccincome_Remark.Name = "ccincome_Remark";
            this.ccincome_Remark.ReadOnly = true;
            this.ccincome_Remark.Width = 250;
            // 
            // Frmincome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.dGV_income);
            this.Controls.Add(this.lb_Searchincome);
            this.Controls.Add(this.lb_SearchincomeB);
            this.Controls.Add(this.lb_SearchincomeA);
            this.Controls.Add(this.txb_Searchincome);
            this.Controls.Add(this.bt_Searchincome);
            this.Controls.Add(this.bt_Resetincome);
            this.Controls.Add(this.bt_Delincome);
            this.Controls.Add(this.lb_Remarkincomeid);
            this.Controls.Add(this.Bt_Loadincome);
            this.Controls.Add(this.bt_Editincome);
            this.Controls.Add(this.bt_Addincome);
            this.Controls.Add(this.txb_incomeRemark);
            this.Controls.Add(this.lb_Remarkincome);
            this.Controls.Add(this.txb_incomeDetail);
            this.Controls.Add(this.lb_income);
            this.Controls.Add(this.txb_incomeID);
            this.Controls.Add(this.lb_incomeID);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmincome";
            this.Text = "income";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Searchincome;
        private System.Windows.Forms.Label lb_SearchincomeB;
        private System.Windows.Forms.Label lb_SearchincomeA;
        private System.Windows.Forms.TextBox txb_Searchincome;
        private System.Windows.Forms.Button bt_Searchincome;
        private System.Windows.Forms.Button bt_Resetincome;
        private System.Windows.Forms.Button bt_Delincome;
        private System.Windows.Forms.Label lb_Remarkincomeid;
        private System.Windows.Forms.Button Bt_Loadincome;
        private System.Windows.Forms.Button bt_Editincome;
        private System.Windows.Forms.Button bt_Addincome;
        private System.Windows.Forms.TextBox txb_incomeRemark;
        private System.Windows.Forms.Label lb_Remarkincome;
        private System.Windows.Forms.TextBox txb_incomeDetail;
        private System.Windows.Forms.Label lb_income;
        private System.Windows.Forms.TextBox txb_incomeID;
        private System.Windows.Forms.Label lb_incomeID;
        private System.Windows.Forms.DataGridView dGV_income;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccincome_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccincome_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccincome_Remark;
    }
}