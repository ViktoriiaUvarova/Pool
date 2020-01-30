namespace Pool.Models
{
    public class Coach : Sportsman
    {
        public string ID_Treiner;

        public override string ToString()
        {
            return $"Coach {base.ToString()}";
        }
    }
}
