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
    public partial class SFNhaCC : Form
    {
        private readonly UCNhaCC fParent;
        private bool Edited = false;
        private Nhacungcap ItemEdit;
        public SFNhaCC(UCNhaCC uc)
        {
            InitializeComponent();
            fParent = uc;
        }
        public void EnabledEdit(Nhacungcap item)
        {
            ItemEdit = item;
            lbFormName.Text = "SUA NHA CUNG CAP";
            txtTen.Text = item.Ten;
            txtDiaChi.Text = item.Diachi;
            txtSdt.Text = item.Sdt;
            Edited = true;
        }
        private Nhacungcap GetData()
        {
            return new Nhacungcap
            {
                Ten = txtTen.Text.Trim(),
                Diachi = txtDiaChi.Text.Trim(),
                Sdt = txtSdt.Text.Trim()
            };
        }
        private bool CheckExitsValueForm()
        {
            if (txtTen.Text.Length > 0 || txtDiaChi.Text.Length > 0 || txtSdt.Text.Length > 0)
            {
                return true;
            }
            else return false;
        }
        private DialogResult CheckNotifySubmit()
        {
            string n = "Nha Cung Cap";
            string message, title;
            if (!Edited)
            {
                message = "Ban co muon tao " + n + " nay khong?";
                title = "Tao " + n;
            }
            else
            {
                message = "Ban co muon cap nhat " + n + " nay khong?";
                title = "Sua " + n;
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
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
            if (CheckNotifySubmit() == DialogResult.No) return;

            var temp = GetData();
            if (!Edited) fParent.CreatedNewItem(temp);
            else
            {
                ItemEdit.Ten = temp.Ten;
                ItemEdit.Diachi = temp.Diachi;
                ItemEdit.Sdt = temp.Sdt;
                fParent.EditItem(ItemEdit);
            }
            Close();
        }
    }
}
