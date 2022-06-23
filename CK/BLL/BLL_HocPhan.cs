using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.DTO;

namespace CK.BLL
{
    public class BLL_HocPhan
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
    }

}
