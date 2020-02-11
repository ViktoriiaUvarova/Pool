namespace Pool.Models
{
    public class Coach : Sportsman
    {
        public override string ToString()
        {
            return $"Coach {base.ToString()}";
        }
    }
}
