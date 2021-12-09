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
    public partial class UCNhanVien : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<Nhanvien> Nhanviens { get; set; }
        public UCNhanVien()
        {
            InitializeComponent();
            if (!Program.IsDev)
            {
                _Context = QLVTContext.Create(Program.connStr);
            }
        }
        private void LoadData()
        {
            //Nhanviens = _Context.Nhanvien.Where(x => x.Ttxoa == 0)
            //                           .ToList();
            Nhanviens = _Context.Nhanvien.ToList();
            dgvNhanVien.DataSource = Nhanviens;
            Program.macn = Nhanviens[0].Macn;
            LoadChiNhanh();
        }
        private void LoadChiNhanh()
        {
            cmbBranch.DataSource = Program.bds_dspm;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.SelectedIndex = Program.branchIndex;
            CheckCotrol();
        }
        private void CheckCotrol()
        {
            if (Program.group == "CONGTY")
            {
                cmbBranch.Enabled = true;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                cmbBranch.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        public void CreatedNewNhanVien(Nhanvien nv)
        {
            try
            {
                _Context.Nhanvien.Add(nv);
                var res = _Context.SaveChanges();
                if (res > 0)
                {
                    LoadData();
                }
                else
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Them that bai!");
            }
        }
        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev)
            {
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Xin vui long xac nhan de xoa?";
            string title = "Thong Bao";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No) return;

            if (dgvNhanVien.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }

            var NhanVien = dgvNhanVien.SelectedRows[0].DataBoundItem as Nhanvien;

            //var nv = _Context.Nhanvien.FirstOrDefault(x => x.Manv == NhanVien.Manv);
            //if (nv == null)
            //{
            //    return;
            //}
            try
            {
                _Context.Nhanvien.Remove(NhanVien);
                var res = _Context.SaveChanges();
                if (res > 0)
                {
                    LoadData();
                }
                else
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa that bai!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap nhat thanh cong!", "", MessageBoxButtons.OK);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFNhanVien f = new SFNhanVien(this);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SFNhanVien f = new SFNhanVien(this);
            f.ShowDialog();
        }
    }
}
