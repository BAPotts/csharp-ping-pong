using System;
using System.Collections.Generic;
using Ping.Models;

namespace Ping
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string userInput = Console.ReadLine();
      int userNumber = int.Parse(userInput);

      List<string> pingPong = new List<string>();
      pingPong = PingPong.Play(userNumber);

      foreach(string number in pingPong)
      {
        Console.WriteLine(number);
      }
      
    }
  }
}