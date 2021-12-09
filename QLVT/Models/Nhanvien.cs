using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Dondathang = new HashSet<Dondathang>();
            Hoadon = new HashSet<Hoadon>();
            Phieunhap = new HashSet<Phieunhap>();
        }

        public string Manv { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public int? Luong { get; set; }
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public int? Phai { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public int? Ttxoa { get; set; }
        public string Macn { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Chinhanh MacnNavigation { get; set; }
        public virtual ICollection<Dondathang> Dondathang { get; set; }
        public virtual ICollection<Hoadon> Hoadon { get; set; }
        public virtual ICollection<Phieunhap> Phieunhap { get; set; }
    }
}
