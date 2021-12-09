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
    public partial class SFDonDatHangEdit : Form
    {
        private readonly QLVTContext _Context;
        private readonly UCDonDatHang fParent;
        public IList<CTDonDatHangDTO> ListItems { get; set; }
        private Dondathang _Ddh;
        private Guid _idKhoSelected;
        private Guid _idNhaCCSelected;
        public SFDonDatHangEdit(UCDonDatHang uc, Dondathang ddh)
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
            fParent = uc;
            _Ddh = ddh;
            InitData();
        }
        private void LoadData()
        {
            ListItems = _Context.Ctddh
                .Where(x => x.Idddh == _Ddh.Id)
                .Include(x => x.IdhhNavigation)
                .Select(x => new CTDonDatHangDTO
                {
                    Idhh = x.Idhh,
                    TenHH = x.IdhhNavigation.Ten,
                    Idddh = x.Idddh,
                    Dongia = x.Dongia,
                    Sl = x.Sl
                }).ToList();
            dgvData.DataSource = ListItems;
        }
        private void InitData()
        {
            var ncc = _Context.Nhacungcap.ToList();
            cbxNhaCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNhaCC.ValueMember = "Id";
            cbxNhaCC.DisplayMember = "Ten";
            cbxNhaCC.DataSource = ncc;
            cbxNhaCC.SelectedIndex = 0;

            var kho = _Context.Kho.ToList();
            cbxKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKho.ValueMember = "Id";
            cbxKho.DisplayMember = "Ten";
            cbxKho.DataSource = kho;
            cbxKho.SelectedIndex = 0;

            cbxNhaCC.SelectedValue = _Ddh.Idncc;
            cbxKho.SelectedValue = _Ddh.Idk;
        }
        private DialogResult CheckNotifySubmit()
        {
            string message = "Luu cac thay doi va thoat?";
            string title = "Thong bao";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
        private void AddItem()
        {
            var cell = dgvData.SelectedRows[0].DataBoundItem as CTDonDatHangDTO;
            var item = _Context.Ctddh.Where(x => x.Idhh == cell.Idhh && x.Idddh == cell.Idddh).ToArray();
            if (item.Length <= 0)
            {
                MessageBox.Show("Vui long chon lai dong du lieu!", "Thong tin", MessageBoxButtons.OK);
            }
            try
            {
                _Context.Ctddh.Remove(item[0]);
                _Context.SaveChanges();
                MessageBox.Show("Xoa Chi Tiet Thanh Cong", "", MessageBoxButtons.OK);
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa Chi Tiet Khong Thanh Cong, Vui long thu lai", "", MessageBoxButtons.OK);
            }

        }
        private void SFDonDatHangEdit_Load(object sender, EventArgs e)
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
            if (CheckNotifySubmit() == DialogResult.No) return;
            _Ddh.Idncc = _idNhaCCSelected;
            _Ddh.Idk = _idKhoSelected;
            fParent.EditItem(_Ddh);
            Close();
        }
        private void cbxNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idNhaCCSelected = ((Nhacungcap)cbxNhaCC.SelectedItem).Id;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFTaoHangHoaTrenPhieu f = new SFTaoHangHoaTrenPhieu();
            f.ShowDialog();
            if (!f.isSubmit)
            {
                f.Close();
                return;
            }
            //MessageBox.Show(f.SL + "@@" + f.DonGia + "@@" + f.Idhh.ToString(), "", MessageBoxButtons.OK);
            try
            {
                _Context.Ctddh.Add(new Ctddh
                {
                    Idhh = f.Idhh,
                    Idddh = _Ddh.Id,
                    Sl = f.SL,
                    Dongia = f.DonGia
                });
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Them Chi Tiet Don Hang that bai!");
            }

            f.Close();
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
            AddItem();
        }
    }
}
