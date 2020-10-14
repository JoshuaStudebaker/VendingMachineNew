using System.Collections.Generic;
using VendingMachine.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Services
{
  class VendingMachineService
  {

    public List<IBuyable> Buyables { get; set; }

    internal string GetBuyables(bool buyable)
    {
      var buyables = Buyables.FindAll(b => b.IsBuyable == buyable);
    }
    public VendingMachineService()
    {

    }
  }
}