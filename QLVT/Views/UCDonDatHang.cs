using Microsoft.EntityFrameworkCore.Storage;
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
using QLVT.Extensions;
namespace QLVT.Views
{
    public partial class UCDonDatHang : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<DonDatHangDTO> ListItems { get; set; }
        public UCDonDatHang()
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
        }
        private void SaveChanges(string mes)
        {
            var res = _Context.SaveChanges();
            if (res > 0) LoadData();
            else throw new Exception(mes);
        }
        private void LoadData()
        {
            ListItems = _Context.Dondathang
                .Include(x => x.ManvNavigation)
                .Include(x => x.IdnccNavigation)
                .Include(x => x.IdkNavigation)
                .Select(x => new DonDatHangDTO
                {
                    Id = x.Id,
                    Ngaylap = x.Ngaylap,
                    Manv = x.Manv,
                    TenNVLapPhieu = x.ManvNavigation.Ho + " " + x.ManvNavigation.Ten,
                    Idncc = x.Idncc,
                    TenNCC = x.IdnccNavigation.Ten,
                    Idk = x.Idk,
                    TenKho = x.IdkNavigation.Ten
                })
                .AsNoTracking()
                .OrderBy(x=>x.Ngaylap)
                .ToList();
            dgvData.DataSource = ListItems;
        }
        private bool CheckSelectedDGV()
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private Dondathang GetItemFromDGV()
        {
            var cell = dgvData.SelectedRows[0].DataBoundItem as DonDatHangDTO;
            return _Context.Dondathang.Where(x => x.Id == cell.Id).FirstOrDefault();
        }
        public void CreatedNewItem(Dondathang item)
        {
            try
            {
                _Context.Dondathang.Add(item);
                SaveChanges("Tao Don Hang That Bat");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them Loai Vat Tu that bai!");
            }
        }
        public void EditItem(Dondathang item)
        {
            try
            {
                _Context.Dondathang.Update(item);
                SaveChanges("Cap Nhat Don Hang That Bat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UCDonDatHang_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap nhat thanh cong!", "", MessageBoxButtons.OK);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFDonDatHang f = new SFDonDatHang(this);
            f.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedDGV()) return;
            try
            {
                SFDonDatHangEdit f = new SFDonDatHangEdit(this, GetItemFromDGV());
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message, "Thong tin", MessageBoxButtons.OK);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Xin vui long xac nhan de xoa?";
            string title = "Xoa CTDDH";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No) return;

            if (!CheckSelectedDGV()) return;
            try
            {
                var t = GetItemFromDGV();
                if (t == null) return;
                _Context.Dondathang.Remove(t);
                SaveChanges("Xoa Don Hang That Bai");
                LoadData();
                MessageBox.Show("Xoa thanh cong!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message, "Thong tin", MessageBoxButtons.OK);
            }
        }
        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedDGV()) return;
            var t = dgvData.SelectedRows[0].DataBoundItem as DonDatHangDTO;
            if (t == null) return;
            SFPhieuNhap f = new SFPhieuNhap(t);
            f.ShowDialog();
        }
    }
}
