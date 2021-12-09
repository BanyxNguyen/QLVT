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
    public partial class UCHoaDon : UserControl
    {
        private readonly QLVTContext _Context;
        public IList<HoaDonDTO> ListItems { get; set; }
        public UCHoaDon()
        {
            InitializeComponent();
            if (!Program.IsDev) _Context = QLVTContext.Create(Program.connStr);
        }
        private void LoadData()
        {
            ListItems = _Context.Hoadon
                .Include(x => x.IdkNavigation)
                .Include(x => x.IdkhNavigation)
                .Include(x => x.ManvNavigation)
                .OrderBy(x => x.Ngaylap)
                .Select(x => new HoaDonDTO
                {
                    Id = x.Id,
                    Idk = x.Idk,
                    Idkh = x.Idkh,
                    Ngaylap = x.Ngaylap,
                    Manv = x.Manv,
                    Tenk = x.IdkNavigation.Ten,
                    Tenkh = x.IdkhNavigation.Ten,
                    Tennv = x.ManvNavigation.Ho + " " + x.ManvNavigation.Ten
                })
                .ToList();
            dgvData.DataSource = ListItems;
        }
        private void UCHoaDon_Load(object sender, EventArgs e)
        {
            if (!Program.IsDev) LoadData();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Cap Nhat Thanh Cong!");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
