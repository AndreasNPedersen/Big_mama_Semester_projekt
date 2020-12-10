namespace MadOrderingssystem.Models
{
    public class Toppings : Product
    {

        public Toppings() { }
       public Toppings(Size size, string newId, double pris, string productName) : base(newId, pris, productName)
      {

      }
    }
}