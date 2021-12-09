using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class HoaDonDTO
    {
        public Guid Id { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Manv { get; set; }
        public string Tennv { get; set; }
        public Guid? Idk { get; set; }
        public string Tenk { get; set; }
        public Guid? Idkh { get; set; }
        public string Tenkh { get; set; }

        public virtual Kho IdkNavigation { get; set; }
        public virtual Khachhang IdkhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
