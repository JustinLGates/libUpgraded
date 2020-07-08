using upgradedlibrary.Interfaces;
using System;
namespace upgradedlibrary.models
{
  public class Bike : Item, ICheckOut
  {
    public bool CheckedOut { get; set; }
    public string Model { get; set; }
    public Bike(int id, string model) : base(id, "bike")
    {
      Model = model;
      CheckedOut = false;
    }
    public void CheckOut()
    {
      Console.WriteLine("you cheked out a book");
      CheckedOut = true;
    }
    public void Return()
    {
      CheckedOut = false;
    }
    public override void Action()
    {
      CheckOut();
    }
  }
}