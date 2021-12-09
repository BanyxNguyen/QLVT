using QLVT.DTO;
using QLVT.Extensions;
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
    public partial class SFSuaPhieuNhap : Form
    {
        private readonly QLVTContext _Context;
        private PhieuNhapDTO PhieuNhapItem;
        private int numMax;
        public IList<CTPhieuNhapDTO> ListItems { get; set; }
        public SFSuaPhieuNhap(PhieuNhapDTO data)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            PhieuNhapItem = data;
        }
        private void LoadData()
        {
            // lay tat ca ctddh thuoc don dat hang ID
            ListItems = _Context.Ctddh
                .Where(x => x.Idddh == PhieuNhapItem.Idddh)
                .Include(x => x.IdhhNavigation)
                .Select(x => new CTPhieuNhapDTO
                {
                    Idhh = x.Idhh,
                    Tenhh = x.IdhhNavigation.Ten,
                    Dongia = x.Dongia,
                    Sl = x.Sl,
                })
                .ToList();
            // lay tat ca ctpn thuoc don dat hang ID
            var ctpns = _Context.Phieunhap
                .Where(x => x.Idddh == PhieuNhapItem.Idddh)
                .Join(
                    _Context.Ctpn,
                    pn => pn.Id,
                    ctpn => ctpn.Idpn,
                    (pn, ctpn) => new Ctpn
                    {
                        Idhh = ctpn.Idhh,
                        Idpn = pn.Id,
                        Sl = ctpn.Sl,
                        Dongia = ctpn.Dongia
                    }
                )
                .Include(x => x.IdhhNavigation)
                .ToList();
            foreach (Ctpn item in ctpns)
            {
                var res = ListItems.Where(x => x.Idhh == item.Idhh).FirstOrDefault();
                if (res != null) res.SLDaNhap += item.Sl;
                if (item.Idpn == PhieuNhapItem.Id) res.SLNhapCuaPhieuNhap = item.Sl;
            }

            dgvData.DataSource = ListItems;
        }

        private void SFSuaPhieuNhap_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Math.Round(nudSL.Value, 0));
            if (num < 0 || numMax < num)
            {
                MessageBox.Show("Vui long nhap lai!");
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as CTPhieuNhapDTO;
            var res = ListItems.Where(x => x.Idhh == cell.Idhh).FirstOrDefault();
            if (res != null)
            {
                res.SLNhap = num;
                dgvData.DataSource = ListItems;
                dgvData.Refresh();
                nudSL.Value = 1;
            }
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvData.SelectedRows[0].DataBoundItem as CTPhieuNhapDTO;
            numMax = cell.Sl - cell.SLDaNhap;
            lbSL.Text = "0 < SL < " + numMax;
            if (cell.SLNhapCuaPhieuNhap > 0) pnSL.Enabled = false;
            else pnSL.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap Nhat Thanh Cong!");
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
            List<Ctpn> tAdd = new List<Ctpn>();
            foreach (CTPhieuNhapDTO item in ListItems)
            {
                if (item.SLNhap > 0)
                {
                    tAdd.Add(new Ctpn
                    {
                        Idhh = item.Idhh,
                        Idpn = PhieuNhapItem.Id,
                        Sl = item.SLNhap,
                        Dongia = item.Dongia
                    });
                }
            }
            try
            {
                _Context.Ctpn.AddRange(tAdd);
                var res = _Context.SaveChanges();
                if (res > 0) Close();
            }
            catch (Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
