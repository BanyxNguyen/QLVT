using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Phieunhap
    {
        public Phieunhap()
        {
            Ctpn = new HashSet<Ctpn>();
        }

        public Guid Id { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Manv { get; set; }
        public Guid? Idddh { get; set; }
        public Guid? Idk { get; set; }

        public virtual Dondathang IdddhNavigation { get; set; }
        public virtual Kho IdkNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
        public virtual ICollection<Ctpn> Ctpn { get; set; }
    }
}
