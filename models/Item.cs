using System;


namespace upgradedlibrary.models
{

  public abstract class Item
  {
    public int Id { get; set; }
    public string Catagory { get; set; }
    public Item(int id, string catagory)
    {
      Id = id;
      Catagory = catagory;
    }
    public override string ToString()
    {
      return Catagory;
    }
    public virtual void Action()
    {
      Console.WriteLine("action");
    }


  }
}