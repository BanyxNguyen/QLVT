using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class Loaihh
    {
        public Loaihh()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }

        public Guid Id { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
