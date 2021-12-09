using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class VatTuDTO
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public Guid? Idlhh { get; set; }
        public string LoaiHang { get; set; }
    }
}
