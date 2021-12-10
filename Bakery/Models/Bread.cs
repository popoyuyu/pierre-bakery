using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; }
    public int BreadTotal(int cost)
    {
      BreadCost = cost;
      return cost;
    }

    public int BreadPrice(int breadAmount)
    {
      int loaf = 0;
      for (int i = 1; i <= breadAmount; i++)
      {
        if (i % 3 != 0)
        {
          loaf += 5;
        }
      }
      return loaf;
    }
  }
}