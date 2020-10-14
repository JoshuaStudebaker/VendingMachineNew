using System;
using VendingMachine.Interfaces;

namespace VendingMachine.Models
{
  abstract class ElectronicItem : IBuyable
  {
    public string Name { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }
    public ElectronicItem(string name, string company, string description, double price)
    {
      Name = name;
      Company = company;
      Description = description;
      Price = price;
      IsAvailable = true;
    }
  }
}
