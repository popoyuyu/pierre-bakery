using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; }
    public int BreadAmount { get; set; }
    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
      BreadCost = 0;
    }

    public int BreadPrice()
    {
      for (int i = 1; i <= BreadAmount; i++)
      {
        if (i % 3 == 0)
        {
          BreadCost += 0;
        }
        else
        {
          BreadCost += 5;
        }
      }
      return BreadCost;
    }
  }
}