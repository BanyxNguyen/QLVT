using QLVT.DTO;
using QLVT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Views
{
    public partial class SFTaoHangHoaTrenPhieu : Form
    {
        private readonly QLVTContext _Context;
        public IList<VatTuDTO> ListItems { get; set; }
        public int SL;
        public int DonGia;
        public Guid Idhh;
        public bool isSubmit = false;
        public SFTaoHangHoaTrenPhieu()
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
        }
        private void LoadData()
        {
            ListItems = _Context.Hanghoa.Include(x => x.IdlhhNavigation).Select(x => new VatTuDTO
            {
                Id = x.Id,
                Ten = x.Ten,
                Mota = x.Mota,
                Idlhh = x.Idlhh,
                LoaiHang = x.IdlhhNavigation.Ten
            }).ToList();
            dgvData.DataSource = ListItems;
        }
        private void SFTaoHangHoaTrenPhieu_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
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
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as VatTuDTO;
            isSubmit = true;
            SL = int.Parse(txtSL.Text.Trim());
            DonGia = int.Parse(txtDonGia.Text.Trim());
            Idhh = cell.Id;
            Hide();
        }
    }
}
