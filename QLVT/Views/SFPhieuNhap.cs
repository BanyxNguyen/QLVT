using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class SFPhieuNhap : Form
    {
        private readonly QLVTContext _Context;
        DonDatHangDTO DonDatHang;
        public IList<PhieuNhapDTO> ListItems { get; set; }
        public SFPhieuNhap(DonDatHangDTO ddh)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            DonDatHang = ddh;
            InitData();
        }
        private void InitData()
        {
            lbIdHoaDon.Text = DonDatHang.Id.ToString();
        }
        private void LoadData()
        {
            ListItems = _Context.Phieunhap
                .Where(x => x.Idddh == DonDatHang.Id)
                .Include(x => x.IdkNavigation)
                .Include(x => x.ManvNavigation)
                .Select(x => new PhieuNhapDTO
                {
                    Id = x.Id,
                    Ngaylap = x.Ngaylap,
                    Manv = x.Manv,
                    TenNV = x.ManvNavigation.Ho + " " + x.ManvNavigation.Ten,
                    Idddh = x.Idddh,
                    Idk = x.Idk,
                    TenKho = x.IdkNavigation.Ten
                })
                .OrderBy(x => x.Ngaylap)
                .ToList();
            dgvData.DataSource = ListItems;
            LoadDataVatTu();
        }
        private void LoadDataVatTu()
        {
            // lay tat ca ctddh thuoc don dat hang ID
            var ctddhs = _Context.Ctddh.Where(x => x.Idddh == DonDatHang.Id)
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
                .Where(x => x.Idddh == DonDatHang.Id)
                .Join(
                    _Context.Ctpn,
                    pn => pn.Id,
                    ctpn => ctpn.Idpn,
                    (pn, ctpn) => new Ctpn
                    {
                        Idhh = ctpn.Idhh,
                        Idpn = ctpn.Idpn,
                        Sl = ctpn.Sl,
                        Dongia = ctpn.Dongia
                    }
                )
                .Include(x => x.IdhhNavigation)
                .ToList();
            foreach (Ctpn item in ctpns)
            {
                var res = ctddhs.Where(x => x.Idhh == item.Idhh).FirstOrDefault();
                if (res != null) res.SLDaNhap += item.Sl;
            }
            dgvDataVatTu.DataSource = ctddhs;
        }
        public void CreatedNewItem(Phieunhap p)
        {
            try
            {
                _Context.Phieunhap.Add(p);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                var t = ListItems.Where(x => x.Id == p.Id).FirstOrDefault();
                if(t != null)
                {
                    SFSuaPhieuNhap f = new SFSuaPhieuNhap(t);
                    f.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }
        private void RemovePN(PhieuNhapDTO pn)
        {
            try
            {
                var cts = _Context.Ctpn.Where(x => x.Idpn == pn.Id).ToList();
                var tPn = _Context.Phieunhap.Where(x => x.Id == pn.Id).FirstOrDefault();
                if (cts.Count > 0) _Context.Ctpn.RemoveRange(cts);
                if (tPn != null) _Context.Phieunhap.Remove(tPn);
                var res = _Context.SaveChanges();
                if(res > 0)
                {
                    MessageBox.Show("Xoa Thanh Cong");
                    LoadData();
                }
            }
            catch(Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }
        private void SFPhieuNhap_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap Nhat Thanh Cong");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFTaoPhieuNhap f = new SFTaoPhieuNhap(this, DonDatHang);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as PhieuNhapDTO;
            SFSuaPhieuNhap f = new SFSuaPhieuNhap(cell);
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Xin vui long xac nhan de xoa?";
            string title = "Thong Tin";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No) return;

            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as PhieuNhapDTO;
            RemovePN(cell);
        }
    }
}
