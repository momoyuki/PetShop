namespace Petshop
{
    partial class FrmSetting16
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlEmployee = new System.Windows.Forms.TabControl();
            this.tpEmployee = new System.Windows.Forms.TabPage();
            this.gBoxEmployee = new System.Windows.Forms.GroupBox();
            this.bt_Pwd = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.lb_EmAddr = new System.Windows.Forms.Label();
            this.bt_LoadEP = new System.Windows.Forms.Button();
            this.txb_EmAddr = new System.Windows.Forms.TextBox();
            this.lb_EmTel = new System.Windows.Forms.Label();
            this.txb_EmTel = new System.Windows.Forms.TextBox();
            this.lb_EmDOB = new System.Windows.Forms.Label();
            this.dTP_EmDOB = new System.Windows.Forms.DateTimePicker();
            this.rB_NotWork = new System.Windows.Forms.RadioButton();
            this.txb_Pwd = new System.Windows.Forms.TextBox();
            this.bt_EditEm = new System.Windows.Forms.Button();
            this.rB_Work = new System.Windows.Forms.RadioButton();
            this.bt_AddEm = new System.Windows.Forms.Button();
            this.lb_Pwd = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.cb_EmPosition = new System.Windows.Forms.ComboBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_EmName = new System.Windows.Forms.Label();
            this.txb_EmName = new System.Windows.Forms.TextBox();
            this.lb_cbPosition = new System.Windows.Forms.Label();
            this.txb_EmID = new System.Windows.Forms.TextBox();
            this.lb_EmID = new System.Windows.Forms.Label();
            this.dGV_Ep = new System.Windows.Forms.DataGridView();
            this.ccEm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEmPosition_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEmDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPosition = new System.Windows.Forms.TabPage();
            this.dGV_PS = new System.Windows.Forms.DataGridView();
            this.ccEP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccEm_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxPosition = new System.Windows.Forms.GroupBox();
            this.bt_ResetPosition = new System.Windows.Forms.Button();
            this.bt_DelPosition = new System.Windows.Forms.Button();
            this.bt_LoadPS = new System.Windows.Forms.Button();
            this.bt_EditEmposition = new System.Windows.Forms.Button();
            this.bt_AddEmPosition = new System.Windows.Forms.Button();
            this.txb_Emposition = new System.Windows.Forms.TextBox();
            this.lb_PositionID = new System.Windows.Forms.Label();
            this.txb_EmpositionID = new System.Windows.Forms.TextBox();
            this.lb_EmPosition = new System.Windows.Forms.Label();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlEmployee.SuspendLayout();
            this.tpEmployee.SuspendLayout();
            this.gBoxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ep)).BeginInit();
            this.tpPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PS)).BeginInit();
            this.gBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEmployee
            // 
            this.tabControlEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gBoxEmployee.Controls.Add(this.bt_Pwd);
            this.gBoxEmployee.Controls.Add(this.bt_Reset);
            this.gBoxEmployee.Controls.Add(this.lb_EmAddr);
            this.gBoxEmployee.Controls.Add(this.bt_LoadEP);
            this.gBoxEmployee.Controls.Add(this.txb_EmAddr);
            this.gBoxEmployee.Controls.Add(this.lb_EmTel);
            this.gBoxEmployee.Controls.Add(this.txb_EmTel);
            this.gBoxEmployee.Controls.Add(this.lb_EmDOB);
            this.gBoxEmployee.Controls.Add(this.dTP_EmDOB);
            this.gBoxEmployee.Controls.Add(this.rB_NotWork);
            this.gBoxEmployee.Controls.Add(this.txb_Pwd);
            this.gBoxEmployee.Controls.Add(this.bt_EditEm);
            this.gBoxEmployee.Controls.Add(this.rB_Work);
            this.gBoxEmployee.Controls.Add(this.bt_AddEm);
            this.gBoxEmployee.Controls.Add(this.lb_Pwd);
            this.gBoxEmployee.Controls.Add(this.txb_UserName);
            this.gBoxEmployee.Controls.Add(this.cb_EmPosition);
            this.gBoxEmployee.Controls.Add(this.lb_User);
            this.gBoxEmployee.Controls.Add(this.lb_EmName);
            this.gBoxEmployee.Controls.Add(this.txb_EmName);
            this.gBoxEmployee.Controls.Add(this.lb_cbPosition);
            this.gBoxEmployee.Controls.Add(this.txb_EmID);
            this.gBoxEmployee.Controls.Add(this.lb_EmID);
            this.gBoxEmployee.Location = new System.Drawing.Point(8, 8);
            this.gBoxEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxEmployee.Name = "gBoxEmployee";
            this.gBoxEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxEmployee.Size = new System.Drawing.Size(845, 234);
            this.gBoxEmployee.TabIndex = 0;
            this.gBoxEmployee.TabStop = false;
            this.gBoxEmployee.Text = "รายละเอียด";
            // 
            // bt_Pwd
            // 
            this.bt_Pwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Pwd.Location = new System.Drawing.Point(148, 202);
            this.bt_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Pwd.Name = "bt_Pwd";
            this.bt_Pwd.Size = new System.Drawing.Size(110, 32);
            this.bt_Pwd.TabIndex = 10;
            this.bt_Pwd.Text = "เปลี่ยนรหัสผ่าน";
            this.bt_Pwd.UseVisualStyleBackColor = true;
            this.bt_Pwd.Click += new System.EventHandler(this.bt_Pwd_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Reset.Location = new System.Drawing.Point(279, 23);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(70, 32);
            this.bt_Reset.TabIndex = 14;
            this.bt_Reset.Text = "เริ่มใหม่";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // lb_EmAddr
            // 
            this.lb_EmAddr.AutoSize = true;
            this.lb_EmAddr.Location = new System.Drawing.Point(465, 109);
            this.lb_EmAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmAddr.Name = "lb_EmAddr";
            this.lb_EmAddr.Size = new System.Drawing.Size(37, 18);
            this.lb_EmAddr.TabIndex = 13;
            this.lb_EmAddr.Text = "ที่อยู่";
            // 
            // bt_LoadEP
            // 
            this.bt_LoadEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoadEP.Location = new System.Drawing.Point(738, 194);
            this.bt_LoadEP.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadEP.Name = "bt_LoadEP";
            this.bt_LoadEP.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadEP.TabIndex = 13;
            this.bt_LoadEP.Text = "LoadEP";
            this.bt_LoadEP.UseVisualStyleBackColor = true;
            this.bt_LoadEP.Visible = false;
            this.bt_LoadEP.Click += new System.EventHandler(this.Bt_LoadEP_Click);
            // 
            // txb_EmAddr
            // 
            this.txb_EmAddr.Location = new System.Drawing.Point(510, 113);
            this.txb_EmAddr.Margin = new System.Windows.Forms.Padding(4);
            this.txb_EmAddr.MaxLength = 100;
            this.txb_EmAddr.Multiline = true;
            this.txb_EmAddr.Name = "txb_EmAddr";
            this.txb_EmAddr.Size = new System.Drawing.Size(263, 50);
            this.txb_EmAddr.TabIndex = 7;
            // 
            // lb_EmTel
            // 
            this.lb_EmTel.AutoSize = true;
            this.lb_EmTel.Location = new System.Drawing.Point(410, 72);
            this.lb_EmTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmTel.Name = "lb_EmTel";
            this.lb_EmTel.Size = new System.Drawing.Size(92, 18);
            this.lb_EmTel.TabIndex = 11;
            this.lb_EmTel.Text = "เบอร์โทรศัพท์";
            // 
            // txb_EmTel
            // 
            this.txb_EmTel.Location = new System.Drawing.Point(510, 69);
            this.txb_EmTel.Margin = new System.Windows.Forms.Padding(4);
            this.txb_EmTel.MaxLength = 100;
            this.txb_EmTel.Name = "txb_EmTel";
            this.txb_EmTel.Size = new System.Drawing.Size(200, 26);
            this.txb_EmTel.TabIndex = 6;
            // 
            // lb_EmDOB
            // 
            this.lb_EmDOB.AutoSize = true;
            this.lb_EmDOB.Location = new System.Drawing.Point(456, 41);
            this.lb_EmDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmDOB.Name = "lb_EmDOB";
            this.lb_EmDOB.Size = new System.Drawing.Size(47, 18);
            this.lb_EmDOB.TabIndex = 9;
            this.lb_EmDOB.Text = "วันเกิด";
            // 
            // dTP_EmDOB
            // 
            this.dTP_EmDOB.Location = new System.Drawing.Point(510, 37);
            this.dTP_EmDOB.Name = "dTP_EmDOB";
            this.dTP_EmDOB.Size = new System.Drawing.Size(200, 26);
            this.dTP_EmDOB.TabIndex = 5;
            // 
            // rB_NotWork
            // 
            this.rB_NotWork.AutoSize = true;
            this.rB_NotWork.Location = new System.Drawing.Point(524, 170);
            this.rB_NotWork.Name = "rB_NotWork";
            this.rB_NotWork.Size = new System.Drawing.Size(82, 22);
            this.rB_NotWork.TabIndex = 8;
            this.rB_NotWork.TabStop = true;
            this.rB_NotWork.Text = "0.ลาออก";
            this.rB_NotWork.UseVisualStyleBackColor = true;
            // 
            // txb_Pwd
            // 
            this.txb_Pwd.Location = new System.Drawing.Point(127, 168);
            this.txb_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Pwd.Name = "txb_Pwd";
            this.txb_Pwd.PasswordChar = '*';
            this.txb_Pwd.Size = new System.Drawing.Size(175, 26);
            this.txb_Pwd.TabIndex = 4;
            this.txb_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Pwd_KeyDown);
            // 
            // bt_EditEm
            // 
            this.bt_EditEm.Enabled = false;
            this.bt_EditEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_EditEm.Location = new System.Drawing.Point(414, 194);
            this.bt_EditEm.Margin = new System.Windows.Forms.Padding(4);
            this.bt_EditEm.Name = "bt_EditEm";
            this.bt_EditEm.Size = new System.Drawing.Size(70, 32);
            this.bt_EditEm.TabIndex = 12;
            this.bt_EditEm.Text = "แก้ไข";
            this.bt_EditEm.UseVisualStyleBackColor = true;
            this.bt_EditEm.Click += new System.EventHandler(this.bt_EditEm_Click);
            // 
            // rB_Work
            // 
            this.rB_Work.AutoSize = true;
            this.rB_Work.Location = new System.Drawing.Point(612, 170);
            this.rB_Work.Name = "rB_Work";
            this.rB_Work.Size = new System.Drawing.Size(98, 22);
            this.rB_Work.TabIndex = 9;
            this.rB_Work.TabStop = true;
            this.rB_Work.Text = "1.ทำงานอยู่";
            this.rB_Work.UseVisualStyleBackColor = true;
            // 
            // bt_AddEm
            // 
            this.bt_AddEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddEm.Location = new System.Drawing.Point(336, 194);
            this.bt_AddEm.Margin = new System.Windows.Forms.Padding(4);
            this.bt_AddEm.Name = "bt_AddEm";
            this.bt_AddEm.Size = new System.Drawing.Size(70, 32);
            this.bt_AddEm.TabIndex = 11;
            this.bt_AddEm.Text = "เพิ่ม";
            this.bt_AddEm.UseVisualStyleBackColor = true;
            this.bt_AddEm.Click += new System.EventHandler(this.bt_AddEm_Click);
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.AutoSize = true;
            this.lb_Pwd.Location = new System.Drawing.Point(48, 172);
            this.lb_Pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(69, 18);
            this.lb_Pwd.TabIndex = 4;
            this.lb_Pwd.Text = "Password";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(127, 132);
            this.txb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserName.MaxLength = 32;
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(175, 26);
            this.txb_UserName.TabIndex = 3;
            this.txb_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_UserName_KeyDown);
            // 
            // cb_EmPosition
            // 
            this.cb_EmPosition.FormattingEnabled = true;
            this.cb_EmPosition.Location = new System.Drawing.Point(127, 98);
            this.cb_EmPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cb_EmPosition.Name = "cb_EmPosition";
            this.cb_EmPosition.Size = new System.Drawing.Size(189, 26);
            this.cb_EmPosition.TabIndex = 2;
            this.cb_EmPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_EmPosition_KeyDown);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(45, 136);
            this.lb_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(75, 18);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "Username";
            // 
            // lb_EmName
            // 
            this.lb_EmName.AutoSize = true;
            this.lb_EmName.Location = new System.Drawing.Point(35, 66);
            this.lb_EmName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmName.Name = "lb_EmName";
            this.lb_EmName.Size = new System.Drawing.Size(91, 18);
            this.lb_EmName.TabIndex = 4;
            this.lb_EmName.Text = "ชื่อเจ้าหน้าที่*";
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
            this.txb_EmID.Size = new System.Drawing.Size(144, 26);
            this.txb_EmID.TabIndex = 0;
            this.txb_EmID.TextChanged += new System.EventHandler(this.txb_EmID_TextChanged);
            this.txb_EmID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_EmID_KeyDown);
            // 
            // lb_EmID
            // 
            this.lb_EmID.AutoSize = true;
            this.lb_EmID.Location = new System.Drawing.Point(27, 30);
            this.lb_EmID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmID.Name = "lb_EmID";
            this.lb_EmID.Size = new System.Drawing.Size(98, 18);
            this.lb_EmID.TabIndex = 0;
            this.lb_EmID.Text = "รหัสเจ้าหน้าที่*";
            // 
            // dGV_Ep
            // 
            this.dGV_Ep.AllowUserToAddRows = false;
            this.dGV_Ep.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_Ep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Ep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Ep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Ep.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_Ep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Ep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccEm_ID,
            this.ccEm_Name,
            this.ccEmPosition_ID,
            this.ccPosition,
            this.ccEm_User,
            this.ccEm_Pwd,
            this.ccEm_Status,
            this.ccEmDOB,
            this.ccEm_Addr,
            this.ccEm_Tel});
            this.dGV_Ep.Location = new System.Drawing.Point(8, 250);
            this.dGV_Ep.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Ep.MultiSelect = false;
            this.dGV_Ep.Name = "dGV_Ep";
            this.dGV_Ep.ReadOnly = true;
            this.dGV_Ep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Ep.Size = new System.Drawing.Size(838, 357);
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
            // ccEmPosition_ID
            // 
            this.ccEmPosition_ID.DataPropertyName = "EmPosition_ID";
            this.ccEmPosition_ID.HeaderText = "รหัสตำแหน่งพนักงาน";
            this.ccEmPosition_ID.Name = "ccEmPosition_ID";
            this.ccEmPosition_ID.ReadOnly = true;
            this.ccEmPosition_ID.Visible = false;
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
            this.ccEm_User.DataPropertyName = "Em_Login";
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
            // ccEm_Status
            // 
            this.ccEm_Status.DataPropertyName = "Em_Status";
            this.ccEm_Status.HeaderText = "สถานะ";
            this.ccEm_Status.Name = "ccEm_Status";
            this.ccEm_Status.ReadOnly = true;
            // 
            // ccEmDOB
            // 
            this.ccEmDOB.DataPropertyName = "Em_DOB";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ccEmDOB.DefaultCellStyle = dataGridViewCellStyle2;
            this.ccEmDOB.HeaderText = "วันเกิด";
            this.ccEmDOB.Name = "ccEmDOB";
            this.ccEmDOB.ReadOnly = true;
            // 
            // ccEm_Addr
            // 
            this.ccEm_Addr.DataPropertyName = "Em_Addr";
            this.ccEm_Addr.HeaderText = "ที่อยู่";
            this.ccEm_Addr.Name = "ccEm_Addr";
            this.ccEm_Addr.ReadOnly = true;
            this.ccEm_Addr.Visible = false;
            // 
            // ccEm_Tel
            // 
            this.ccEm_Tel.DataPropertyName = "Em_Tel";
            this.ccEm_Tel.HeaderText = "เบอร์โทรศัพท์";
            this.ccEm_Tel.Name = "ccEm_Tel";
            this.ccEm_Tel.ReadOnly = true;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dGV_PS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_PS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_PS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_PS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.gBoxPosition.Controls.Add(this.bt_ResetPosition);
            this.gBoxPosition.Controls.Add(this.bt_DelPosition);
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
            // bt_ResetPosition
            // 
            this.bt_ResetPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ResetPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ResetPosition.Location = new System.Drawing.Point(288, 22);
            this.bt_ResetPosition.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ResetPosition.Name = "bt_ResetPosition";
            this.bt_ResetPosition.Size = new System.Drawing.Size(70, 32);
            this.bt_ResetPosition.TabIndex = 5;
            this.bt_ResetPosition.Text = "เริ่มใหม่";
            this.bt_ResetPosition.UseVisualStyleBackColor = true;
            this.bt_ResetPosition.Click += new System.EventHandler(this.bt_ResetPosition_Click);
            // 
            // bt_DelPosition
            // 
            this.bt_DelPosition.Enabled = false;
            this.bt_DelPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_DelPosition.Location = new System.Drawing.Point(308, 112);
            this.bt_DelPosition.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DelPosition.Name = "bt_DelPosition";
            this.bt_DelPosition.Size = new System.Drawing.Size(70, 32);
            this.bt_DelPosition.TabIndex = 4;
            this.bt_DelPosition.Text = "ลบ";
            this.bt_DelPosition.UseVisualStyleBackColor = true;
            this.bt_DelPosition.Click += new System.EventHandler(this.bt_DelPosition_Click);
            // 
            // bt_LoadPS
            // 
            this.bt_LoadPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoadPS.Location = new System.Drawing.Point(11, 88);
            this.bt_LoadPS.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadPS.Name = "bt_LoadPS";
            this.bt_LoadPS.Size = new System.Drawing.Size(100, 32);
            this.bt_LoadPS.TabIndex = 4;
            this.bt_LoadPS.Text = "LoadPS";
            this.bt_LoadPS.UseVisualStyleBackColor = true;
            this.bt_LoadPS.Visible = false;
            this.bt_LoadPS.Click += new System.EventHandler(this.bt_LoadPS_Click);
            // 
            // bt_EditEmposition
            // 
            this.bt_EditEmposition.Enabled = false;
            this.bt_EditEmposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.bt_AddEmPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.txb_Emposition.MaxLength = 100;
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
            this.txb_EmpositionID.Name = "txb_EmpositionID";
            this.txb_EmpositionID.Size = new System.Drawing.Size(119, 26);
            this.txb_EmpositionID.TabIndex = 0;
            this.txb_EmpositionID.TextChanged += new System.EventHandler(this.txb_EmpositionID_TextChanged);
            // 
            // lb_EmPosition
            // 
            this.lb_EmPosition.AutoSize = true;
            this.lb_EmPosition.Location = new System.Drawing.Point(91, 66);
            this.lb_EmPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_EmPosition.Name = "lb_EmPosition";
            this.lb_EmPosition.Size = new System.Drawing.Size(67, 18);
            this.lb_EmPosition.TabIndex = 6;
            this.lb_EmPosition.Text = "ตำแหน่ง*";
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // FrmSetting16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 672);
            this.Controls.Add(this.tabControlEmployee);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSetting16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่า พนักงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM14_Load);
            this.tabControlEmployee.ResumeLayout(false);
            this.tpEmployee.ResumeLayout(false);
            this.gBoxEmployee.ResumeLayout(false);
            this.gBoxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ep)).EndInit();
            this.tpPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_PS)).EndInit();
            this.gBoxPosition.ResumeLayout(false);
            this.gBoxPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployee;
        private System.Windows.Forms.TabPage tpEmployee;
        private System.Windows.Forms.GroupBox gBoxEmployee;
        private System.Windows.Forms.Button bt_LoadEP;
        private System.Windows.Forms.Button bt_EditEm;
        private System.Windows.Forms.Button bt_AddEm;
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
        private System.Windows.Forms.Button bt_DelPosition;
        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.RadioButton rB_NotWork;
        private System.Windows.Forms.RadioButton rB_Work;
        private System.Windows.Forms.Label lb_EmAddr;
        private System.Windows.Forms.TextBox txb_EmAddr;
        private System.Windows.Forms.Label lb_EmTel;
        private System.Windows.Forms.TextBox txb_EmTel;
        private System.Windows.Forms.Label lb_EmDOB;
        private System.Windows.Forms.DateTimePicker dTP_EmDOB;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_ResetPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Position;
        private System.Windows.Forms.Button bt_Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEmPosition_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEmDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccEm_Tel;


    }
}