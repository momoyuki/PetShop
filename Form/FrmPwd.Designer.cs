namespace Petshop
{
    partial class FrmPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_OldPwd = new System.Windows.Forms.TextBox();
            this.txb_NewPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Pwdconf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.lb_PetID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสเดิม";
            // 
            // txb_OldPwd
            // 
            this.txb_OldPwd.Location = new System.Drawing.Point(119, 44);
            this.txb_OldPwd.Name = "txb_OldPwd";
            this.txb_OldPwd.PasswordChar = '*';
            this.txb_OldPwd.Size = new System.Drawing.Size(100, 20);
            this.txb_OldPwd.TabIndex = 1;
            // 
            // txb_NewPwd
            // 
            this.txb_NewPwd.Location = new System.Drawing.Point(119, 70);
            this.txb_NewPwd.Name = "txb_NewPwd";
            this.txb_NewPwd.PasswordChar = '*';
            this.txb_NewPwd.Size = new System.Drawing.Size(100, 20);
            this.txb_NewPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสใหม่";
            // 
            // txb_Pwdconf
            // 
            this.txb_Pwdconf.Location = new System.Drawing.Point(119, 96);
            this.txb_Pwdconf.Name = "txb_Pwdconf";
            this.txb_Pwdconf.PasswordChar = '*';
            this.txb_Pwdconf.Size = new System.Drawing.Size(100, 20);
            this.txb_Pwdconf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ยืนยันรหัสใหม่";
            // 
            // bt_Submit
            // 
            this.bt_Submit.Location = new System.Drawing.Point(63, 128);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(75, 23);
            this.bt_Submit.TabIndex = 6;
            this.bt_Submit.Text = "ยืนยัน";
            this.bt_Submit.UseVisualStyleBackColor = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(144, 128);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "ยกเลิก";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // lb_PetID
            // 
            this.lb_PetID.AutoSize = true;
            this.lb_PetID.Location = new System.Drawing.Point(118, 19);
            this.lb_PetID.Name = "lb_PetID";
            this.lb_PetID.Size = new System.Drawing.Size(85, 13);
            this.lb_PetID.TabIndex = 8;
            this.lb_PetID.Text = "1111111111111";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "รหัสสมาชิก";
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // FrmPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 167);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_PetID);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.txb_Pwdconf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_NewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_OldPwd);
            this.Controls.Add(this.label1);
            this.Name = "FrmPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งรหัสผ่าน";
            this.Load += new System.EventHandler(this.FrmPwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_OldPwd;
        private System.Windows.Forms.TextBox txb_NewPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Pwdconf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lb_PetID;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}