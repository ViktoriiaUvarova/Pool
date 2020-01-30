using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class Pool
    {
        public string ID;
        public string Name;
        public int years_open;
        public int metraz;
        public string location;

        public override string ToString()
        {
            return "Pool: " + Name + " " + years_open + " " + "Metraz:" + metraz
                + " " + "Location" + location;
        }
    }
}
