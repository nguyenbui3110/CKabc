using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.DTO;
namespace CK.BLL
{
    public class BLL_HocPhanSV:BLL
    {
        private static BLL_HocPhanSV _Instance;
        public static BLL_HocPhanSV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_HocPhanSV();
                return _Instance;
            }

        }
        public List<HocPhan_SV> GetInfoBySearchBox(string TenSV,string MaHocPhan)
        {
            
               var query = from c in db.HocPhan_SVs where c.SV.Name.Contains(TenSV.ToString()) select c;
    
            if(MaHocPhan != null && MaHocPhan != "")
            {
                query = from c in db.HocPhan_SVs where c.HocPhan.MaHocPhan == MaHocPhan select c;
            }
            return query.ToList();

        }
    }
}
