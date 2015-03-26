namespace Petshop
{
    partial class FrmMM15
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
            this.tabControlEmployee = new System.Windows.Forms.TabControl();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.gBoxEmployee = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_LoadEP = new System.Windows.Forms.Button();
            this.bt_EditEm = new System.Windows.Forms.Button();
            this.bt_AddEm = new System.Windows.Forms.Button();
            this.gBoxIDPass = new System.Windows.Forms.GroupBox();
            this.txb_Pwd = new System.Windows.Forms.TextBox();
            this.lb_Pwd = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.cb_EmPosition = new System.Windows.Forms.ComboBox();
            this.lb_EmName = new System.Windows.Forms.Label();
            this.txb_EmName = new System.Windows.Forms.TextBox();
            this.lb_cbPosition = new System.Windows.Forms.Label();
            this.txb_EmID = new System.Windows.Forms.TextBox();
            this.lb_EmID = new System.Windows.Forms.Label();
            this.dGV_Ep = new System.Windows.Forms.DataGridView();
            this.ccEm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEmPosition_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPosition = new System.Windows.Forms.TabPage();
            this.dGV_PS = new System.Windows.Forms.DataGridView();
            this.ccEP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxPosition = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_LoadPS = new System.Windows.Forms.Button();
            this.bt_EditEmposition = new System.Windows.Forms.Button();
            this.bt_AddEmPosition = new System.Windows.Forms.Button();
            this.txb_Emposition = new System.Windows.Forms.TextBox();
            this.lb_PositionID = new System.Windows.Forms.Label();
            this.txb_EmpositionID = new System.Windows.Forms.TextBox();
            this.lb_EmPosition = new System.Windows.Forms.Label();
            this.tabControlEmployee.SuspendLayout();
            this.tpEmployee.SuspendLayout();
            this.gBoxEmployee.SuspendLayout();
            this.gBoxIDPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ep)).BeginInit();
            this.tpPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PS)).BeginInit();
            this.gBoxPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEmployee
            // 
            this.tabControlEmployee.Controls.Add(this.tpEmployee);
            this.tabControlEmployee.Controls.Add(this.tpPosition);
            this.tabControlEmployee.Location = new System.Drawing.Point(13, 13);
            this.tabControlEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlEmployee.Name = "tabControlEmployee";
            this.tabControlEmployee.SelectedIndex = 0;
            this.tabControlEmployee.Size = new System.Drawing.Size(869, 646);
            this.tabControlEmployee.TabIndex = 0;
            // 
            // tpEmployee
            // 
            this.tpEmployee.Controls.Add(this.gBoxEmployee);
            this.tpEmployee.Controls.Add(this.dGV_Ep);
            this.tpEmployee.Location = new System.Drawing.Point(4, 27);
            this.tpEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tpEmployee.Name = "tpEmployee";
            this.tpEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.tpEmployee.Size = new System.Drawing.Size(861, 615);
            this.tpEmployee.TabIndex = 0;
            this.tpEmployee.Text = "เจ้าหน้าที่";
            this.tpEmployee.UseVisualStyleBackColor = true;
            // 
            // gBoxEmployee
            // 
            this.gBoxEmployee.Controls.Add(this.button1);
            this.gBoxEmployee.Controls.Add(this.bt_LoadEP);
            this.gBoxEmployee.Controls.Add(this.bt_EditEm);
            this.gBoxEmployee.Controls.Add(this.bt_AddEm);
            this.gBoxEmployee.Controls.Add(this.gBoxIDPass);
            this.gBoxEmployee.Controls.Add(this.cb_EmPosition);
            this.gBoxEmployee.Controls.Add(this.lb_EmName);
            this.gBoxEmployee.Controls.Add(this.txb_EmName);
            this.gBoxEmployee.Controls.Add(this.lb_cbPosition);
            this.gBoxEmployee.Controls.Add(this.txb_EmID);
            this.gBoxEmployee.Controls.Add(this.lb_EmID);
            this.gBoxEmployee.Location = new System.Drawing.Point(8, 8);
            this.gBoxEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxEmployee.Name = "gBoxEmployee";
            this.gBoxEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxEmployee.Size = new System.Drawing.Size(845, 206);
            this.gBoxEmployee.TabIndex = 1;
            this.gBoxEmployee.TabStop = false;
            this.gBoxEmployee.Text = "รายละเอียด";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(283, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "ลบ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_LoadEP
            // 
            this.bt_LoadEP.Location = new System.Drawing.Point(267, 95);
            this.bt_LoadEP.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadEP.Name = "bt_LoadEP";
            this.bt_LoadEP.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadEP.TabIndex = 3;
            this.bt_LoadEP.Text = "LoadEP";
            this.bt_LoadEP.UseVisualStyleBackColor = true;
            this.bt_LoadEP.Visible = false;
            this.bt_LoadEP.Click += new System.EventHandler(this.Bt_LoadEP_Click);
            // 
            // bt_EditEm
            // 
            this.bt_EditEm.Location = new System.Drawing.Point(205, 136);
            this.bt_EditEm.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditEm.Name = "bt_EditEm";
            this.bt_EditEm.Size = new System.Drawing.Size(70, 32);
            this.bt_EditEm.TabIndex = 2;
            this.bt_EditEm.Text = "แก้ไข";
            this.bt_EditEm.UseVisualStyleBackColor = true;
            this.bt_EditEm.Click += new System.EventHandler(this.bt_EditEm_Click);
            // 
            // bt_AddEm
            // 
            this.bt_AddEm.Location = new System.Drawing.Point(127, 136);
            this.bt_AddEm.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddEm.Name = "bt_AddEm";
            this.bt_AddEm.Size = new System.Drawing.Size(70, 32);
            this.bt_AddEm.TabIndex = 1;
            this.bt_AddEm.Text = "เพิ่ม";
            this.bt_AddEm.UseVisualStyleBackColor = true;
            this.bt_AddEm.Click += new System.EventHandler(this.bt_AddEm_Click);
            // 
            // gBoxIDPass
            // 
            this.gBoxIDPass.Controls.Add(this.txb_Pwd);
            this.gBoxIDPass.Controls.Add(this.lb_Pwd);
            this.gBoxIDPass.Controls.Add(this.txb_UserName);
            this.gBoxIDPass.Controls.Add(this.lb_User);
            this.gBoxIDPass.Location = new System.Drawing.Point(420, 26);
            this.gBoxIDPass.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxIDPass.Name = "gBoxIDPass";
            this.gBoxIDPass.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxIDPass.Size = new System.Drawing.Size(417, 159);
            this.gBoxIDPass.TabIndex = 0;
            this.gBoxIDPass.TabStop = false;
            this.gBoxIDPass.Text = "รายละเอียดเข้าระบบ";
            // 
            // txb_Pwd
            // 
            this.txb_Pwd.Location = new System.Drawing.Point(127, 82);
            this.txb_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Pwd.Name = "txb_Pwd";
            this.txb_Pwd.Size = new System.Drawing.Size(263, 26);
            this.txb_Pwd.TabIndex = 1;
            this.txb_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Pwd_KeyDown);
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.AutoSize = true;
            this.lb_Pwd.Location = new System.Drawing.Point(48, 86);
            this.lb_Pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(69, 18);
            this.lb_Pwd.TabIndex = 4;
            this.lb_Pwd.Text = "Password";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(127, 46);
            this.txb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserName.MaxLength = 32;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(263, 26);
            this.txb_UserName.TabIndex = 0;
            this.txb_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_UserName_KeyDown);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(45, 50);
            this.lb_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(75, 18);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "Username";
            // 
            // cb_EmPosition
            // 
            this.cb_EmPosition.FormattingEnabled = true;
            this.cb_EmPosition.Location = new System.Drawing.Point(127, 98);
            this.cb_EmPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cb_EmPosition.Name = "cb_EmPosition";
            this.cb_EmPosition.Size = new System.Drawing.Size(132, 26);
            this.cb_EmPosition.TabIndex = 2;
            this.cb_EmPosition.SelectionChangeCommitted += new System.EventHandler(this.cb_EmPosition_SelectionChangeCommitted);
            // 
            // lb_EmName
            // 
            this.lb_EmName.AutoSize = true;
            this.lb_EmName.Location = new System.Drawing.Point(35, 66);
            this.lb_EmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmName.Name = "lb_EmName";
            this.lb_EmName.Size = new System.Drawing.Size(83, 18);
            this.lb_EmName.TabIndex = 4;
            this.lb_EmName.Text = "ชื่อเจ้าหน้าที่";
            // 
            // txb_EmName
            // 
            this.txb_EmName.Location = new System.Drawing.Point(127, 62);
            this.txb_EmName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_EmName.MaxLength = 100;
            this.txb_EmName.Name = "txb_EmName";
            this.txb_EmName.Size = new System.Drawing.Size(263, 26);
            this.txb_EmName.TabIndex = 1;
            this.txb_EmName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_EmName_KeyDown);
            // 
            // lb_cbPosition
            // 
            this.lb_cbPosition.AutoSize = true;
            this.lb_cbPosition.Location = new System.Drawing.Point(56, 102);
            this.lb_cbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cbPosition.Name = "lb_cbPosition";
            this.lb_cbPosition.Size = new System.Drawing.Size(59, 18);
            this.lb_cbPosition.TabIndex = 2;
            this.lb_cbPosition.Text = "ตำแหน่ง";
            // 
            // txb_EmID
            // 
            this.txb_EmID.Location = new System.Drawing.Point(127, 26);
            this.txb_EmID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_EmID.MaxLength = 13;
            this.txb_EmID.Name = "txb_EmID";
            this.txb_EmID.Size = new System.Drawing.Size(207, 26);
            this.txb_EmID.TabIndex = 0;
            this.txb_EmID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_EmID_KeyDown);
            // 
            // lb_EmID
            // 
            this.lb_EmID.AutoSize = true;
            this.lb_EmID.Location = new System.Drawing.Point(27, 30);
            this.lb_EmID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmID.Name = "lb_EmID";
            this.lb_EmID.Size = new System.Drawing.Size(90, 18);
            this.lb_EmID.TabIndex = 0;
            this.lb_EmID.Text = "รหัสเจ้าหน้าที่";
            // 
            // dGV_Ep
            // 
            this.dGV_Ep.AllowUserToAddRows = false;
            this.dGV_Ep.AllowUserToDeleteRows = false;
            this.dGV_Ep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Ep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccEm_ID,
            this.ccEm_Name,
            this.ccPosition,
            this.ccEm_User,
            this.ccEm_Pwd,
            this.ccEmPosition_ID});
            this.dGV_Ep.Location = new System.Drawing.Point(8, 222);
            this.dGV_Ep.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Ep.MultiSelect = false;
            this.dGV_Ep.Name = "dGV_Ep";
            this.dGV_Ep.ReadOnly = true;
            this.dGV_Ep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Ep.Size = new System.Drawing.Size(845, 385);
            this.dGV_Ep.TabIndex = 1;
            this.dGV_Ep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Ep_CellClick);
            // 
            // ccEm_ID
            // 
            this.ccEm_ID.DataPropertyName = "Em_ID";
            this.ccEm_ID.HeaderText = "รหัส";
            this.ccEm_ID.Name = "ccEm_ID";
            this.ccEm_ID.ReadOnly = true;
            // 
            // ccEm_Name
            // 
            this.ccEm_Name.DataPropertyName = "Em_Name";
            this.ccEm_Name.HeaderText = "ชื่อ";
            this.ccEm_Name.Name = "ccEm_Name";
            this.ccEm_Name.ReadOnly = true;
            // 
            // ccPosition
            // 
            this.ccPosition.DataPropertyName = "Em_Position";
            this.ccPosition.HeaderText = "ตำแหน่ง";
            this.ccPosition.Name = "ccPosition";
            this.ccPosition.ReadOnly = true;
            // 
            // ccEm_User
            // 
            this.ccEm_User.DataPropertyName = "Em_User";
            this.ccEm_User.HeaderText = "Username";
            this.ccEm_User.Name = "ccEm_User";
            this.ccEm_User.ReadOnly = true;
            // 
            // ccEm_Pwd
            // 
            this.ccEm_Pwd.DataPropertyName = "Em_Pwd";
            this.ccEm_Pwd.HeaderText = "Password";
            this.ccEm_Pwd.Name = "ccEm_Pwd";
            this.ccEm_Pwd.ReadOnly = true;
            this.ccEm_Pwd.Visible = false;
            // 
            // ccEmPosition_ID
            // 
            this.ccEmPosition_ID.DataPropertyName = "EmPosition_ID";
            this.ccEmPosition_ID.HeaderText = "รหัสตำแหน่งพนักงาน";
            this.ccEmPosition_ID.Name = "ccEmPosition_ID";
            this.ccEmPosition_ID.ReadOnly = true;
            this.ccEmPosition_ID.Visible = false;
            this.ccEmPosition_ID.Width = 150;
            // 
            // tpPosition
            // 
            this.tpPosition.Controls.Add(this.dGV_PS);
            this.tpPosition.Controls.Add(this.gBoxPosition);
            this.tpPosition.Location = new System.Drawing.Point(4, 27);
            this.tpPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tpPosition.Name = "tpPosition";
            this.tpPosition.Padding = new System.Windows.Forms.Padding(4);
            this.tpPosition.Size = new System.Drawing.Size(861, 615);
            this.tpPosition.TabIndex = 1;
            this.tpPosition.Text = "ตำแหน่ง";
            this.tpPosition.UseVisualStyleBackColor = true;
            // 
            // dGV_PS
            // 
            this.dGV_PS.AllowUserToAddRows = false;
            this.dGV_PS.AllowUserToDeleteRows = false;
            this.dGV_PS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_PS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccEP_ID,
            this.ccEm_Position});
            this.dGV_PS.Location = new System.Drawing.Point(8, 186);
            this.dGV_PS.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_PS.MultiSelect = false;
            this.dGV_PS.Name = "dGV_PS";
            this.dGV_PS.ReadOnly = true;
            this.dGV_PS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_PS.Size = new System.Drawing.Size(432, 421);
            this.dGV_PS.TabIndex = 1;
            this.dGV_PS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_PS_CellClick);
            // 
            // ccEP_ID
            // 
            this.ccEP_ID.DataPropertyName = "EmPosition_ID";
            this.ccEP_ID.HeaderText = "รหัสตำแหน่ง";
            this.ccEP_ID.Name = "ccEP_ID";
            this.ccEP_ID.ReadOnly = true;
            this.ccEP_ID.Width = 120;
            // 
            // ccEm_Position
            // 
            this.ccEm_Position.DataPropertyName = "Em_Position";
            this.ccEm_Position.HeaderText = "ตำแหน่ง";
            this.ccEm_Position.Name = "ccEm_Position";
            this.ccEm_Position.ReadOnly = true;
            // 
            // gBoxPosition
            // 
            this.gBoxPosition.Controls.Add(this.button2);
            this.gBoxPosition.Controls.Add(this.bt_LoadPS);
            this.gBoxPosition.Controls.Add(this.bt_EditEmposition);
            this.gBoxPosition.Controls.Add(this.bt_AddEmPosition);
            this.gBoxPosition.Controls.Add(this.txb_Emposition);
            this.gBoxPosition.Controls.Add(this.lb_PositionID);
            this.gBoxPosition.Controls.Add(this.txb_EmpositionID);
            this.gBoxPosition.Controls.Add(this.lb_EmPosition);
            this.gBoxPosition.Location = new System.Drawing.Point(8, 8);
            this.gBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxPosition.Name = "gBoxPosition";
            this.gBoxPosition.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxPosition.Size = new System.Drawing.Size(432, 170);
            this.gBoxPosition.TabIndex = 0;
            this.gBoxPosition.TabStop = false;
            this.gBoxPosition.Text = "รายละเอียด";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(308, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "ลบ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_LoadPS
            // 
            this.bt_LoadPS.Location = new System.Drawing.Point(289, 24);
            this.bt_LoadPS.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadPS.Name = "bt_LoadPS";
            this.bt_LoadPS.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadPS.TabIndex = 4;
            this.bt_LoadPS.Text = "LoadPS";
            this.bt_LoadPS.UseVisualStyleBackColor = true;
            this.bt_LoadPS.Click += new System.EventHandler(this.bt_LoadPS_Click);
            // 
            // bt_EditEmposition
            // 
            this.bt_EditEmposition.Location = new System.Drawing.Point(230, 112);
            this.bt_EditEmposition.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditEmposition.Name = "bt_EditEmposition";
            this.bt_EditEmposition.Size = new System.Drawing.Size(70, 32);
            this.bt_EditEmposition.TabIndex = 3;
            this.bt_EditEmposition.Text = "แก้ไข";
            this.bt_EditEmposition.UseVisualStyleBackColor = true;
            this.bt_EditEmposition.Click += new System.EventHandler(this.bt_EditEmposition_Click);
            // 
            // bt_AddEmPosition
            // 
            this.bt_AddEmPosition.Location = new System.Drawing.Point(152, 112);
            this.bt_AddEmPosition.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddEmPosition.Name = "bt_AddEmPosition";
            this.bt_AddEmPosition.Size = new System.Drawing.Size(70, 32);
            this.bt_AddEmPosition.TabIndex = 2;
            this.bt_AddEmPosition.Text = "เพิ่ม";
            this.bt_AddEmPosition.UseVisualStyleBackColor = true;
            this.bt_AddEmPosition.Click += new System.EventHandler(this.bt_AddEmPosition_Click);
            // 
            // txb_Emposition
            // 
            this.txb_Emposition.Location = new System.Drawing.Point(161, 62);
            this.txb_Emposition.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Emposition.MaxLength = 50;
            this.txb_Emposition.Name = "txb_Emposition";
            this.txb_Emposition.Size = new System.Drawing.Size(253, 26);
            this.txb_Emposition.TabIndex = 1;
            this.txb_Emposition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Emposition_KeyDown);
            // 
            // lb_PositionID
            // 
            this.lb_PositionID.AutoSize = true;
            this.lb_PositionID.Location = new System.Drawing.Point(8, 30);
            this.lb_PositionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PositionID.Name = "lb_PositionID";
            this.lb_PositionID.Size = new System.Drawing.Size(141, 18);
            this.lb_PositionID.TabIndex = 8;
            this.lb_PositionID.Text = "รหัสตำแหน่งเจ้าหน้าที่";
            // 
            // txb_EmpositionID
            // 
            this.txb_EmpositionID.Enabled = false;
            this.txb_EmpositionID.Location = new System.Drawing.Point(161, 26);
            this.txb_EmpositionID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_EmpositionID.MaxLength = 3;
            this.txb_EmpositionID.Name = "txb_EmpositionID";
            this.txb_EmpositionID.Size = new System.Drawing.Size(119, 26);
            this.txb_EmpositionID.TabIndex = 0;
            // 
            // lb_EmPosition
            // 
            this.lb_EmPosition.AutoSize = true;
            this.lb_EmPosition.Location = new System.Drawing.Point(91, 66);
            this.lb_EmPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmPosition.Name = "lb_EmPosition";
            this.lb_EmPosition.Size = new System.Drawing.Size(59, 18);
            this.lb_EmPosition.TabIndex = 6;
            this.lb_EmPosition.Text = "ตำแหน่ง";
            // 
            // FrmMM15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 672);
            this.Controls.Add(this.tabControlEmployee);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMM15";
            this.Text = "ตั้งค่า พนักงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM14_Load);
            this.tabControlEmployee.ResumeLayout(false);
            this.tpEmployee.ResumeLayout(false);
            this.gBoxEmployee.ResumeLayout(false);
            this.gBoxEmployee.PerformLayout();
            this.gBoxIDPass.ResumeLayout(false);
            this.gBoxIDPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ep)).EndInit();
            this.tpPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PS)).EndInit();
            this.gBoxPosition.ResumeLayout(false);
            this.gBoxPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployee;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.GroupBox gBoxEmployee;
        private System.Windows.Forms.Button bt_LoadEP;
        private System.Windows.Forms.Button bt_EditEm;
        private System.Windows.Forms.Button bt_AddEm;
        private System.Windows.Forms.GroupBox gBoxIDPass;
        private System.Windows.Forms.TextBox txb_Pwd;
        private System.Windows.Forms.Label lb_Pwd;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.ComboBox cb_EmPosition;
        private System.Windows.Forms.Label lb_EmName;
        private System.Windows.Forms.TextBox txb_EmName;
        private System.Windows.Forms.Label lb_cbPosition;
        private System.Windows.Forms.TextBox txb_EmID;
        private System.Windows.Forms.Label lb_EmID;
        private System.Windows.Forms.DataGridView dGV_Ep;
        private System.Windows.Forms.TabPage tpPosition;
        private System.Windows.Forms.DataGridView dGV_PS;
        private System.Windows.Forms.GroupBox gBoxPosition;
        private System.Windows.Forms.Button bt_LoadPS;
        private System.Windows.Forms.Button bt_EditEmposition;
        private System.Windows.Forms.Button bt_AddEmPosition;
        private System.Windows.Forms.TextBox txb_Emposition;
        private System.Windows.Forms.Label lb_PositionID;
        private System.Windows.Forms.TextBox txb_EmpositionID;
        private System.Windows.Forms.Label lb_EmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEmPosition_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Position;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


    }
}