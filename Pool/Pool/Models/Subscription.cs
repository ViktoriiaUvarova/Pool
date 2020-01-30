using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class Subscription
    {
        public string ID_sportsmen;
        public string ID_treiner;
        public string data_oform;
        public string srok;

        public override string ToString()
        {
            return "ID Sportsmen:" + ID_sportsmen + " " + "ID Treiner: " + ID_treiner + " "
                + "Oformlenie: " + data_oform + " " + "Srok: " + srok;
        }
    }
}
