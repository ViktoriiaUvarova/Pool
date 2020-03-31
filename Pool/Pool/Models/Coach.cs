using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class Coach:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Rank { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
        
        public long SwimPoolId { get; set; }
        public virtual SwimPool SwimPool { get; set; }

        public override string ToString()
        {
            return $"Coach {base.ToString()}";
        }
    }
}
