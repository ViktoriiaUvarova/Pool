using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class Subscription:Entity
    {
        public string PoolID;
        public string SportsmanID;
        public string CoachID;
        public DateTime ClearanceDate;
        public DateTime Term;

        public override string ToString()
        {
            return $"{PoolID}, {SportsmanID}, {CoachID}, {ClearanceDate}, {Term}";
        }
    }
}
