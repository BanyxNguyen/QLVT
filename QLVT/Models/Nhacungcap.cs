using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Dondathang = new HashSet<Dondathang>();
        }

        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }

        public virtual ICollection<Dondathang> Dondathang { get; set; }
    }
}
