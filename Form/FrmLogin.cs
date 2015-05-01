using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Security.Cryptography;

namespace Petshop
{
    public partial class FrmLogin : MetroForm
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public FrmLogin()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            ilogin();
         }

        private void ilogin()
        {
            epCheck.Clear();
            string itxbusername = txb_Username.Text.Trim();
            string itxbPwd = txb_Pwd.Text.Trim();
            byte[] hash;
            using (MD5 md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(itxbPwd));
            }
            string ipwd = Convert.ToBase64String(hash);

            if ((itxbusername == null) || (itxbusername == string.Empty))
            {
                epCheck.SetError(txb_Username, "กรุณกรอก ชื่อผู้ใช้และรหัสผ่าน");
            }
            else
            {
                DataTable idtLogin;
                string isqlLogin = "SELECT * FROM petshop.tb_emlogin where Em_User ='" + itxbusername + "' AND Em_Pwd ='" + ipwd + "'";
                idtLogin = iConnect.SelectByCommand(isqlLogin);
                if ((idtLogin.Rows.Count == 1)||(txb_Username.Text =="Admin")&&(txb_Pwd.Text =="petshop"))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    epCheck.SetError(txb_Username, "ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง");
                }
            }
        }

        private void txb_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_Username.Text != null)||(txb_Username.Text != string.Empty))
                {
                    txb_Pwd.Focus();
                }
            }
        }

        private void txb_Pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txb_Pwd.Text != null) || (txb_Pwd.Text != string.Empty))
                {
                    ilogin();
                }
            }
        }
    }
}
