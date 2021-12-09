using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class KhachHangDTO
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public string Macn { get; set; }
        public string Tencn { get; set; }

        public virtual Chinhanh MacnNavigation { get; set; }
    }
}
