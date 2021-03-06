using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; set; }
    public int PastryTotal(int cost)
    {
      PastryCost = cost;
      return cost;
    }
    public int PastryPrice(int pastryAmount)
    {
      int singlePastry = pastryAmount * 2;
      for (int i = 1; i <= pastryAmount; i++)
      {
        if (i % 3 == 0)
        {
          singlePastry -= 1;
        }
      }
      return singlePastry;
    }
  }
}