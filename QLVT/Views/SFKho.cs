using QLVT.Models;
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
    public partial class SFKho : Form
    {
        private readonly UCKho uCKho;
        private bool Edited = false;
        private Kho KhoEdit;
        public SFKho(UCKho uC)
        {
            InitializeComponent();
            uCKho = uC;
        }
        public void EnabledEdit(Kho k)
        {
            KhoEdit = k;
            lbFormName.Text = "SUA KHO";
            txtTen.Text = k.Ten;
            txtDiaChi.Text = k.Diachi;
            txtSDT.Text = k.Sdt;
            Edited = true;
        }
        private bool CheckExitsValueForm()
        {
            if (txtTen.Text.Length > 0
                || txtSDT.Text.Length > 0
                || txtDiaChi.Text.Length > 0)
            {
                return true;
            }
            else return false;
        }
        private DialogResult CheckNotifySubmit()
        {
            string message, title;
            if (!Edited)
            {
                message = "Ban co muon tao Kho nay khong?";
                title = "Tao Kho";
            }
            else
            {
                message = "Ban co muon cap nhat Kho nay khong?";
                title = "Sua Kho";
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
        private Kho GetKho()
        {
            return new Kho
            {
                Ten = txtTen.Text.Trim(),
                Diachi = txtDiaChi.Text.Trim(),
                Sdt = txtSDT.Text.Trim(),
                Macn = Program.macn
            };
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CheckExitsValueForm())
            {
                string message = "Do you want to close this window?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (CheckNotifySubmit() == DialogResult.No) return;
            var k = GetKho();
            if (!Edited) uCKho.CreatedNewKho(k);
            else
            {
                KhoEdit.Ten = k.Ten;
                KhoEdit.Diachi = k.Diachi;
                KhoEdit.Sdt = k.Sdt;
                uCKho.EditKho(KhoEdit);
            }
            Close();
        }
    }
}
