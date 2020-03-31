using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class Sportsman : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Rank { get; set; }

        public long SubscriotionId { get; set; }
        public virtual Subscription Subscription { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Birthday?.ToShortTimeString()}, {Phone}, {Rank}";
        }
    }
}
