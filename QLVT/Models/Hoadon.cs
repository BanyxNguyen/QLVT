using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Cthd = new HashSet<Cthd>();
        }

        public Guid Id { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Manv { get; set; }
        public Guid? Idk { get; set; }
        public Guid? Idkh { get; set; }

        public virtual Kho IdkNavigation { get; set; }
        public virtual Khachhang IdkhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual ICollection<Cthd> Cthd { get; set; }
    }
}
