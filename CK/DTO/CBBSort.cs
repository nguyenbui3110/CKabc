using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.DTO
{
    public class CBBSort
    {
        public int value { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
