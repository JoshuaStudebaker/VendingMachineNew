namespace VendingMachine.Models
{
  class Chips : FoodItem
  {
    public bool FromPotatoes { get; set; }

    public Chips(string name, string description, double price, bool fromPotatoes) : base(name, description, price)
    {
      FromPotatoes = fromPotatoes;
    }
  }
}