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
    public partial class SFTaoPhieuNhap : Form
    {
        private readonly QLVTContext _Context;
        private readonly SFPhieuNhap fParent;
        private Guid _idKhoSelected;
        private DonDatHangDTO _ddh;
        public SFTaoPhieuNhap(SFPhieuNhap f, DonDatHangDTO ddh)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            fParent = f;
            _ddh = ddh;
            InitData();
        }
        private void InitData()
        {
            var kho = _Context.Kho.ToList();
            cbxKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKho.ValueMember = "Id";
            cbxKho.DisplayMember = "Ten";
            cbxKho.DataSource = kho;
            cbxKho.SelectedIndex = 0;
            cbxKho.SelectedValue = _ddh.Idk;
        }
        private Phieunhap GetData()
        {
            return new Phieunhap
            {
                Id = Guid.NewGuid(),
                Idddh = _ddh.Id,
                Ngaylap = DateTime.Now,
                Manv = Program.username,
                Idk = _idKhoSelected
            };
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Hide();
            fParent.CreatedNewItem(GetData());
            Close();
        }
        private void cbxKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idKhoSelected = ((Kho)cbxKho.SelectedItem).Id;
        }
    }
}
