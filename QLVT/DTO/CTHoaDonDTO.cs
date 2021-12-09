using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class CTHoaDonDTO
    {
        public Guid Idhh { get; set; }
        public string Tenhh { get; set; }
        public Guid Idhd { get; set; }
        public int Dongia { get; set; }
        public int Sl { get; set; }

        public virtual Hoadon IdhdNavigation { get; set; }
        public virtual Hanghoa IdhhNavigation { get; set; }
    }
}
