using System;
using upgradedlibrary.models;
using System.Collections.Generic;

namespace upgradedlibrary.controller
{
  public class Library
  {
    List<Item> items = new List<Item>();
    List<string> diffItems = new List<string>();
    private bool IsRunning { get; set; } = true;
    public Library()
    {
      items.Add(new Book(1, "in the woods"));
      items.Add(new Book(2, "everything"));
      items.Add(new Book(3, "monty python "));
      items.Add(new Book(4, "passion of the guy who did some stuff"));
      items.Add(new Book(5, "not in the woods"));
      items.Add(new Bike(6, "shwinn"));
      items.Add(new Bike(7, "superbike"));
      items.Add(new Bike(8, "shlowmo"));
      items.Add(new ThreeDeePrinter(9, "fireball6000"));
      items.Add(new ThreeDeePrinter(10, "niceAndEasy"));
      Write.clr();
      Write.wl("Welcome to the library");
      Write.wl("What would you like to do?");
      while (IsRunning)
      {
        Console.WriteLine("look around {l} return a book{r} or quit {q}");
        string input = Console.ReadLine();
        switch (input)
        {
          case "q":
          case "quit":
            IsRunning = false;
            break;
          case "l":
          case "look":
          case "look around":
            LookAround();
            break;
          case "r":
          case "return":
            break;
          default:
            Console.Clear();
            Write.err($"{input} is not a valid option");
            break;
        }
      }
    }
    void LookAround()
    {
      Write.wl("what catagory would you like?");
      items.ForEach(i =>
      {
        if (!diffItems.Contains(i.Catagory))
        { diffItems.Add(i.Catagory); }
      });
      diffItems.ForEach(i => Console.WriteLine(i));
      string input = Console.ReadLine();
      LookAt(input);
    }
    void LookAt(string catagory)
    {
      Console.Clear();
      int index = 1;
      items.ForEach((item) =>
       {
         if (item.Catagory == catagory)
         {
           var thing1 = item as Book;
           if (thing1 != null)
           {
             Console.WriteLine($"{index}. {thing1.Name}");
           }
           var thing2 = item as Bike;
           if (thing2 != null)
           {
             Console.WriteLine($"{index}. {thing2.Model}");
           }
           var thing3 = item as ThreeDeePrinter;
           if (thing3 != null)
           {
             Console.WriteLine($"{index}. {thing3.Model}");
           }
           index++;
         }
       });
      string choice = Console.ReadLine();
      int selectedIndex;
      Int32.TryParse(choice, out selectedIndex);
      Item item = items.Find((i) => i.Id == (selectedIndex--));
      item.Action();
      Console.ReadLine();
    }

  }


}
