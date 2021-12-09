using QLVT.Extensions;
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
    public partial class UCNhaCC : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<Nhacungcap> ListItems { get; set; }
        public UCNhaCC()
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
        }
        private void LoadData()
        {
            ListItems = _Context.Nhacungcap.ToList();
            dgvData.DataSource = ListItems;
        }
        public void CreatedNewItem(Nhacungcap item)
        {
            try
            {
                _Context.Nhacungcap.Add(item);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Them Loai Vat Tu that bai!");
            }
        }
        public void EditItem(Nhacungcap item)
        {
            try
            {
                _Context.Nhacungcap.Update(item);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Cap nhat Loai Vat Tu that bai!");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap nhat thanh cong!", "", MessageBoxButtons.OK);
        }
        private void UCNhaCC_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFNhaCC f = new SFNhaCC(this);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var item = dgvData.SelectedRows[0].DataBoundItem as Nhacungcap;
            SFNhaCC f = new SFNhaCC(this);
            f.EnabledEdit(item);
            f.ShowDialog();
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

            try
            {
                var item = dgvData.SelectedRows[0].DataBoundItem as Nhacungcap;
                _Context.Nhacungcap.Remove(item);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
            }
            catch (Exception ex)
            {
                _Context.ResetState();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
