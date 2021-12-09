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
    public partial class SFHoaDonEdit : Form
    {
        private readonly QLVTContext _Context;
        public IList<CTHoaDonDTO> ListItems { get; set; }
        private Hoadon HoaDonItem;
        private Guid _idKhoSelected;
        public SFHoaDonEdit(Hoadon hd)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            HoaDonItem = hd;
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

            cbxKho.SelectedValue = HoaDonItem.Idk;
        }
        private void LoadData()
        {
            //ListItems = _Context.Ctddh
            //    .Where(x => x.Idddh == HoaDonItem.Id)
            //    .Include(x => x.IdhhNavigation)
            //    .Select(x => new CTDonDatHangDTO
            //    {
            //        Idhh = x.Idhh,
            //        TenHH = x.IdhhNavigation.Ten,
            //        Idddh = x.Idddh,
            //        Dongia = x.Dongia,
            //        Sl = x.Sl
            //    }).ToList();
            //dgvData.DataSource = ListItems;
        }
        private void SFHoaDonEdit_Load(object sender, EventArgs e)
        {

        }
        private void cbxKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idKhoSelected = ((Kho)cbxKho.SelectedItem).Id;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
