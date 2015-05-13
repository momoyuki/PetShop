using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Petshop
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            Application.Run(new FrmLogin());
           /*
            FrmLogin fLogin = new FrmLogin();
            
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                MainForm iMainForm = new MainForm();
                iMainForm.ShowDialog();
            } 
            */
        }
    }
}
