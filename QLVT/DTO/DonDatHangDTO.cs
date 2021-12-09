using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class DonDatHangDTO
    {
        public Guid Id { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Manv { get; set; }
        public string TenNVLapPhieu { get; set; }
        public Guid? Idncc { get; set; }
        public string TenNCC { get; set; }
        public Guid? Idk { get; set; }
        public string TenKho { get; set; }

        public virtual Kho IdkNavigation { get; set; }
        public virtual Nhacungcap IdnccNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
