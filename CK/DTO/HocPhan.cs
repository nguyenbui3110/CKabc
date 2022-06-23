using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DTO
{
    public class HocPhan
    {
        public HocPhan()
        {
            this.HocPhan_SVs= new HashSet<HocPhan_SV>();
        }
        [Key][Required]
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }
        public virtual ICollection<HocPhan_SV> HocPhan_SVs { get; set; }
    }
}
