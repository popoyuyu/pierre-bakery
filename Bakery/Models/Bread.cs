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
  }
}
