namespace Pool.Models
{
    public class Sportsman
    {
        public string ID_Sportsmen;
        public string name { get; set; }
        public int years { get; set; }
        public string phone { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{name}, {years}, {phone}, {category}";
        }
    }
}
