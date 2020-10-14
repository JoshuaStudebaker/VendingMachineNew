using System.Collections.Generic;

namespace VendingMachine.Models

{
  class Charger : ElectronicItem
  {
    public bool IPhoneFriendly { get; set; }
    public string Country { get; set; }
    public Charger(string name, string company, string description, double price, bool iPhoneFriendly, string country) : base(name, company, description, price)
    {
      IPhoneFriendly = iPhoneFriendly;
      Country = country;
    }
  }


}