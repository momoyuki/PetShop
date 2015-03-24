namespace Petshop
{
    partial class FrmMM13
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
            this.dGV_Uni = new System.Windows.Forms.DataGridView();
            this.ccUnit_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccUnit_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxUnit = new System.Windows.Forms.GroupBox();
            this.bt_LoadUnit = new System.Windows.Forms.Button();
            this.bt_EditUnit = new System.Windows.Forms.Button();
            this.bt_AddUnit = new System.Windows.Forms.Button();
            this.txb_UnitID = new System.Windows.Forms.TextBox();
            this.txb_UnitName = new System.Windows.Forms.TextBox();
            this.lb_UnitID = new System.Windows.Forms.Label();
            this.lb_UnitName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Uni)).BeginInit();
            this.gBoxUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Uni
            // 
            this.dGV_Uni.AllowUserToAddRows = false;
            this.dGV_Uni.AllowUserToDeleteRows = false;
            this.dGV_Uni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Uni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccUnit_ID,
            this.ccUnit_Name});
            this.dGV_Uni.Location = new System.Drawing.Point(16, 190);
            this.dGV_Uni.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Uni.Name = "dGV_Uni";
            this.dGV_Uni.ReadOnly = true;
            this.dGV_Uni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Uni.Size = new System.Drawing.Size(599, 469);
            this.dGV_Uni.TabIndex = 1;
            this.dGV_Uni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Uni_CellClick);
            // 
            // ccUnit_ID
            // 
            this.ccUnit_ID.DataPropertyName = "Unit_ID";
            this.ccUnit_ID.HeaderText = "รหัส";
            this.ccUnit_ID.Name = "ccUnit_ID";
            this.ccUnit_ID.ReadOnly = true;
            this.ccUnit_ID.Width = 40;
            // 
            // ccUnit_Name
            // 
            this.ccUnit_Name.DataPropertyName = "Unit_Name";
            this.ccUnit_Name.HeaderText = "หน่วยเรียก";
            this.ccUnit_Name.Name = "ccUnit_Name";
            this.ccUnit_Name.ReadOnly = true;
            // 
            // gBoxUnit
            // 
            this.gBoxUnit.Controls.Add(this.button1);
            this.gBoxUnit.Controls.Add(this.bt_LoadUnit);
            this.gBoxUnit.Controls.Add(this.bt_EditUnit);
            this.gBoxUnit.Controls.Add(this.bt_AddUnit);
            this.gBoxUnit.Controls.Add(this.txb_UnitID);
            this.gBoxUnit.Controls.Add(this.txb_UnitName);
            this.gBoxUnit.Controls.Add(this.lb_UnitID);
            this.gBoxUnit.Controls.Add(this.lb_UnitName);
            this.gBoxUnit.Location = new System.Drawing.Point(16, 13);
            this.gBoxUnit.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxUnit.Name = "gBoxUnit";
            this.gBoxUnit.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxUnit.Size = new System.Drawing.Size(599, 169);
            this.gBoxUnit.TabIndex = 0;
            this.gBoxUnit.TabStop = false;
            this.gBoxUnit.Text = "รายละเอียด";
            // 
            // bt_LoadUnit
            // 
            this.bt_LoadUnit.Location = new System.Drawing.Point(491, 16);
            this.bt_LoadUnit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadUnit.Name = "bt_LoadUnit";
            this.bt_LoadUnit.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadUnit.TabIndex = 16;
            this.bt_LoadUnit.Text = "LoadUnit";
            this.bt_LoadUnit.UseVisualStyleBackColor = true;
            this.bt_LoadUnit.Visible = false;
            this.bt_LoadUnit.Click += new System.EventHandler(this.bt_LoadUnit_Click);
            // 
            // bt_EditUnit
            // 
            this.bt_EditUnit.Location = new System.Drawing.Point(197, 109);
            this.bt_EditUnit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditUnit.Name = "bt_EditUnit";
            this.bt_EditUnit.Size = new System.Drawing.Size(70, 32);
            this.bt_EditUnit.TabIndex = 4;
            this.bt_EditUnit.Text = "แก้ไข";
            this.bt_EditUnit.UseVisualStyleBackColor = true;
            this.bt_EditUnit.Click += new System.EventHandler(this.bt_EditUnit_Click);
            // 
            // bt_AddUnit
            // 
            this.bt_AddUnit.Location = new System.Drawing.Point(119, 109);
            this.bt_AddUnit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddUnit.Name = "bt_AddUnit";
            this.bt_AddUnit.Size = new System.Drawing.Size(70, 32);
            this.bt_AddUnit.TabIndex = 3;
            this.bt_AddUnit.Text = "เพิ่ม";
            this.bt_AddUnit.UseVisualStyleBackColor = true;
            this.bt_AddUnit.Click += new System.EventHandler(this.bt_AddUnit_Click);
            // 
            // txb_UnitID
            // 
            this.txb_UnitID.Enabled = false;
            this.txb_UnitID.Location = new System.Drawing.Point(116, 27);
            this.txb_UnitID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UnitID.Name = "txb_UnitID";
            this.txb_UnitID.Size = new System.Drawing.Size(132, 26);
            this.txb_UnitID.TabIndex = 1;
            // 
            // txb_UnitName
            // 
            this.txb_UnitName.Location = new System.Drawing.Point(116, 63);
            this.txb_UnitName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UnitName.Name = "txb_UnitName";
            this.txb_UnitName.Size = new System.Drawing.Size(163, 26);
            this.txb_UnitName.TabIndex = 2;
            this.txb_UnitName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_UnitName_KeyDown);
            // 
            // lb_UnitID
            // 
            this.lb_UnitID.AutoSize = true;
            this.lb_UnitID.Location = new System.Drawing.Point(36, 30);
            this.lb_UnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UnitID.Name = "lb_UnitID";
            this.lb_UnitID.Size = new System.Drawing.Size(68, 18);
            this.lb_UnitID.TabIndex = 1;
            this.lb_UnitID.Text = "รหัสหน่วย";
            // 
            // lb_UnitName
            // 
            this.lb_UnitName.AutoSize = true;
            this.lb_UnitName.Location = new System.Drawing.Point(32, 66);
            this.lb_UnitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UnitName.Name = "lb_UnitName";
            this.lb_UnitName.Size = new System.Drawing.Size(72, 18);
            this.lb_UnitName.TabIndex = 0;
            this.lb_UnitName.Text = "เรียกหน่วย";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(275, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "ลบ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMM13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 672);
            this.Controls.Add(this.dGV_Uni);
            this.Controls.Add(this.gBoxUnit);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMM13";
            this.Text = "ตั้งค่า หน่วย";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Uni)).EndInit();
            this.gBoxUnit.ResumeLayout(false);
            this.gBoxUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Uni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccUnit_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccUnit_Name;
        private System.Windows.Forms.GroupBox gBoxUnit;
        private System.Windows.Forms.Button bt_LoadUnit;
        private System.Windows.Forms.Button bt_EditUnit;
        private System.Windows.Forms.Button bt_AddUnit;
        private System.Windows.Forms.TextBox txb_UnitID;
        private System.Windows.Forms.TextBox txb_UnitName;
        private System.Windows.Forms.Label lb_UnitID;
        private System.Windows.Forms.Label lb_UnitName;
        private System.Windows.Forms.Button button1;
    }
}