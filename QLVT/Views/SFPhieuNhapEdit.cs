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
    public partial class SFPhieuNhapEdit : Form
    {
        private readonly QLVTContext _Context;
        private readonly SFPhieuNhap fParent;
        private Guid _idKhoSelected;
        private Phieunhap _PhieuNhap;
        private int slMax;
        public IList<CTPhieuNhapDTO> ListCTPhieuNhap { get; set; }
        public IList<Ctpn> ListCPhieuNhapReal { get; set; }
        public SFPhieuNhapEdit(SFPhieuNhap f, Phieunhap p)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            fParent = f;
            _PhieuNhap = p;
            lbIdPhieuNhap.Text = _PhieuNhap.Id.ToString();
            InitData();
        }
        private Ctpn GetCtPhieuNhap(Guid Idpn, Guid Idhh)
        {
            return ListCPhieuNhapReal.Where(x => x.Idhh == Idhh && x.Idpn == Idpn).FirstOrDefault();
        }
        private int GetSLCtPhieuNhap(Guid Idpn, Guid Idhh)
        {
            var t = GetCtPhieuNhap(Idpn, Idhh);
            if (t == null) return 0;
            else return t.Sl;
        }
        private void LoadData()
        {
            //ListCPhieuNhapReal = _Context.Ctpn
            //    .Include(x => x.IdhhNavigation)
            //    .Where(x => x.Idpn == _PhieuNhap.Id)
            //    .ToList();
            ListCPhieuNhapReal = _Context.Phieunhap
                .Where(x => x.Idddh == _PhieuNhap.Idddh)
                .Join(_Context.Ctpn, pn => pn.Id, ct => ct.Idpn, (pn, ct) => new Ctpn
                {
                    Idhh = ct.Idhh,
                    Idpn = ct.Idpn,
                    Sl = ct.Sl,
                })
                .ToList();
            ListCTPhieuNhap = _Context.Ctddh
                .Include(x => x.IdhhNavigation)
                .Where(x => x.Idddh == _PhieuNhap.Idddh)
                .Select(x => new CTPhieuNhapDTO
                {
                    Idhh = x.Idhh,
                    Tenhh = x.IdhhNavigation.Ten,
                    Dongia = x.Dongia,
                    Sl = x.Sl,
                    SLNhap = 0
                }).ToList();
            foreach (Ctpn ct in ListCPhieuNhapReal)
            {
                var t = ListCTPhieuNhap.Where(x => x.Idhh == ct.Idhh).FirstOrDefault();
                if (t != null)
                {
                    t.SLDaNhap += ct.Sl;
                    if (ct.Idpn == _PhieuNhap.Id) t.SLNhapCuaPhieuNhap = ct.Sl;
                }
            }
            dgvData.DataSource = ListCTPhieuNhap;
        }
        private void InitData()
        {
            var kho = _Context.Kho.ToList();
            cbxKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKho.ValueMember = "Id";
            cbxKho.DisplayMember = "Ten";
            cbxKho.DataSource = kho;
            cbxKho.SelectedIndex = 0;
            cbxKho.Enabled = false;
            cbxKho.SelectedValue = _PhieuNhap.Idk;
        }
        private void SFEditPhieuNhap_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }
        private void btnXetSL_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as CTPhieuNhapDTO;
            var obj = ListCTPhieuNhap.FirstOrDefault(x => x.Idhh == cell.Idhh && x.Idpn == cell.Idpn);
            int sl = Convert.ToInt32(Math.Round(nudSL.Value, 0));
            if (obj != null && sl < slMax && sl > 0)
            {
                obj.SLNhap = sl;
            }
            else
            {
                MessageBox.Show("So luong nhap phai nam trong khoan tu 1 den "+ slMax.ToString());
                nudSL.Value = 0;
                return;
            }
            nudSL.Value = 0;
            dgvData.DataSource = ListCTPhieuNhap;
            dgvData.Refresh();
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvData.SelectedRows[0].DataBoundItem as CTPhieuNhapDTO;
            slMax = cell.Sl - cell.SLDaNhap;
            if (slMax == 0)
            {
                pnXetSL.Enabled = false;
                return;
            }
            nudSL.Value = cell.SLNhap;
            lbXetSL.Text = "0 < SL <= " + slMax.ToString();
            pnXetSL.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<Ctpn> tCreate = new List<Ctpn>();
            List<Ctpn> tUpdate = new List<Ctpn>();
            foreach (CTPhieuNhapDTO item in ListCTPhieuNhap)
            {
                if (item.SLNhap > 0)
                {
                    var t = _Context.Ctpn.Where(x => x.Idhh == item.Idhh && x.Idpn == _PhieuNhap.Id).FirstOrDefault();
                    if (t != null)
                    {
                        tUpdate.Add(new Ctpn
                        {
                            Idhh = item.Idhh,
                            Idpn = _PhieuNhap.Id,
                            Sl = item.SLNhap,
                            Dongia = item.Dongia
                        });
                    }
                    else
                    {
                        tCreate.Add(new Ctpn
                        {
                            Idhh = item.Idhh,
                            Idpn = _PhieuNhap.Id,
                            Sl = item.SLNhap,
                            Dongia = item.Dongia
                        });
                    }
                }
            }
            try
            {
                _Context.Ctpn.UpdateRange(tUpdate);
                _Context.Ctpn.AddRange(tCreate);
                _Context.SaveChanges();
                Close();
            }
            catch(Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
