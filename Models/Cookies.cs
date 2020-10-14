namespace VendingMachine.Models
{
  class Cookies : FoodItem
  {
    public bool HasChocolateChips { get; set; }

    public Cookies(string name, string description, double price, bool hasChocolateChips) : base(name, description, price)
    {
      HasChocolateChips = hasChocolateChips;
    }
  }
}