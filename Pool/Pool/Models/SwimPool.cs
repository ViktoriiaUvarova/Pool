using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Models
{
    public class SwimPool:Entity
    {
        public string Title { get; set; }
        public DateTime YearsOpen { get; set; }
        public int Length { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Coach> Coaches { get; set; }
        
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public override string ToString()
        {
            return $"{Title}, {YearsOpen}, {Length}, {Location}";
        }

    }
}
