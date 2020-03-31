using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class Subscription:Entity
    {
        public DateTime ClearanceDate;
        public DateTime ExpirationDate;

        public long  SportsmanId { get; set; }
        public virtual Sportsman Sportsman { get; set; }

        public long? CoachId { get; set; }
        public virtual Coach Coach { get; set; } 

        public long SwimPoolId { get; set; }
        public virtual SwimPool SwimPool { get; set; }

        public override string ToString()
        {
            return $"{ClearanceDate}, {ExpirationDate}";
        }
    }
}
