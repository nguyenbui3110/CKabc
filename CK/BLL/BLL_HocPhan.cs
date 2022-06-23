using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.DTO;

namespace CK.BLL
{
    public class BLL_HocPhan:BLL
    {
        private static BLL_HocPhan _Instance;
        public static BLL_HocPhan Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_HocPhan();
                return _Instance;
            }

        }

        internal List<HocPhan> GetAll()
        {
            return db.HocPhans.ToList();
        }

        internal HocPhan FindWithName(string text)
        {
            var query = from c in db.HocPhans where c.TenHocPhan==text select c;
            return query.FirstOrDefault();
        }
    }

}
