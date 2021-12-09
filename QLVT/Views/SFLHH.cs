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
    public partial class SFLHH : Form
    {
        private readonly UCLoaiVatTu uCLoaiVatTu;
        private bool Edited = false;
        private Loaihh ItemEdit;
        public SFLHH(UCLoaiVatTu uC)
        {
            InitializeComponent();
            uCLoaiVatTu = uC;
        }
        public void EnabledEdit(Loaihh loaihh)
        {
            ItemEdit = loaihh;
            lbFormName.Text = "SUA LOAI VAT TU";
            txtTen.Text = loaihh.Ten;
            Edited = true;
        }
        private bool CheckExitsValueForm()
        {
            if (txtTen.Text.Length > 0)
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
                message = "Ban co muon tao Loai Vat Tu nay khong?";
                title = "Tao Kho";
            }
            else
            {
                message = "Ban co muon cap nhat Loai Vat Tu nay khong?";
                title = "Sua Kho";
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
        private Loaihh GetLoaiHH()
        {
            return new Loaihh
            {
                Ten = txtTen.Text.Trim(),
            };
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckNotifySubmit() == DialogResult.No) return;

            var temp = GetLoaiHH();
            if (!Edited) uCLoaiVatTu.CreatedNewItem(temp);
            else
            {
                ItemEdit.Ten = temp.Ten;
                uCLoaiVatTu.EditItem(ItemEdit);
            }
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CheckExitsValueForm())
            {
                string message = "Do you want to close this window?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) Close();
            }
            else Close();
        }
    }
}
