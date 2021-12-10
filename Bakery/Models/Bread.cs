using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; }
    public static int BreadTotal(int cost)
    {
      Bread breadPrice = new Bread();
      breadPrice.BreadCost = 5;
    }
  }
}