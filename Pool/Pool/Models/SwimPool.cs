using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class SwimPool:Entity
    {
        public string NamePool { get; set; }
        public DateTime YearsOpen { get; set; }
        public int Length { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{NamePool}, {YearsOpen}, {Length}, {Location}";
        }

    }
}
