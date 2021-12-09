using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Chinhanh
    {
        public Chinhanh()
        {
            Khachhang = new HashSet<Khachhang>();
            Kho = new HashSet<Kho>();
            Nhanvien = new HashSet<Nhanvien>();
        }

        public string Macn { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<Khachhang> Khachhang { get; set; }
        public virtual ICollection<Kho> Kho { get; set; }
        public virtual ICollection<Nhanvien> Nhanvien { get; set; }
    }
}
