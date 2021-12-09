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
    public partial class UCKhachHang : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<KhachHangDTO> ListItems { get; set; }
        public UCKhachHang()
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
        }
        private void LoadData()
        {
            ListItems = _Context.Khachhang
                .Include(x => x.MacnNavigation)
                .Select(x=>new KhachHangDTO
                {
                    Id = x.Id,
                    Ten = x.Ten,
                    Diachi = x.Diachi,
                    Sdt = x.Sdt,
                    Macn = x.Macn,
                    Tencn = x.MacnNavigation.Ten
                })
                .ToList();
            dgvData.DataSource = ListItems;
        }
        public void CreatedNewItem(Khachhang k)
        {
            try
            {
                _Context.Khachhang.Add(k);
                // TODO create account database
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
            }
            catch (Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }
        public void EditItem(Khachhang k)
        {
            try
            {
                _Context.Khachhang.Update(k);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
            }
            catch (Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }
        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap Nhat Thanh Cong!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Xin vui long xac nhan de xoa?";
            string title = "Thong Bao";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No) return;

            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }

            //try
            //{
            //    var item = dgvData.SelectedRows[0].DataBoundItem as Khachhang;
            //    _Context.Khachhang.Update(item);
            //    var res = _Context.SaveChanges();
            //    if (res > 0) LoadData();
            //}
            //catch (Exception ex)
            //{
            //    _Context.ResetState();
            //    MessageBox.Show(ex.Message);
            //}
            MessageBox.Show("Xoa khong thanh cong!");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFKhachHang f = new SFKhachHang(this);
            f.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var item = dgvData.SelectedRows[0].DataBoundItem as KhachHangDTO;
            var res = _Context.Khachhang.Where(x => x.Id == item.Id).FirstOrDefault();
            if (res == null) return;
            SFKhachHang f = new SFKhachHang(this);
            f.EnabledEdit(res);
            f.ShowDialog();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var item = dgvData.SelectedRows[0].DataBoundItem as KhachHangDTO;
            var res = _Context.Khachhang.Where(x => x.Id == item.Id).FirstOrDefault();
            if (res == null) return;

            SFHoaDon f = new SFHoaDon(res);
            f.ShowDialog();
        }
    }
}
