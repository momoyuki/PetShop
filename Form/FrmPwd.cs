using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Petshop
{
    public partial class FrmPwd : Form
    {
        private MySQLDBConnect iConnect;
        public FrmPwd()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect();
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
           string itxbOldPwd =  txb_OldPwd.Text.Trim();
           string itxbNewPwd =  txb_NewPwd.Text.Trim();
           string itxbPwdconf =  txb_Pwdconf.Text.Trim();

           byte[] hashold;
           byte[] hashnew;
           byte[] hashconf;

           using (MD5 md5 = MD5.Create())
           {
               hashold = md5.ComputeHash(Encoding.UTF8.GetBytes(itxbOldPwd));
               hashnew = md5.ComputeHash(Encoding.UTF8.GetBytes(itxbNewPwd));
               hashconf = md5.ComputeHash(Encoding.UTF8.GetBytes(itxbPwdconf));
           }
           string iPwdOld = Convert.ToBase64String(hashold);
           string iPwdnew = Convert.ToBase64String(hashnew);
           string iPwdconf = Convert.ToBase64String(hashconf);

           if (iPwdnew == iPwdconf)
           {
               string ilbPetID = lb_PetID.Text.Trim();
               DataTable idtCheckPassword;
               string isqlCheckPass = "SELECT * FROM petshop.tb_employee where Em_ID = '" + ilbPetID + "' AND `Em_Pwd`='" + iPwdOld + "'";
               idtCheckPassword = iConnect.SelectByCommand(isqlCheckPass);

               if (idtCheckPassword.Rows.Count == 1)
               {
                   string isqlChangePwd = "UPDATE `petshop`.`tb_employee` SET `Em_Pwd`='" + iPwdnew +"' WHERE `Em_ID`='" + ilbPetID + "'";
                   iConnect.Insert(isqlChangePwd);
                   this.Close();
                   MessageBox.Show("เปลี่ยนรหัสผ่านแล้ว");
               }
               else
               {
                   epCheck.SetError(txb_OldPwd,"รหัสผ่านเดิมไม่ถูกต้อง");
               }
           }
           else
           {
               epCheck.SetError(txb_Pwdconf,"รหัสผ่านไม่ตรงกัน");
           }
           
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPwd_Load(object sender, EventArgs e)
        {

        }
    }
}
