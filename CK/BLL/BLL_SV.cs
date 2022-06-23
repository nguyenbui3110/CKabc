using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.DTO;
namespace CK.BLL
{
    public class BLL_SV
    {
        private static BLL_SV _Instance;
        public static BLL_SV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_SV();
                return _Instance;
            }

        }

    }
}
