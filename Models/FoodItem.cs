using System;
// using VendingMachine.Interfaces

namespace VendingMachine.Models
{
  abstract class FoodItem //: IBuyable
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsEdible { get; set; }
    public double Price { get; set; }
    public FoodItem(string name, string description, double price)
    {
      Name = name;
      IsEdible = true;
      Description = description;
      Price = price;
    }
  }
}
