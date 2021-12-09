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
            ListItems = _Context.Cthd
                .Where(x => x.Idhd == HoaDonItem.Id)
                .Include(x => x.IdhhNavigation)
                .Select(x => new CTHoaDonDTO
                {
                    Idhh = x.Idhh,
                    Tenhh = x.IdhhNavigation.Ten,
                    Idhd = x.Idhd,
                    Dongia = x.Dongia,
                    Sl = x.Sl
                }).ToList();
            dgvData.DataSource = ListItems;
        }
        private void SFHoaDonEdit_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }
        private void cbxKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idKhoSelected = ((Kho)cbxKho.SelectedItem).Id;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap nhat thanh cong!", "", MessageBoxButtons.OK);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Xin vui long xac nhan de xoa?";
            string title = "Xoa CTDDH";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No) return;

            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as CTHoaDonDTO;
            try
            {
                var ct = _Context.Cthd
                    .Where(x => x.Idhh == cell.Idhh && x.Idhd == x.Idhd)
                    .FirstOrDefault();
                if(ct != null)
                {
                    _Context.Cthd.Remove(ct);
                    var res = _Context.SaveChanges();
                    if(res > 0)
                    {
                        LoadData();
                        MessageBox.Show("Xoa Thanh Cong");
                    }
                }
            }
            catch(Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show("Them Chi Tiet Don Hang that bai!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFTaoHangHoaTrenPhieu f = new SFTaoHangHoaTrenPhieu();
            f.ShowDialog();
            if (!f.isSubmit) { f.Close(); return; }
            //MessageBox.Show(f.SL + "@@" + f.DonGia + "@@" + f.Idhh.ToString(), "", MessageBoxButtons.OK);
            try
            {
                _Context.Cthd.Add(new Cthd
                {
                    Idhh = f.Idhh,
                    Idhd = HoaDonItem.Id,
                    Sl = f.SL,
                    Dongia = f.DonGia
                });
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                f.Close();
            }
            catch (Exception)
            {
                _Context.ResetState();
                f.Close();
                MessageBox.Show("Them Chi Tiet Don Hang that bai!");
            }
        }
    }
}
