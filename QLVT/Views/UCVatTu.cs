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
    public partial class UCVatTu : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<VatTuDTO> ListItems { get; set; }
        public UCVatTu()
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
        public void CreatedNewItem(Hanghoa item)
        {
            try
            {
                _Context.Hanghoa.Add(item);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Them Loai Vat Tu that bai!");
            }
        }
        public void EditItem(Hanghoa item)
        {
            try
            {
                _Context.Hanghoa.Update(item);
                var res = _Context.SaveChanges();
                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Cap nhat Loai Vat Tu that bai!");
            }
        }
        private void UCVatTu_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap nhat thanh cong!", "", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as VatTuDTO;
            var h = _Context.Hanghoa.Where(x => x.Id == cell.Id).ToArray();
            if (h.Length <= 0)
            {
                MessageBox.Show("Vui long chon lai dong du lieu!", "Thong tin", MessageBoxButtons.OK);
            };
            try
            {
                string message = "Ban co muon xoa Vat Tu: '" + h[0].Ten + "' khong?";
                string title = "Xoa Vat Tu";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No) return;

                _Context.Hanghoa.Remove(h[0]);
                var res = _Context.SaveChanges();

                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa Kho that bai!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SFVatTu f = new SFVatTu(this);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var cell = dgvData.SelectedRows[0].DataBoundItem as VatTuDTO;
            var h = _Context.Hanghoa.Where(x => x.Id == cell.Id).ToArray();
            if (h.Length > 0)
            {
                SFVatTu f = new SFVatTu(this);
                f.EnabledEdit(h[0]);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long chon lai dong du lieu!", "Thong tin", MessageBoxButtons.OK);
            }
        }
    }
}
