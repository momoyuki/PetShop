using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void บรการToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM11))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM11 iFrmMM11 = new FrmMM11();
            iFrmMM11.MdiParent = this;
            iFrmMM11.Show();
        }

        private void ตงคาสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM12))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM12 iFrmMM12 = new FrmMM12();
            iFrmMM12.MdiParent = this;
            iFrmMM12.Show();
        }

        private void พนธสตวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM14))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM14 iFrmMM14 = new FrmMM14();
            iFrmMM14.MdiParent = this;
            iFrmMM14.Show();
        }

        private void พนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM15))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM15 iFrmMM15 = new FrmMM15();
            iFrmMM15.MdiParent = this;
            iFrmMM15.Show();
        }

        private void ตงคาหนวยงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM16))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM16 iFrmMM16 = new FrmMM16();
            iFrmMM16.MdiParent = this;
            iFrmMM16.Show();
        }

        private void ทำการรกษาToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM21))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM21 iFrmMM21 = new FrmMM21();
            iFrmMM21.MdiParent = this;
            iFrmMM21.Show();
        }

        private void ทำการรกษายาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM22))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM22 iFrmMM22 = new FrmMM22();
            iFrmMM22.MdiParent = this;
            iFrmMM22.Show();
        }

        private void ตดตามการรกษาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM23))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM23 iFrmMM23 = new FrmMM23();
            iFrmMM23.MdiParent = this;
            iFrmMM23.Show();
        }
        private TextBox _TextBox = new TextBox();
        private void จดการสมาชกToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM24))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM24 iFrmMM24 = new FrmMM24(ref _TextBox);
            iFrmMM24.MdiParent = this;
            iFrmMM24.Show();
        }

        private void หนวยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM13))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM13 iFrmMM13 = new FrmMM13();
            iFrmMM13.MdiParent = this;
            iFrmMM13.Show();
        }

        private void ใบเสรจบรการToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM341))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM341 iFrmMM341 = new FrmMM341();
            iFrmMM341.MdiParent = this;
            iFrmMM341.Show();
        }
        private void ขายสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM342))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM342 iFrmMM342 = new FrmMM342();
            iFrmMM342.MdiParent = this;
            iFrmMM342.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable idtCompany;
            string isqlCompany = "SELECT * FROM tb_company";
            idtCompany = iConnect.SelectByCommand(isqlCompany);
            if (idtCompany.Rows.Count >0) {
                string iCompanyName = idtCompany.Rows[0].Field<string>(1);
                this.Text = iCompanyName;
            }
            //โหลด ชิื่อองค์กร
        }

        private void ใบนดหมายToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            foreach (Form form in Application.OpenForms) //คำสั่งห้ามเปิดซ้อนสอง
            {
                if (form.GetType() == typeof(FrmMM35))
                {
                    form.Activate();
                    return;
                }
            }
            FrmMM35 iFrmMM35 = new FrmMM35();
            iFrmMM35.MdiParent = this;
            iFrmMM35.Show();
        
        }
    }
}
