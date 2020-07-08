using System;
using System.Threading;

namespace upgradedlibrary.models
{
  public abstract class Write
  {

    public static void wl(string msg)
    {
      Console.WriteLine(msg);
    }
    public static void w(string msg)
    {
      Console.WriteLine(msg);
    }
    public static void clr()
    {
      Console.Clear();
    }
    public static void err()
    {
      Console.Beep(1000, 100);
      Thread.Sleep(50);
      Console.Beep(1100, 100);
      Console.Clear();
      var cc = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Invalid input try again..");
      Console.ForegroundColor = cc;
    }
    public static void err(string Message)
    {
      Console.Beep(1000, 100);
      Thread.Sleep(50);
      Console.Beep(890, 100);
      Console.Clear();
      var cc = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(Message);
      Console.ForegroundColor = cc;
    }
  }
}