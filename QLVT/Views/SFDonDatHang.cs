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
    public partial class SFDonDatHang : Form
    {
        private readonly QLVTContext _Context;
        private readonly UCDonDatHang fParent;
        private Guid _idKhoSelected;
        private Guid _idNhaCCSelected;
        public SFDonDatHang(UCDonDatHang uc)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            fParent = uc;
            InitData();
        }
        private Dondathang GetData()
        {
            return new Dondathang
            {
                Id = Guid.NewGuid(),
                Ngaylap = DateTime.Now,
                Manv = Program.username,
                Idk = _idKhoSelected,
                Idncc = _idNhaCCSelected
            };
        }
        private void InitData()
        {
            var ncc = _Context.Nhacungcap.ToList();
            cbxNhaCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNhaCC.ValueMember = "Id";
            cbxNhaCC.DisplayMember = "Ten";
            cbxNhaCC.DataSource = ncc;
            cbxNhaCC.SelectedIndex = 0;

            var kho = _Context.Kho.ToList();
            cbxKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKho.ValueMember = "Id";
            cbxKho.DisplayMember = "Ten";
            cbxKho.DataSource = kho;
            cbxKho.SelectedIndex = 0;
        }
        private DialogResult CheckNotifySubmit()
        {
            string message = "Ban co muon tao Don Dat Hang nay khong?";
            string title = "Tao Kho";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (CheckNotifySubmit() == DialogResult.No) return;
            fParent.CreatedNewItem(GetData());
            Close();
        }
        private void cbxNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idNhaCCSelected = ((Nhacungcap)cbxNhaCC.SelectedItem).Id;
        }
        private void cbxKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idKhoSelected = ((Kho)cbxKho.SelectedItem).Id;
        }
    }
}
