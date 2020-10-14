using System.Collections.Generic;
using VendingMachine.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Services
{
  class VendingMachineService
  {

    public List<IBuyable> Buyables { get; set; }
    public List<FoodItem> FoodItems { get; set; }
    public List<ElectronicItem> ElectronicItems { get; set; }

    // internal string GetBuyables(bool buyable)
    // {
    //   var buyables = Buyables.FindAll(b => b.IsBuyable == buyable);
    // }

    // internal string GetFoodItems()
    // {
    //   var foods = FoodItems
    // }
    public VendingMachineService()
    {
      FoodItems = new List<FoodItem>()
      {
new Chips("Chips off the Old Block", "Not too salty", 2.00, true),
new Cookies("Shocking Schokolade", "ie too much chocolate", 1.50, true)
      };
      ElectronicItems = new List<ElectronicItem>(){
        new Charger("iPhone Charger", "Apple", "Plugs in", 55.00, true, "USA"),
        new Headphones("Silencer","ZhouerStream Electronics", "Stays on, blocks out", 24.00, true, false)
      };

    }
  }
}