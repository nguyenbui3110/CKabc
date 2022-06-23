using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DTO
{
    public class HocPhan_SV
    {
        [Key][Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public DateTime NgayThi { get; set; }
        [ForeignKey("HocPhan")]
        public string MaHocPhan { get; set; }
        [ForeignKey("SV")]
        public string MSSV { get; set; }
        public virtual SV SV { get; set; }
        public virtual HocPhan HocPhan { get; set; }


    }
}
