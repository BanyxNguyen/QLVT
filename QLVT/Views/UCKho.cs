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
    public partial class UCKho : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<Kho> Khos { get; set; }
        public UCKho()
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
        }
        private void LoadData()
        {
            Khos = _Context.Kho.ToList();
            dgvKho.DataSource = Khos;
        }
        public void CreatedNewKho(Kho k)
        {
            try
            {
                _Context.Kho.Add(k);
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
                MessageBox.Show("Them Kho that bai!");
            }
        }
        public void EditKho(Kho k)
        {
            try
            {
                _Context.Kho.Update(k);
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
                MessageBox.Show("Cap nhat Kho that bai!");
            }
        }
        private void UCKho_Load(object sender, EventArgs e)
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
            SFKho sFKho = new SFKho(this);
            sFKho.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var kho = dgvKho.SelectedRows[0].DataBoundItem as Kho;
            try
            {
                string message = "Ban co muon xoa Kho " + kho.Ten + " khong?";
                string title = "Xoa Kho";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No) return;

                _Context.Kho.Remove(kho);
                var res = _Context.SaveChanges();

                if (res > 0) LoadData();
                else throw new Exception("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa Kho that bai!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKho.SelectedRows.Count < 1)
            {
                MessageBox.Show("Ban chua chon dong du lieu!", "Thong tin", MessageBoxButtons.OK);
                return;
            }
            var kho = dgvKho.SelectedRows[0].DataBoundItem as Kho;
            SFKho sFKho = new SFKho(this);
            sFKho.EnabledEdit(kho);
            sFKho.ShowDialog();
        }
    }
}
