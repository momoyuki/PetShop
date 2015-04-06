namespace Petshop
{
    partial class FrmSetting17
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
            this.lb_CoName = new System.Windows.Forms.Label();
            this.lb_CoID = new System.Windows.Forms.Label();
            this.lb_CoAddr = new System.Windows.Forms.Label();
            this.lb_CoTel = new System.Windows.Forms.Label();
            this.lb_CoRemark = new System.Windows.Forms.Label();
            this.txb_CoID = new System.Windows.Forms.TextBox();
            this.txb_Company_Name = new System.Windows.Forms.TextBox();
            this.txb_CompanyAddr = new System.Windows.Forms.TextBox();
            this.txb_CompanyTel = new System.Windows.Forms.TextBox();
            this.txb_CompanyRemark = new System.Windows.Forms.TextBox();
            this.bt_Update = new System.Windows.Forms.Button();
            this.txb_CoService = new System.Windows.Forms.TextBox();
            this.lb_CoService = new System.Windows.Forms.Label();
            this.txb_CoBill = new System.Windows.Forms.TextBox();
            this.lb_CoBill = new System.Windows.Forms.Label();
            this.txb_CoSale = new System.Windows.Forms.TextBox();
            this.lb_CoSale = new System.Windows.Forms.Label();
            this.bt_LoadCompany = new System.Windows.Forms.Button();
            this.gBoxCoDetail = new System.Windows.Forms.GroupBox();
            this.gBoxCompanyCode = new System.Windows.Forms.GroupBox();
            this.lb_CoIDH = new System.Windows.Forms.Label();
            this.gBoxLogo = new System.Windows.Forms.GroupBox();
            this.bt_UseImage = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.bt_Browse = new System.Windows.Forms.Button();
            this.lb_ExLogo = new System.Windows.Forms.Label();
            this.lb_LogoRemark = new System.Windows.Forms.Label();
            this.txb_Image = new System.Windows.Forms.TextBox();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxCoDetail.SuspendLayout();
            this.gBoxCompanyCode.SuspendLayout();
            this.gBoxLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CoName
            // 
            this.lb_CoName.AutoSize = true;
            this.lb_CoName.Location = new System.Drawing.Point(76, 22);
            this.lb_CoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoName.Name = "lb_CoName";
            this.lb_CoName.Size = new System.Drawing.Size(84, 18);
            this.lb_CoName.TabIndex = 0;
            this.lb_CoName.Text = "ชื่อหน่วยงาน";
            // 
            // lb_CoID
            // 
            this.lb_CoID.AutoSize = true;
            this.lb_CoID.Location = new System.Drawing.Point(46, 26);
            this.lb_CoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoID.Name = "lb_CoID";
            this.lb_CoID.Size = new System.Drawing.Size(65, 18);
            this.lb_CoID.TabIndex = 1;
            this.lb_CoID.Text = "รหัสสาขา";
            // 
            // lb_CoAddr
            // 
            this.lb_CoAddr.AutoSize = true;
            this.lb_CoAddr.Location = new System.Drawing.Point(128, 62);
            this.lb_CoAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoAddr.Name = "lb_CoAddr";
            this.lb_CoAddr.Size = new System.Drawing.Size(37, 18);
            this.lb_CoAddr.TabIndex = 2;
            this.lb_CoAddr.Text = "ที่อยู่";
            // 
            // lb_CoTel
            // 
            this.lb_CoTel.AutoSize = true;
            this.lb_CoTel.Location = new System.Drawing.Point(76, 202);
            this.lb_CoTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoTel.Name = "lb_CoTel";
            this.lb_CoTel.Size = new System.Drawing.Size(92, 18);
            this.lb_CoTel.TabIndex = 3;
            this.lb_CoTel.Text = "เบอร์โทรศัพท์";
            // 
            // lb_CoRemark
            // 
            this.lb_CoRemark.AutoSize = true;
            this.lb_CoRemark.Location = new System.Drawing.Point(97, 237);
            this.lb_CoRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoRemark.Name = "lb_CoRemark";
            this.lb_CoRemark.Size = new System.Drawing.Size(67, 18);
            this.lb_CoRemark.TabIndex = 4;
            this.lb_CoRemark.Text = "หมายเหตุ";
            // 
            // txb_CoID
            // 
            this.txb_CoID.Location = new System.Drawing.Point(119, 23);
            this.txb_CoID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CoID.MaxLength = 2;
            this.txb_CoID.Name = "txb_CoID";
            this.txb_CoID.Size = new System.Drawing.Size(49, 26);
            this.txb_CoID.TabIndex = 5;
            this.txb_CoID.Text = "01";
            this.txb_CoID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_CoID_KeyDown);
            // 
            // txb_Company_Name
            // 
            this.txb_Company_Name.Location = new System.Drawing.Point(172, 18);
            this.txb_Company_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Company_Name.MaxLength = 120;
            this.txb_Company_Name.Name = "txb_Company_Name";
            this.txb_Company_Name.Size = new System.Drawing.Size(239, 26);
            this.txb_Company_Name.TabIndex = 6;
            this.txb_Company_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Company_Name_KeyDown);
            // 
            // txb_CompanyAddr
            // 
            this.txb_CompanyAddr.Location = new System.Drawing.Point(172, 58);
            this.txb_CompanyAddr.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CompanyAddr.MaxLength = 140;
            this.txb_CompanyAddr.Multiline = true;
            this.txb_CompanyAddr.Name = "txb_CompanyAddr";
            this.txb_CompanyAddr.Size = new System.Drawing.Size(289, 130);
            this.txb_CompanyAddr.TabIndex = 7;
            this.txb_CompanyAddr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_CompanyAddr_KeyDown);
            // 
            // txb_CompanyTel
            // 
            this.txb_CompanyTel.Location = new System.Drawing.Point(172, 198);
            this.txb_CompanyTel.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CompanyTel.MaxLength = 42;
            this.txb_CompanyTel.Name = "txb_CompanyTel";
            this.txb_CompanyTel.Size = new System.Drawing.Size(245, 26);
            this.txb_CompanyTel.TabIndex = 8;
            this.txb_CompanyTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_CompanyTel_KeyDown);
            // 
            // txb_CompanyRemark
            // 
            this.txb_CompanyRemark.Location = new System.Drawing.Point(172, 234);
            this.txb_CompanyRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CompanyRemark.MaxLength = 140;
            this.txb_CompanyRemark.Name = "txb_CompanyRemark";
            this.txb_CompanyRemark.Size = new System.Drawing.Size(239, 26);
            this.txb_CompanyRemark.TabIndex = 9;
            this.txb_CompanyRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_CompanyRemark_KeyDown);
            // 
            // bt_Update
            // 
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Location = new System.Drawing.Point(339, 421);
            this.bt_Update.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(100, 32);
            this.bt_Update.TabIndex = 16;
            this.bt_Update.Text = "บันทึก";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // txb_CoService
            // 
            this.txb_CoService.Location = new System.Drawing.Point(327, 61);
            this.txb_CoService.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CoService.MaxLength = 2;
            this.txb_CoService.Name = "txb_CoService";
            this.txb_CoService.Size = new System.Drawing.Size(49, 26);
            this.txb_CoService.TabIndex = 19;
            this.txb_CoService.Text = "99";
            this.txb_CoService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_CoService_KeyDown);
            // 
            // lb_CoService
            // 
            this.lb_CoService.AutoSize = true;
            this.lb_CoService.Location = new System.Drawing.Point(249, 64);
            this.lb_CoService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoService.Name = "lb_CoService";
            this.lb_CoService.Size = new System.Drawing.Size(70, 18);
            this.lb_CoService.TabIndex = 18;
            this.lb_CoService.Text = "รหัสบริการ";
            // 
            // txb_CoBill
            // 
            this.txb_CoBill.Location = new System.Drawing.Point(119, 61);
            this.txb_CoBill.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CoBill.MaxLength = 2;
            this.txb_CoBill.Name = "txb_CoBill";
            this.txb_CoBill.Size = new System.Drawing.Size(49, 26);
            this.txb_CoBill.TabIndex = 21;
            this.txb_CoBill.Text = "55";
            this.txb_CoBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_CoBill_KeyDown);
            // 
            // lb_CoBill
            // 
            this.lb_CoBill.AutoSize = true;
            this.lb_CoBill.Location = new System.Drawing.Point(34, 64);
            this.lb_CoBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoBill.Name = "lb_CoBill";
            this.lb_CoBill.Size = new System.Drawing.Size(77, 18);
            this.lb_CoBill.TabIndex = 20;
            this.lb_CoBill.Text = "รหัสใบเสร็จ";
            // 
            // txb_CoSale
            // 
            this.txb_CoSale.Location = new System.Drawing.Point(327, 20);
            this.txb_CoSale.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CoSale.MaxLength = 2;
            this.txb_CoSale.Name = "txb_CoSale";
            this.txb_CoSale.Size = new System.Drawing.Size(49, 26);
            this.txb_CoSale.TabIndex = 23;
            this.txb_CoSale.Text = "98";
            // 
            // lb_CoSale
            // 
            this.lb_CoSale.AutoSize = true;
            this.lb_CoSale.Location = new System.Drawing.Point(227, 26);
            this.lb_CoSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CoSale.Name = "lb_CoSale";
            this.lb_CoSale.Size = new System.Drawing.Size(92, 18);
            this.lb_CoSale.TabIndex = 22;
            this.lb_CoSale.Text = "รหัสขายสินค้า";
            // 
            // bt_LoadCompany
            // 
            this.bt_LoadCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoadCompany.Location = new System.Drawing.Point(788, 427);
            this.bt_LoadCompany.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LoadCompany.Name = "bt_LoadCompany";
            this.bt_LoadCompany.Size = new System.Drawing.Size(123, 32);
            this.bt_LoadCompany.TabIndex = 24;
            this.bt_LoadCompany.Text = "LoadCompany";
            this.bt_LoadCompany.UseVisualStyleBackColor = true;
            this.bt_LoadCompany.Click += new System.EventHandler(this.bt_LoadCompany_Click);
            // 
            // gBoxCoDetail
            // 
            this.gBoxCoDetail.Controls.Add(this.lb_CoName);
            this.gBoxCoDetail.Controls.Add(this.lb_CoAddr);
            this.gBoxCoDetail.Controls.Add(this.lb_CoTel);
            this.gBoxCoDetail.Controls.Add(this.lb_CoRemark);
            this.gBoxCoDetail.Controls.Add(this.txb_Company_Name);
            this.gBoxCoDetail.Controls.Add(this.txb_CompanyAddr);
            this.gBoxCoDetail.Controls.Add(this.txb_CompanyTel);
            this.gBoxCoDetail.Controls.Add(this.txb_CompanyRemark);
            this.gBoxCoDetail.Location = new System.Drawing.Point(12, 12);
            this.gBoxCoDetail.Name = "gBoxCoDetail";
            this.gBoxCoDetail.Size = new System.Drawing.Size(473, 284);
            this.gBoxCoDetail.TabIndex = 26;
            this.gBoxCoDetail.TabStop = false;
            this.gBoxCoDetail.Text = "ข้อมูลหน่วยงาน";
            // 
            // gBoxCompanyCode
            // 
            this.gBoxCompanyCode.Controls.Add(this.lb_CoIDH);
            this.gBoxCompanyCode.Controls.Add(this.lb_CoSale);
            this.gBoxCompanyCode.Controls.Add(this.lb_CoID);
            this.gBoxCompanyCode.Controls.Add(this.txb_CoID);
            this.gBoxCompanyCode.Controls.Add(this.lb_CoService);
            this.gBoxCompanyCode.Controls.Add(this.txb_CoSale);
            this.gBoxCompanyCode.Controls.Add(this.txb_CoService);
            this.gBoxCompanyCode.Controls.Add(this.lb_CoBill);
            this.gBoxCompanyCode.Controls.Add(this.txb_CoBill);
            this.gBoxCompanyCode.Location = new System.Drawing.Point(12, 302);
            this.gBoxCompanyCode.Name = "gBoxCompanyCode";
            this.gBoxCompanyCode.Size = new System.Drawing.Size(473, 112);
            this.gBoxCompanyCode.TabIndex = 27;
            this.gBoxCompanyCode.TabStop = false;
            this.gBoxCompanyCode.Text = "รหัสสำหรับเอกสาร";
            // 
            // lb_CoIDH
            // 
            this.lb_CoIDH.AutoSize = true;
            this.lb_CoIDH.Location = new System.Drawing.Point(176, 26);
            this.lb_CoIDH.Name = "lb_CoIDH";
            this.lb_CoIDH.Size = new System.Drawing.Size(0, 18);
            this.lb_CoIDH.TabIndex = 10;
            this.lb_CoIDH.Visible = false;
            // 
            // gBoxLogo
            // 
            this.gBoxLogo.Controls.Add(this.bt_UseImage);
            this.gBoxLogo.Controls.Add(this.picBoxLogo);
            this.gBoxLogo.Controls.Add(this.bt_Browse);
            this.gBoxLogo.Controls.Add(this.lb_ExLogo);
            this.gBoxLogo.Controls.Add(this.lb_LogoRemark);
            this.gBoxLogo.Controls.Add(this.txb_Image);
            this.gBoxLogo.Location = new System.Drawing.Point(491, 12);
            this.gBoxLogo.Name = "gBoxLogo";
            this.gBoxLogo.Size = new System.Drawing.Size(420, 402);
            this.gBoxLogo.TabIndex = 28;
            this.gBoxLogo.TabStop = false;
            this.gBoxLogo.Text = "ภาพสัญลักษณ์";
            // 
            // bt_UseImage
            // 
            this.bt_UseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_UseImage.Location = new System.Drawing.Point(332, 351);
            this.bt_UseImage.Name = "bt_UseImage";
            this.bt_UseImage.Size = new System.Drawing.Size(75, 33);
            this.bt_UseImage.TabIndex = 35;
            this.bt_UseImage.Text = "ใช้ภาพนี้";
            this.bt_UseImage.UseVisualStyleBackColor = true;
            this.bt_UseImage.Click += new System.EventHandler(this.bt_UseImage_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Location = new System.Drawing.Point(125, 134);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(200, 200);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 34;
            this.picBoxLogo.TabStop = false;
            // 
            // bt_Browse
            // 
            this.bt_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Browse.Location = new System.Drawing.Point(307, 56);
            this.bt_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Browse.Name = "bt_Browse";
            this.bt_Browse.Size = new System.Drawing.Size(100, 32);
            this.bt_Browse.TabIndex = 29;
            this.bt_Browse.Text = "เลือก";
            this.bt_Browse.UseVisualStyleBackColor = true;
            this.bt_Browse.Click += new System.EventHandler(this.bt_Browse_Click);
            // 
            // lb_ExLogo
            // 
            this.lb_ExLogo.AutoSize = true;
            this.lb_ExLogo.Location = new System.Drawing.Point(185, 352);
            this.lb_ExLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ExLogo.Name = "lb_ExLogo";
            this.lb_ExLogo.Size = new System.Drawing.Size(83, 18);
            this.lb_ExLogo.TabIndex = 33;
            this.lb_ExLogo.Text = "ตัวอย่างภาพ";
            // 
            // lb_LogoRemark
            // 
            this.lb_LogoRemark.AutoSize = true;
            this.lb_LogoRemark.Location = new System.Drawing.Point(13, 90);
            this.lb_LogoRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LogoRemark.Name = "lb_LogoRemark";
            this.lb_LogoRemark.Size = new System.Drawing.Size(258, 18);
            this.lb_LogoRemark.TabIndex = 32;
            this.lb_LogoRemark.Text = "**ภาพควรมี DPI 600 เพื่อใช้สำหรับพิมพ์";
            // 
            // txb_Image
            // 
            this.txb_Image.Enabled = false;
            this.txb_Image.Location = new System.Drawing.Point(16, 60);
            this.txb_Image.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Image.Name = "txb_Image";
            this.txb_Image.Size = new System.Drawing.Size(281, 26);
            this.txb_Image.TabIndex = 31;
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // FrmMM16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 472);
            this.Controls.Add(this.gBoxLogo);
            this.Controls.Add(this.gBoxCompanyCode);
            this.Controls.Add(this.gBoxCoDetail);
            this.Controls.Add(this.bt_LoadCompany);
            this.Controls.Add(this.bt_Update);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMM16";
            this.Text = "ตั้งค่า หน่วยงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMM16_Load);
            this.gBoxCoDetail.ResumeLayout(false);
            this.gBoxCoDetail.PerformLayout();
            this.gBoxCompanyCode.ResumeLayout(false);
            this.gBoxCompanyCode.PerformLayout();
            this.gBoxLogo.ResumeLayout(false);
            this.gBoxLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_CoName;
        private System.Windows.Forms.Label lb_CoID;
        private System.Windows.Forms.Label lb_CoAddr;
        private System.Windows.Forms.Label lb_CoTel;
        private System.Windows.Forms.Label lb_CoRemark;
        private System.Windows.Forms.TextBox txb_CoID;
        private System.Windows.Forms.TextBox txb_Company_Name;
        private System.Windows.Forms.TextBox txb_CompanyAddr;
        private System.Windows.Forms.TextBox txb_CompanyTel;
        private System.Windows.Forms.TextBox txb_CompanyRemark;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.TextBox txb_CoService;
        private System.Windows.Forms.Label lb_CoService;
        private System.Windows.Forms.TextBox txb_CoBill;
        private System.Windows.Forms.Label lb_CoBill;
        private System.Windows.Forms.TextBox txb_CoSale;
        private System.Windows.Forms.Label lb_CoSale;
        private System.Windows.Forms.Button bt_LoadCompany;
        private System.Windows.Forms.GroupBox gBoxCoDetail;
        private System.Windows.Forms.GroupBox gBoxCompanyCode;
        private System.Windows.Forms.GroupBox gBoxLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button bt_Browse;
        private System.Windows.Forms.Label lb_ExLogo;
        private System.Windows.Forms.Label lb_LogoRemark;
        private System.Windows.Forms.TextBox txb_Image;
        private System.Windows.Forms.Label lb_CoIDH;
        private System.Windows.Forms.Button bt_UseImage;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}