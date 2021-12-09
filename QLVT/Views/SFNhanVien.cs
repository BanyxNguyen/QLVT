using QLVT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Views
{
    public partial class SFNhanVien : Form
    {
        private readonly UCNhanVien fParent;
        public SFNhanVien(UCNhanVien uC)
        {
            InitializeComponent();
            fParent = uC;
        }
        public void EnabledEdit()
        {

        }
        private bool CheckExitsValueForm()
        {
            if (txtMaNV.Text.Length > 0
                || txtHo.Text.Length > 0
                || txtTen.Text.Length > 0
                || txtSDT.Text.Length > 0
                || txtCMND.Text.Length > 0
                || txtDiaChi.Text.Length > 0
                || txtLuong.Text.Length > 0)
            {
                return true;
            } else return false;
        }
        public Nhanvien GetNhanVien()
        {
            return new Nhanvien
            {
                Manv = txtMaNV.Text.Trim(),
                Macn = Program.macn,
                Ho = txtHo.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                Phai = cbxGioiTinh.SelectedIndex,
                Ngaysinh = dtpNgaySinh.Value,
                Sdt = txtSDT.Text.Trim(),
                Cmnd = txtCMND.Text.Trim(),
                Diachi = txtDiaChi.Text.Trim(),
                Luong = int.Parse(txtLuong.Text.Trim()),
                Ttxoa = 0
            };
        }
        private string FormatMoney(string val)
        {
            char[] numberText = val.ToCharArray();
            for (int i = 0; i < numberText.Length; ++i)
            {
                if (numberText[i].Equals(','))
                {
                    numberText[i] = ' ';
                }
            }
            return new String(numberText);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = "Do you want create Employ?";
            string title = "Create Employ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Close();
                fParent.CreatedNewNhanVien(GetNhanVien());
            }
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
            else
            {
                Close();
            }
        }

        private void SFNhanVienAdd_Load(object sender, EventArgs e)
        {
            txtChiNhanh.Text = Program.macn;
            txtChiNhanh.Enabled = false;
            cbxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGioiTinh.SelectedIndex = 0;
        }
    }
}
