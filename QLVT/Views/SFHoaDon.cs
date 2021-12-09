using QLVT.Extensions;
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
    public partial class SFHoaDon : Form
    {
        private readonly QLVTContext _Context;
        private readonly UCDonDatHang fParent;
        private Guid _idKhoSelected;
        private Khachhang KhachhangItem;
        public SFHoaDon(Khachhang kh)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            KhachhangItem = kh;
            InitData();
        }
        private Hoadon GetData()
        {
            return new Hoadon
            {
                Id = new Guid(),
                Ngaylap = DateTime.Now,
                Manv = Program.username,
                Idk = _idKhoSelected,
                Idkh = KhachhangItem.Id
            };
        }
        private void InitData()
        {
            var kho = _Context.Kho.ToList();
            cbxKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKho.ValueMember = "Id";
            cbxKho.DisplayMember = "Ten";
            cbxKho.DataSource = kho;
            cbxKho.SelectedIndex = 0;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetData();
                _Context.Hoadon.Add(t);
                _Context.SaveChanges();
                // TODO: add form edit
                Close();
            }
            catch(Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idKhoSelected = ((Kho)cbxKho.SelectedItem).Id;
        }
    }
}
