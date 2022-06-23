using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CK.Entity;

namespace CK.BLL
{
    public class BLL
    {
        protected static QLDiem db;
        protected BLL()
        {
            db = new QLDiem();
        }
    }
}
