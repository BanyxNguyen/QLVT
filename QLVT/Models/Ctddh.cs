using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Ctddh
    {
        public Guid Idhh { get; set; }
        public Guid Idddh { get; set; }
        public int Dongia { get; set; }
        public int Sl { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Dondathang IdddhNavigation { get; set; }
        public virtual Hanghoa IdhhNavigation { get; set; }
    }
}
