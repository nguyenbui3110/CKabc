using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DTO
{
    public class SV
    {
        public SV()
        {
            this.HocPhan_SVs = new HashSet<HocPhan_SV>();
        }
        [Key][Required]
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string LopSH { get; set; }
        public bool Gender { get; set; }
        public virtual ICollection<HocPhan_SV> HocPhan_SVs { get; set; }

    }
}
