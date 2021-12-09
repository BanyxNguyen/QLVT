using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Hanghoa
    {
        public Hanghoa()
        {
            Ctddh = new HashSet<Ctddh>();
            Cthd = new HashSet<Cthd>();
            Ctpn = new HashSet<Ctpn>();
        }

        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public Guid? Idlhh { get; set; }

        public virtual Loaihh IdlhhNavigation { get; set; }
        public virtual ICollection<Ctddh> Ctddh { get; set; }
        public virtual ICollection<Cthd> Cthd { get; set; }
        public virtual ICollection<Ctpn> Ctpn { get; set; }
    }
}
