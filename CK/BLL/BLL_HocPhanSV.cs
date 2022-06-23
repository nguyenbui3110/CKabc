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
        public HocPhan_SV find(int ID)
        {
            return db.HocPhan_SVs.Find(ID);
        }
        public List<HocPhan_SV> GetInfoBySearchBox(string TenSV,string TenHocPhan)
        {
            var query = from c in db.HocPhan_SVs select c;

            if (TenSV != "" && TenSV != null)
            {
                query = from c in db.HocPhan_SVs where c.SV.Name.Contains(TenSV.ToString()) select c;
            }
            if(TenHocPhan != null && TenHocPhan != "all")
            {
                query = from c in query where c.HocPhan.TenHocPhan == TenHocPhan select c;
            }
            return query.ToList();

        }
        public void del(string ID)
        {
            db.HocPhan_SVs.Remove(db.HocPhan_SVs.Find(Convert.ToInt32(ID)));
            db.SaveChanges();
        }
    }
}
