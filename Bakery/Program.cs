using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();

      Console.WriteLine("Hello, Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread: $5 per loaf, buy two loaves get one free!!!");
      Console.WriteLine("Pastry: $2 per pastry, buy two pastries get one half off!!!");
      Console.WriteLine("How many loaves of bread do you want?");
      string breadInput = Console.ReadLine();
      int breadCost = int.Parse(breadInput);
      Console.WriteLine("How many pastries do you want?");
      string pastryInput = Console.ReadLine();
      int pastryCost = int.Parse(pastryInput);
      int finalBreadCost = newBread.BreadTotal(newBread.BreadPrice(breadCost));
      int finalPastryCost = newPastry.PastryTotal(newPastry.PastryTotal(pastryCost));
      int finalCost = finalBreadCost + finalPastryCost;
      Console.WriteLine("Your Bread cost comes out to $" + finalBreadCost + " and your Pastry cost comes out to $" + finalPastryCost);
      Console.WriteLine("Your total today is $" + finalCost);

    }
  }
}