using CK.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.Entity
{
    public class createDB : CreateDatabaseIfNotExists<QLDiem>
    {
        protected override void Seed(QLDiem context)
        {
            context.HocPhans.AddRange(new HocPhan[]
            {
                new HocPhan{MaHocPhan="BK01",TenHocPhan="Thiết Kế HĐT"},
                new HocPhan{MaHocPhan="BK02",TenHocPhan="Lập trình Java"},
                new HocPhan{MaHocPhan="BK03",TenHocPhan="Lập trình C#"},
            });
            context.SVs.AddRange(new SV[]
            {
                new SV{MSSV="102200201",Name="NVA",LopSH="20tclcdt5"},
                new SV{MSSV="102200202",Name="NVb",LopSH="20tclcdt4"},
                new SV{MSSV="102200203",Name="NVc",LopSH="20tclcdt3"},
                new SV{MSSV="102200204",Name="NVd",LopSH="20tclcdt2"},
                new SV{MSSV="102200205",Name="NVe",LopSH="20tclcdt1"},

            });
            context.SaveChanges();
            context.HocPhan_SVs.AddRange(new HocPhan_SV[]
            {
                new HocPhan_SV{MaHocPhan="BK01",MSSV="102200201",DiemBT=1,DiemCK=10,DiemGK=5,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK02",MSSV="102200201",DiemBT=2,DiemCK=9,DiemGK=6,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK03",MSSV="102200201",DiemBT=3,DiemCK=8,DiemGK=7,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK01",MSSV="102200202",DiemBT=4,DiemCK=7,DiemGK=8,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK02",MSSV="102200202",DiemBT=5,DiemCK=6,DiemGK=9,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK03",MSSV="102200202",DiemBT=6,DiemCK=5,DiemGK=9,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK01",MSSV="102200203",DiemBT=7,DiemCK=5,DiemGK=7,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK02",MSSV="102200203",DiemBT=8,DiemCK=6,DiemGK=8,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK03",MSSV="102200203",DiemBT=9,DiemCK=7,DiemGK=5,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK01",MSSV="102200204",DiemBT=1,DiemCK=8,DiemGK=6,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK02",MSSV="102200204",DiemBT=2,DiemCK=9,DiemGK=6,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK03",MSSV="102200204",DiemBT=3,DiemCK=9,DiemGK=3,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK01",MSSV="102200205",DiemBT=4,DiemCK=7,DiemGK=3,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK02",MSSV="102200205",DiemBT=5,DiemCK=6,DiemGK=3,NgayThi=DateTime.Now},
                new HocPhan_SV{MaHocPhan="BK03",MSSV="102200205",DiemBT=6,DiemCK=5,DiemGK=1,NgayThi=DateTime.Now}

            });
            context.SaveChanges();
        }
    }
}
