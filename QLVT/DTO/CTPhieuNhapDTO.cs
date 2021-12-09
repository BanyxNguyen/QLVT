using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class CTPhieuNhapDTO
    {
        public Guid Idhh { get; set; }
        public string Tenhh { get; set; }
        public Guid Idpn { get; set; }
        public int Dongia { get; set; }
        public int Sl { get; set; }
        public int SLDaNhap { get; set; }
        public int SLNhapCuaPhieuNhap { get; set; }
        public int SLNhap { get; set; }

        public virtual Hanghoa IdhhNavigation { get; set; }
        public virtual Phieunhap IdpnNavigation { get; set; }
    }
}
