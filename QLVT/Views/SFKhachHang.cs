using QLVT.DTO;
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
    public partial class SFKhachHang : Form
    {
        private readonly UCKhachHang fParent;
        private Khachhang ItemEdit;
        private bool Edited = false;
        public SFKhachHang(UCKhachHang f)
        {
            InitializeComponent();
            fParent = f;
        }
        public void EnabledEdit(Khachhang item)
        {
            ItemEdit = item;
            lbFormName.Text = "SUA KHACH HANG";
            txtTen.Text = item.Ten;
            txtDiaChi.Text = item.Diachi;
            txtSDT.Text = item.Sdt;
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
        private Khachhang GetData()
        {
            return new Khachhang
            {
                Id = new Guid(),
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
                string message = "Ban co muon thoat?";
                string title = "Thong Bao";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) Close();
            }
            else Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var k = GetData();
            if (!Edited) fParent.CreatedNewItem(k);
            else
            {
                ItemEdit.Ten = k.Ten;
                ItemEdit.Diachi = k.Diachi;
                ItemEdit.Sdt = k.Sdt;
                fParent.EditItem(ItemEdit);
            }
            Close();
        }
    }
}
