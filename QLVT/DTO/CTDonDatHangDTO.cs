using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class CTDonDatHangDTO
    {
        public Guid Idhh { get; set; }
        public string TenHH { get; set; }
        public Guid Idddh { get; set; }
        public int Dongia { get; set; }
        public int Sl { get; set; }

        public virtual Dondathang IdddhNavigation { get; set; }
        public virtual Hanghoa IdhhNavigation { get; set; }
    }
}
