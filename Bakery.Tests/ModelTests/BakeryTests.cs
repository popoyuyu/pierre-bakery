using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void OneBread_ReturnsBreadPrice_5()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.BreadPrice(1));
    }
    [TestMethod]
    public void ThreeBread_ReturnsBreadPrice_10()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.BreadPrice(3));
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstancesOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void OnePastry_ReturnsPastryPrice_2()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.PastryPrice(1));
    }
    [TestMethod]
    public void ThreePastry_ReturnsDiscountPastryPrice_5()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(5, newPastry.PastryPrice(3));
    }
    [TestMethod]
    public void FourPastry_ReturnsDiscountPastryPrice_7()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(7, newPastry.PastryPrice(4));
    }
  }
}