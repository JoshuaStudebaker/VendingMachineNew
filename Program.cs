using System;
using VendingMachine.Controllers;

namespace VendingMachine
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      new VendingMachineController().Run();
    }
  }
}
