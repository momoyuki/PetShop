namespace Petshop
{
    partial class FrmLogin
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
            this.bt_Login = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txb_Username = new MetroFramework.Controls.MetroTextBox();
            this.txb_Pwd = new MetroFramework.Controls.MetroTextBox();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(107, 191);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(179, 50);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "เข้าระบบ";
            this.bt_Login.UseSelectable = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "UserName :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password:";
            // 
            // txb_Username
            // 
            this.txb_Username.Lines = new string[0];
            this.txb_Username.Location = new System.Drawing.Point(107, 96);
            this.txb_Username.MaxLength = 32767;
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.PasswordChar = '\0';
            this.txb_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_Username.SelectedText = "";
            this.txb_Username.Size = new System.Drawing.Size(179, 23);
            this.txb_Username.TabIndex = 3;
            this.txb_Username.UseSelectable = true;
            this.txb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Username_KeyDown);
            // 
            // txb_Pwd
            // 
            this.txb_Pwd.Lines = new string[0];
            this.txb_Pwd.Location = new System.Drawing.Point(107, 138);
            this.txb_Pwd.MaxLength = 32767;
            this.txb_Pwd.Name = "txb_Pwd";
            this.txb_Pwd.PasswordChar = '*';
            this.txb_Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_Pwd.SelectedText = "";
            this.txb_Pwd.Size = new System.Drawing.Size(179, 23);
            this.txb_Pwd.TabIndex = 4;
            this.txb_Pwd.UseSelectable = true;
            this.txb_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Pwd_KeyDown);
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.txb_Pwd);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bt_Login);
            this.Name = "FrmLogin";
            this.Text = "เข้าระบบ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt_Login;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txb_Username;
        private MetroFramework.Controls.MetroTextBox txb_Pwd;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}