using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Petshop
{
    public partial class FrmIndex : MetroForm
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public FrmIndex()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string itxbusername = txb_Username.Text.Trim();
            string itxbPwd = txb_Pwd.Text.Trim();
            string isqlLogin = "SELECT * FROM petshop.tb_emlogin where Em_User ='"+itxbusername+"' AND Em_Pwd ='"+itxbPwd+"'";
            DataTable idtLogin;
            idtLogin =  iConnect.SelectByCommand(isqlLogin);
            if (idtLogin.Rows.Count == 1)
            {
              
            }
         }
    }
}
