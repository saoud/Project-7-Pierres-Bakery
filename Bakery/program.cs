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
      Console.WriteLine("How many pastries would you like to order?");
      bool pastryOrderSuccess = int.TryParse(Console.ReadLine(), out int pastryOrder);
      while(!pastryOrderSuccess || (pastryOrder < 0))
      {
        Console.WriteLine("That is not a valid input. Please enter the number of pastries you would like. Enter 0 if you do not want any pastries.");
        pastryOrderSuccess = int.TryParse(Console.ReadLine(), out pastryOrder);
      }
      Bread newBread = new Bread(breadOrder);
      Pastry newPastry = new Pastry(pastryOrder);
      newBread.CalculateBreadCost();
      int breadCost = newBread.Cost;
      newPastry.CalculatePastryCost();
      int pastryCost = newPastry.Cost;
      Console.WriteLine("Thank you for your order! Your total is: $" + (breadCost + pastryCost));
    }
  }
}