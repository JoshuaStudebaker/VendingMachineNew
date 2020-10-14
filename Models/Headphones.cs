using System.Collections.Generic;

namespace VendingMachine.Models

{
  class Headphones : ElectronicItem
  {
    public bool Wireless { get; set; }
    public bool Buds { get; set; }
    public Headphones(string name, string company, string description, double price, bool wireless, bool buds) : base(name, company, description, price)
    {
      Wireless = wireless;
      Buds = buds;
    }


  }
}