namespace Petshop
{
    partial class FrmSetting15
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
            this.tabControlBreedType = new System.Windows.Forms.TabControl();
            this.tpBreed = new System.Windows.Forms.TabPage();
            this.gBoxBreed = new System.Windows.Forms.GroupBox();
            this.bt_DelBreed = new System.Windows.Forms.Button();
            this.Bt_LoadBreed = new System.Windows.Forms.Button();
            this.bt_EditBreed = new System.Windows.Forms.Button();
            this.bt_AddBreed = new System.Windows.Forms.Button();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.lb_cbType = new System.Windows.Forms.Label();
            this.txb_BreedName = new System.Windows.Forms.TextBox();
            this.lb_BreedName = new System.Windows.Forms.Label();
            this.txb_BreedID = new System.Windows.Forms.TextBox();
            this.lb_BreedID = new System.Windows.Forms.Label();
            this.dGV_Breed = new System.Windows.Forms.DataGridView();
            this.ccPetBreed_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPetBreed_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPetType_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPetType_DesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpType = new System.Windows.Forms.TabPage();
            this.dGV_Type = new System.Windows.Forms.DataGridView();
            this.ccPT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPetType_Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.bt_DelType = new System.Windows.Forms.Button();
            this.bt_LoadType = new System.Windows.Forms.Button();
            this.bt_EditType = new System.Windows.Forms.Button();
            this.bt_AddType = new System.Windows.Forms.Button();
            this.txb_TypeName = new System.Windows.Forms.TextBox();
            this.lb_TypeID = new System.Windows.Forms.Label();
            this.txb_TypeID = new System.Windows.Forms.TextBox();
            this.lb_TypeName = new System.Windows.Forms.Label();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlBreedType.SuspendLayout();
            this.tpBreed.SuspendLayout();
            this.gBoxBreed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Breed)).BeginInit();
            this.tpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Type)).BeginInit();
            this.gBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBreedType
            // 
            this.tabControlBreedType.Controls.Add(this.tpBreed);
            this.tabControlBreedType.Controls.Add(this.tpType);
            this.tabControlBreedType.Location = new System.Drawing.Point(13, 13);
            this.tabControlBreedType.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlBreedType.Name = "tabControlBreedType";
            this.tabControlBreedType.SelectedIndex = 0;
            this.tabControlBreedType.Size = new System.Drawing.Size(688, 646);
            this.tabControlBreedType.TabIndex = 0;
            // 
            // tpBreed
            // 
            this.tpBreed.Controls.Add(this.gBoxBreed);
            this.tpBreed.Controls.Add(this.dGV_Breed);
            this.tpBreed.Location = new System.Drawing.Point(4, 27);
            this.tpBreed.Margin = new System.Windows.Forms.Padding(4);
            this.tpBreed.Name = "tpBreed";
            this.tpBreed.Padding = new System.Windows.Forms.Padding(4);
            this.tpBreed.Size = new System.Drawing.Size(680, 615);
            this.tpBreed.TabIndex = 0;
            this.tpBreed.Text = "พันธุ์";
            this.tpBreed.UseVisualStyleBackColor = true;
            // 
            // gBoxBreed
            // 
            this.gBoxBreed.Controls.Add(this.bt_DelBreed);
            this.gBoxBreed.Controls.Add(this.Bt_LoadBreed);
            this.gBoxBreed.Controls.Add(this.bt_EditBreed);
            this.gBoxBreed.Controls.Add(this.bt_AddBreed);
            this.gBoxBreed.Controls.Add(this.cb_Type);
            this.gBoxBreed.Controls.Add(this.lb_cbType);
            this.gBoxBreed.Controls.Add(this.txb_BreedName);
            this.gBoxBreed.Controls.Add(this.lb_BreedName);
            this.gBoxBreed.Controls.Add(this.txb_BreedID);
            this.gBoxBreed.Controls.Add(this.lb_BreedID);
            this.gBoxBreed.Location = new System.Drawing.Point(8, 8);
            this.gBoxBreed.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxBreed.Name = "gBoxBreed";
            this.gBoxBreed.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxBreed.Size = new System.Drawing.Size(664, 208);
            this.gBoxBreed.TabIndex = 0;
            this.gBoxBreed.TabStop = false;
            this.gBoxBreed.Text = "รายละเอียด";
            // 
            // bt_DelBreed
            // 
            this.bt_DelBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelBreed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_DelBreed.Location = new System.Drawing.Point(283, 134);
            this.bt_DelBreed.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DelBreed.Name = "bt_DelBreed";
            this.bt_DelBreed.Size = new System.Drawing.Size(70, 32);
            this.bt_DelBreed.TabIndex = 6;
            this.bt_DelBreed.Text = "ลบ";
            this.bt_DelBreed.UseVisualStyleBackColor = true;
            this.bt_DelBreed.Click += new System.EventHandler(this.bt_DelBreed_Click);
            // 
            // Bt_LoadBreed
            // 
            this.Bt_LoadBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_LoadBreed.Location = new System.Drawing.Point(291, 53);
            this.Bt_LoadBreed.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_LoadBreed.Name = "Bt_LoadBreed";
            this.Bt_LoadBreed.Size = new System.Drawing.Size(100, 32);
            this.Bt_LoadBreed.TabIndex = 7;
            this.Bt_LoadBreed.Text = "LoadBreed";
            this.Bt_LoadBreed.UseVisualStyleBackColor = true;
            this.Bt_LoadBreed.Visible = false;
            this.Bt_LoadBreed.Click += new System.EventHandler(this.Bt_LoadBreed_Click);
            // 
            // bt_EditBreed
            // 
            this.bt_EditBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditBreed.Location = new System.Drawing.Point(205, 134);
            this.bt_EditBreed.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditBreed.Name = "bt_EditBreed";
            this.bt_EditBreed.Size = new System.Drawing.Size(70, 32);
            this.bt_EditBreed.TabIndex = 5;
            this.bt_EditBreed.Text = "แก้ไข";
            this.bt_EditBreed.UseVisualStyleBackColor = true;
            this.bt_EditBreed.Click += new System.EventHandler(this.bt_EditBreed_Click);
            // 
            // bt_AddBreed
            // 
            this.bt_AddBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddBreed.Location = new System.Drawing.Point(127, 134);
            this.bt_AddBreed.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddBreed.Name = "bt_AddBreed";
            this.bt_AddBreed.Size = new System.Drawing.Size(70, 32);
            this.bt_AddBreed.TabIndex = 4;
            this.bt_AddBreed.Text = "เพิ่ม";
            this.bt_AddBreed.UseVisualStyleBackColor = true;
            this.bt_AddBreed.Click += new System.EventHandler(this.bt_AddBreed_Click);
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(127, 62);
            this.cb_Type.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(132, 26);
            this.cb_Type.TabIndex = 2;
            this.cb_Type.SelectionChangeCommitted += new System.EventHandler(this.cb_Type_SelectionChangeCommitted);
            // 
            // lb_cbType
            // 
            this.lb_cbType.AutoSize = true;
            this.lb_cbType.Location = new System.Drawing.Point(35, 66);
            this.lb_cbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cbType.Name = "lb_cbType";
            this.lb_cbType.Size = new System.Drawing.Size(80, 18);
            this.lb_cbType.TabIndex = 4;
            this.lb_cbType.Text = "ประเภทสัตว์";
            // 
            // txb_BreedName
            // 
            this.txb_BreedName.Location = new System.Drawing.Point(127, 100);
            this.txb_BreedName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BreedName.MaxLength = 100;
            this.txb_BreedName.Name = "txb_BreedName";
            this.txb_BreedName.Size = new System.Drawing.Size(263, 26);
            this.txb_BreedName.TabIndex = 3;
            this.txb_BreedName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_BreedName_KeyDown);
            // 
            // lb_BreedName
            // 
            this.lb_BreedName.AutoSize = true;
            this.lb_BreedName.Location = new System.Drawing.Point(35, 100);
            this.lb_BreedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BreedName.Name = "lb_BreedName";
            this.lb_BreedName.Size = new System.Drawing.Size(62, 18);
            this.lb_BreedName.TabIndex = 2;
            this.lb_BreedName.Text = "ชื่อพันธุ์*";
            // 
            // txb_BreedID
            // 
            this.txb_BreedID.Enabled = false;
            this.txb_BreedID.Location = new System.Drawing.Point(127, 26);
            this.txb_BreedID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BreedID.Name = "txb_BreedID";
            this.txb_BreedID.Size = new System.Drawing.Size(132, 26);
            this.txb_BreedID.TabIndex = 1;
            // 
            // lb_BreedID
            // 
            this.lb_BreedID.AutoSize = true;
            this.lb_BreedID.Location = new System.Drawing.Point(35, 30);
            this.lb_BreedID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BreedID.Name = "lb_BreedID";
            this.lb_BreedID.Size = new System.Drawing.Size(61, 18);
            this.lb_BreedID.TabIndex = 0;
            this.lb_BreedID.Text = "รหัสพันธุ์";
            // 
            // dGV_Breed
            // 
            this.dGV_Breed.AllowUserToAddRows = false;
            this.dGV_Breed.AllowUserToDeleteRows = false;
            this.dGV_Breed.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_Breed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Breed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccPetBreed_ID,
            this.ccPetBreed_Des,
            this.ccPetType_ID,
            this.ccPetType_DesID});
            this.dGV_Breed.Location = new System.Drawing.Point(8, 224);
            this.dGV_Breed.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Breed.MultiSelect = false;
            this.dGV_Breed.Name = "dGV_Breed";
            this.dGV_Breed.ReadOnly = true;
            this.dGV_Breed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Breed.Size = new System.Drawing.Size(664, 383);
            this.dGV_Breed.TabIndex = 2;
            this.dGV_Breed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Breed_CellClick);
            // 
            // ccPetBreed_ID
            // 
            this.ccPetBreed_ID.DataPropertyName = "PetBreed_ID";
            this.ccPetBreed_ID.HeaderText = "รหัสพันธุ์";
            this.ccPetBreed_ID.Name = "ccPetBreed_ID";
            this.ccPetBreed_ID.ReadOnly = true;
            // 
            // ccPetBreed_Des
            // 
            this.ccPetBreed_Des.DataPropertyName = "PetBreed_Des";
            this.ccPetBreed_Des.HeaderText = "ชื่อพันธุ์";
            this.ccPetBreed_Des.Name = "ccPetBreed_Des";
            this.ccPetBreed_Des.ReadOnly = true;
            // 
            // ccPetType_ID
            // 
            this.ccPetType_ID.DataPropertyName = "PetType_ID";
            this.ccPetType_ID.HeaderText = "รหัสประเภท";
            this.ccPetType_ID.Name = "ccPetType_ID";
            this.ccPetType_ID.ReadOnly = true;
            this.ccPetType_ID.Visible = false;
            // 
            // ccPetType_DesID
            // 
            this.ccPetType_DesID.DataPropertyName = "PetType_Des";
            this.ccPetType_DesID.HeaderText = "ประเภท";
            this.ccPetType_DesID.Name = "ccPetType_DesID";
            this.ccPetType_DesID.ReadOnly = true;
            // 
            // tpType
            // 
            this.tpType.Controls.Add(this.dGV_Type);
            this.tpType.Controls.Add(this.gBoxType);
            this.tpType.Location = new System.Drawing.Point(4, 27);
            this.tpType.Margin = new System.Windows.Forms.Padding(4);
            this.tpType.Name = "tpType";
            this.tpType.Padding = new System.Windows.Forms.Padding(4);
            this.tpType.Size = new System.Drawing.Size(680, 615);
            this.tpType.TabIndex = 1;
            this.tpType.Text = "ประเภท";
            this.tpType.UseVisualStyleBackColor = true;
            // 
            // dGV_Type
            // 
            this.dGV_Type.AllowUserToAddRows = false;
            this.dGV_Type.AllowUserToDeleteRows = false;
            this.dGV_Type.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_Type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Type.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccPT_ID,
            this.ccPetType_Des});
            this.dGV_Type.Location = new System.Drawing.Point(8, 224);
            this.dGV_Type.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Type.MultiSelect = false;
            this.dGV_Type.Name = "dGV_Type";
            this.dGV_Type.ReadOnly = true;
            this.dGV_Type.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Type.Size = new System.Drawing.Size(664, 383);
            this.dGV_Type.TabIndex = 1;
            this.dGV_Type.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Type_CellClick);
            // 
            // ccPT_ID
            // 
            this.ccPT_ID.DataPropertyName = "PetType_ID";
            this.ccPT_ID.HeaderText = "รหัสพันธุ์";
            this.ccPT_ID.Name = "ccPT_ID";
            this.ccPT_ID.ReadOnly = true;
            // 
            // ccPetType_Des
            // 
            this.ccPetType_Des.DataPropertyName = "PetType_Des";
            this.ccPetType_Des.HeaderText = "ชื่อประเภท";
            this.ccPetType_Des.Name = "ccPetType_Des";
            this.ccPetType_Des.ReadOnly = true;
            // 
            // gBoxType
            // 
            this.gBoxType.Controls.Add(this.bt_DelType);
            this.gBoxType.Controls.Add(this.bt_LoadType);
            this.gBoxType.Controls.Add(this.bt_EditType);
            this.gBoxType.Controls.Add(this.bt_AddType);
            this.gBoxType.Controls.Add(this.txb_TypeName);
            this.gBoxType.Controls.Add(this.lb_TypeID);
            this.gBoxType.Controls.Add(this.txb_TypeID);
            this.gBoxType.Controls.Add(this.lb_TypeName);
            this.gBoxType.Location = new System.Drawing.Point(8, 8);
            this.gBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxType.Name = "gBoxType";
            this.gBoxType.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxType.Size = new System.Drawing.Size(664, 208);
            this.gBoxType.TabIndex = 0;
            this.gBoxType.TabStop = false;
            this.gBoxType.Text = "รายละเอียด";
            // 
            // bt_DelType
            // 
            this.bt_DelType.Enabled = false;
            this.bt_DelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_DelType.Location = new System.Drawing.Point(307, 98);
            this.bt_DelType.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DelType.Name = "bt_DelType";
            this.bt_DelType.Size = new System.Drawing.Size(70, 32);
            this.bt_DelType.TabIndex = 4;
            this.bt_DelType.Text = "ลบ";
            this.bt_DelType.UseVisualStyleBackColor = true;
            this.bt_DelType.Click += new System.EventHandler(this.bt_DelType_Click);
            // 
            // bt_LoadType
            // 
            this.bt_LoadType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoadType.Location = new System.Drawing.Point(279, 24);
            this.bt_LoadType.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadType.Name = "bt_LoadType";
            this.bt_LoadType.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadType.TabIndex = 5;
            this.bt_LoadType.Text = "LoadType";
            this.bt_LoadType.UseVisualStyleBackColor = true;
            this.bt_LoadType.Visible = false;
            this.bt_LoadType.Click += new System.EventHandler(this.bt_LoadType_Click);
            // 
            // bt_EditType
            // 
            this.bt_EditType.Enabled = false;
            this.bt_EditType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditType.Location = new System.Drawing.Point(229, 98);
            this.bt_EditType.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditType.Name = "bt_EditType";
            this.bt_EditType.Size = new System.Drawing.Size(70, 32);
            this.bt_EditType.TabIndex = 3;
            this.bt_EditType.Text = "แก้ไข";
            this.bt_EditType.UseVisualStyleBackColor = true;
            this.bt_EditType.Click += new System.EventHandler(this.bt_EditType_Click);
            // 
            // bt_AddType
            // 
            this.bt_AddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddType.Location = new System.Drawing.Point(151, 98);
            this.bt_AddType.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddType.Name = "bt_AddType";
            this.bt_AddType.Size = new System.Drawing.Size(70, 32);
            this.bt_AddType.TabIndex = 2;
            this.bt_AddType.Text = "เพิ่ม";
            this.bt_AddType.UseVisualStyleBackColor = true;
            this.bt_AddType.Click += new System.EventHandler(this.bt_AddType_Click);
            // 
            // txb_TypeName
            // 
            this.txb_TypeName.Location = new System.Drawing.Point(152, 64);
            this.txb_TypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TypeName.MaxLength = 100;
            this.txb_TypeName.Name = "txb_TypeName";
            this.txb_TypeName.Size = new System.Drawing.Size(263, 26);
            this.txb_TypeName.TabIndex = 1;
            this.txb_TypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_TypeName_KeyDown);
            // 
            // lb_TypeID
            // 
            this.lb_TypeID.AutoSize = true;
            this.lb_TypeID.Location = new System.Drawing.Point(35, 30);
            this.lb_TypeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TypeID.Name = "lb_TypeID";
            this.lb_TypeID.Size = new System.Drawing.Size(105, 18);
            this.lb_TypeID.TabIndex = 8;
            this.lb_TypeID.Text = "รหัสประเภทสัตว์";
            // 
            // txb_TypeID
            // 
            this.txb_TypeID.Enabled = false;
            this.txb_TypeID.Location = new System.Drawing.Point(152, 26);
            this.txb_TypeID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TypeID.Name = "txb_TypeID";
            this.txb_TypeID.Size = new System.Drawing.Size(119, 26);
            this.txb_TypeID.TabIndex = 0;
            this.txb_TypeID.TextChanged += new System.EventHandler(this.txb_TypeID_TextChanged);
            // 
            // lb_TypeName
            // 
            this.lb_TypeName.AutoSize = true;
            this.lb_TypeName.Location = new System.Drawing.Point(85, 67);
            this.lb_TypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TypeName.Name = "lb_TypeName";
            this.lb_TypeName.Size = new System.Drawing.Size(63, 18);
            this.lb_TypeName.TabIndex = 6;
            this.lb_TypeName.Text = "ประเภท*";
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // FrmMM14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 672);
            this.Controls.Add(this.tabControlBreedType);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMM14";
            this.Text = "ตั้งค่า พันธุ์";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM13_Load);
            this.tabControlBreedType.ResumeLayout(false);
            this.tpBreed.ResumeLayout(false);
            this.gBoxBreed.ResumeLayout(false);
            this.gBoxBreed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Breed)).EndInit();
            this.tpType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Type)).EndInit();
            this.gBoxType.ResumeLayout(false);
            this.gBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBreedType;
        private System.Windows.Forms.TabPage tpBreed;
        private System.Windows.Forms.GroupBox gBoxBreed;
        private System.Windows.Forms.Button Bt_LoadBreed;
        private System.Windows.Forms.Button bt_EditBreed;
        private System.Windows.Forms.Button bt_AddBreed;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Label lb_cbType;
        private System.Windows.Forms.TextBox txb_BreedName;
        private System.Windows.Forms.Label lb_BreedName;
        private System.Windows.Forms.TextBox txb_BreedID;
        private System.Windows.Forms.Label lb_BreedID;
        private System.Windows.Forms.DataGridView dGV_Breed;
        private System.Windows.Forms.TabPage tpType;
        private System.Windows.Forms.DataGridView dGV_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPetType_Des;
        private System.Windows.Forms.GroupBox gBoxType;
        private System.Windows.Forms.Button bt_LoadType;
        private System.Windows.Forms.Button bt_EditType;
        private System.Windows.Forms.Button bt_AddType;
        private System.Windows.Forms.TextBox txb_TypeName;
        private System.Windows.Forms.Label lb_TypeID;
        private System.Windows.Forms.TextBox txb_TypeID;
        private System.Windows.Forms.Label lb_TypeName;
        private System.Windows.Forms.Button bt_DelBreed;
        private System.Windows.Forms.Button bt_DelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPetBreed_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPetBreed_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPetType_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPetType_DesID;
        private System.Windows.Forms.ErrorProvider epCheck;


    }
}