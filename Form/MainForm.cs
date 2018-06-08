using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Petshop
{
    public partial class MainForm : Form 
    {
        private MySQLDBConnect iConnect; //ดึงClass MySQLDBConnect มาใช้ โดยเก็บไว้ในตัวแปร iconnect
        public MainForm()
        {
            InitializeComponent();
            iConnect = new MySQLDBConnect(); //กำหนดค่า iconnect เป็น Class MySQLDBConnect
        }




        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("ต้องการออกจากโปรแกรม?",
                         "กำลังปิดโปรแกรม",
                          MessageBoxButtons.YesNoCancel,
                          MessageBoxIcon.Information) == DialogResult.Yes)
            {
              /*  // Prepare a dummy string, thos would appear in the dialog
                string dummyFileName = "Save Here";

                SaveFileDialog sf = new SaveFileDialog();
                // Feed the dummy name to the save dialog
                sf.FileName = dummyFileName;

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    // Now here's our save folder
                    string savePath = Path.GetDirectoryName(sf.FileName);
                    // Do whatever
                    iConnect.BackupDatabase(savePath);
                }
            }
            else
            {*/
                e.Cancel = true;
            }            
        }


        internal void LoadEmployee()
        {
            DataTable idtEmployee;
            string isqlEmployee = "SELECT * FROM petshop.tb_employee where Em_ID = '"+_strUser+"'";
            idtEmployee = iConnect.SelectByCommand(isqlEmployee);
            StripStatusEm_ID.Text = idtEmployee.Rows[0].Field<string>(0);
            StripStatusEm_Name.Text = idtEmployee.Rows[0].Field<string>(1);
  
        }
        string strUser;
        public string _strUser
        {
            get { return strUser; }
            set { strUser = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            if (idtCompany.Rows.Count > 0)
            {
                string iCompanyName = idtCompany.Rows[0].Field<string>(1);
                this.Text = iCompanyName;
            }
            //โหลด ชิื่อองค์กร
        }
        private void บรการToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting11))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting11 iFrmSetting11 = new FrmSetting11();
            iFrmSetting11.MdiParent = this;
            iFrmSetting11.Show();
        }

        private void ตงคาสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting12))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting12 iFrmSetting12 = new FrmSetting12();
            iFrmSetting12.MdiParent = this;
            iFrmSetting12.Show();
        }
        private void รายจายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting13))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting13 iFrmSetting13 = new FrmSetting13();
            iFrmSetting13.MdiParent = this;
            iFrmSetting13.Show();
        }
        private void หนวยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting14))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting14 iFrmSetting14 = new FrmSetting14();
            iFrmSetting14.MdiParent = this;
            iFrmSetting14.Show();
        }
        private void พนธสตวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting15))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting15 iFrmSetting15 = new FrmSetting15();
            iFrmSetting15.MdiParent = this;
            iFrmSetting15.Show();
        }

        private void พนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting16))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting16 iFrmSetting16 = new FrmSetting16();
            iFrmSetting16.MdiParent = this;
            iFrmSetting16.Show();
        }

        private void ตงคาหนวยงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmSetting17))
                {
                    form.Activate();
                    return;
                }
            }
            FrmSetting17 iFrmSetting17 = new FrmSetting17();
            iFrmSetting17.MdiParent = this;
            iFrmSetting17.Show();
        }
        private void จดการสมาชกToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD21))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD21 iFrmRecorD21 = new FrmRecorD21(ref _TextBox);
            iFrmRecorD21.MdiParent = this;
            iFrmRecorD21.Show();
        }

        private void ตดตามการรกษาToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD22))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD22 iFrmRecorD22 = new FrmRecorD22();
            iFrmRecorD22.MdiParent = this;
            iFrmRecorD22.Show();
        }
        private void ทำการรกษายาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD23))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD23 iFrmRecorD23 = new FrmRecorD23();
            iFrmRecorD23.MdiParent = this;
            iFrmRecorD23.Show();
            iFrmRecorD23.cb_Em.SelectedValue = StripStatusEm_ID.Text;
        }
        private void บนทกรายจายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmRecorD24))
                {
                    form.Activate();
                    return;
                }
            }
            FrmRecorD24 iFrmRecorD24 = new FrmRecorD24();
            iFrmRecorD24.MdiParent = this;
            iFrmRecorD24.Show();
            iFrmRecorD24.cb_Em.SelectedValue = StripStatusEm_ID.Text;
        }
    
        private TextBox _TextBox = new TextBox();
   
        private void xออกจากโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ใบเสรจToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmBillAll))
                {
                    form.Activate();
                    return;
                }
            }
            FrmBillAll iFrmRePort31 = new FrmBillAll();
            iFrmRePort31.MdiParent = this;
            iFrmRePort31.Show();
        }

        private void ดรายรบรายจายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmPreOutincome))
                {
                    form.Activate();
                    return;
                }
            }
            FrmPreOutincome iFrmRePort32 = new FrmPreOutincome();
            iFrmRePort32.MdiParent = this;
            iFrmRePort32.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmPreHealRecord))
                {
                    form.Activate();
                    return;
                }
            }
            FrmPreHealRecord iFrmRePort33 = new FrmPreHealRecord();
            iFrmRePort33.MdiParent = this;
            iFrmRePort33.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void เกยวกบเราToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout iFrmAbout = new FrmAbout();
            //iFrmAbout.MdiParent = this;
            iFrmAbout.ShowDialog();
        }


    }
}
