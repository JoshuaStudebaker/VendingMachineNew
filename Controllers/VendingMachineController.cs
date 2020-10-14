using System;
using VendingMachine.Services;

namespace VendingMachine.Controllers
{

  class VendingMachineController
  {
    public bool _Running { get; set; } = true;
    public void Run()
    {
      while (_Running)
      {

      }
    }

    private void GetUserInput()
    {
      Console.WriteLine("(H)ungry?, iPhone problems ie (E)lectronics?, just let me (b)rowse");
      string userInput = Console.ReadLine().ToLower();
      Console.Clear();
      switch (userInput)
      {
        case "hungry":
        case "h":
          GetFoodItems();
          break;
        case "e":
        case "electronics":
          GetElectronic();
          break;
        case "b":
        case "browse":
          GetBuyables();
          break;
        default:
          Console.WriteLine("Please try entering again");
          break;

      }

    }

    private void GetElectronic()
    {
      throw new NotImplementedException();
    }

    private void GetFoodItems()
    {
      throw new NotImplementedException();
    }

    private void GetBuyables()
    {
      Console.WriteLine(_Service.GetBuyables(true));
      Console.Write("Enter a number to buy from machine");
      string inputString = Console.ReadLine();
    }

  }
}