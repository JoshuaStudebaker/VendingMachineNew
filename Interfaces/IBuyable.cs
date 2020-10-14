namespace VendingMachine.Interfaces
{
  interface IBuyable
  {
    bool IsAvailable { get; set; }
    double Price { get; set; }
  }
}