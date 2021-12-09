using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Dondathang
    {
        public Dondathang()
        {
            Ctddh = new HashSet<Ctddh>();
            Phieunhap = new HashSet<Phieunhap>();
        }

        public Guid Id { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Manv { get; set; }
        public Guid? Idncc { get; set; }
        public Guid? Idk { get; set; }

        public virtual Kho IdkNavigation { get; set; }
        public virtual Nhacungcap IdnccNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual ICollection<Ctddh> Ctddh { get; set; }
        public virtual ICollection<Phieunhap> Phieunhap { get; set; }
    }
}
