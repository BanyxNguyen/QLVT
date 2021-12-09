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
    public partial class SFVatTu : Form
    {
        private readonly QLVTContext _Context;
        private readonly UCVatTu fParent;
        private bool Edited = false;
        private Hanghoa ItemEdit;
        public List<Loaihh> Loaihhs;
        private Guid _IdLhh;
        public SFVatTu(UCVatTu uc)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            fParent = uc;
            InitData();
        }
        private void InitData()
        {
            var lhh = _Context.Loaihh.ToList();
            cbxLoaiVT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLoaiVT.ValueMember = "Id";
            cbxLoaiVT.DisplayMember = "Ten";
            cbxLoaiVT.DataSource = lhh;
            cbxLoaiVT.SelectedIndex = 0;
        }
        public void EnabledEdit(Hanghoa item)
        {
            ItemEdit = item;
            lbFormName.Text = "SUA VAT TU";
            txtTen.Text = item.Ten;
            txtMota.Text = item.Mota;
            cbxLoaiVT.SelectedValue = ItemEdit.Idlhh;
            Edited = true;
        }
        private Hanghoa GetData()
        {
            return new Hanghoa
            {
                Ten = txtTen.Text.Trim(),
                Mota = txtMota.Text.Trim(),
                Idlhh = _IdLhh
            };
        }
        private bool CheckExitsValueForm()
        {
            if (txtTen.Text.Length > 0 || txtMota.Text.Length > 0)
            {
                return true;
            }
            else return false;
        }
        private DialogResult CheckNotifySubmit()
        {
            string n = "Vat Tu";
            string message, title;
            if (!Edited)
            {
                message = "Ban co muon tao " + n + " nay khong?";
                title = "Tao Kho";
            }
            else
            {
                message = "Ban co muon cap nhat " + n + " nay khong?";
                title = "Sua Kho";
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
                ItemEdit.Mota = temp.Mota;
                ItemEdit.Idlhh = temp.Idlhh;
                fParent.EditItem(ItemEdit);
            }
            Close();
        }
        private void cbxLoaiVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdLhh = ((Loaihh)cbxLoaiVT.SelectedItem).Id;
        }
    }
}
