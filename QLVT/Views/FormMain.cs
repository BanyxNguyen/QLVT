using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Views
{
    public partial class FormMain : Form
    {
        FormLogin formLogin;
        public FormMain(FormLogin f)
        {
            InitializeComponent();
            formLogin = f;
        }

        public void UpdateInfoLogin()
        {
            lbInfo.Text = "MSNV: " + Program.username + "   Ten: " + Program.fullName + "   Nhom: " + Program.group;
            label1.Text = Program.connStr;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.Close();
        }
    }
}
