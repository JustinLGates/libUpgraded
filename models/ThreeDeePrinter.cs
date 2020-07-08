using System;
namespace upgradedlibrary.models
{
  public class ThreeDeePrinter : Item
  {
    public string Model { get; set; }
    public ThreeDeePrinter(int id, string model) : base(id, "printer (3d)")
    {
      Model = model;
    }
    public void Print()
    {
      if (Model == "fireball6000")
      {
        Console.WriteLine("you burned the place to the ground and died... so sad");
      }
      else
      {
        Console.WriteLine("you printed a small peice of plastic ");
      }
    }
    public override void Action()
    {
      Print();
    }
  }
}