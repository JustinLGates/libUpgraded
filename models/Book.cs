using upgradedlibrary.Interfaces;
using System;
namespace upgradedlibrary.models
{
  public class Book : Item, ICheckOut
  {
    public string Name { get; set; }
    public Book(int id, string name) : base(id, "book")
    {
      Name = name;
      CheckedOut = false;

    }
    public bool CheckedOut { get; set; }
    public override string ToString()
    {
      return "book";
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