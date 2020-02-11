using System;

namespace Pool.Models
{
    public class Sportsman:Entity
    {
        public string Name { get; set; }
        public DateTime YearsOld { get; set; }
        public string PhoneNumber { get; set; }
        public string Rank { get; set; }

        public override string ToString()
        {
            return $"{Name}, {YearsOld}, {PhoneNumber}, {Rank}";
        }
    }
}
