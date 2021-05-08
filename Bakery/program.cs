using Bakery.Models;
using System;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("Bread: $5 per loaf. Buy 2, Get 1 free!");
      Console.WriteLine("Pastry: $2 each. Get 3 for $5!");
      Console.WriteLine("How many bread loaves would you like to order?");
      bool breadOrderSuccess = int.TryParse(Console.ReadLine(), out int breadOrder);
      while((breadOrderSuccess == false) || (breadOrder < 0))
      {
        Console.WriteLine("That is not a valid input. Please enter the number of bread loaves you would like. Enter 0 if you do not want any bread loaves.");
        breadOrderSuccess = int.TryParse(Console.ReadLine(), out breadOrder);
      }
    }
  }
}