using QLVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.DTO
{
    public class PhieuNhapDTO
    {
        public Guid Id { get; set; }
        public DateTime? Ngaylap { get; set; }
        public string Manv { get; set; }
        public string TenNV { get; set; }
        public Guid? Idddh { get; set; }
        public Guid? Idk { get; set; }
        public string TenKho { get; set; }

        public virtual Dondathang IdddhNavigation { get; set; }
        public virtual Kho IdkNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
