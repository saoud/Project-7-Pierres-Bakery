using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetCost_ReturnsCost_int()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(0, newPastry.Cost);
    }
    [TestMethod]
    public void GetOrderAmount_ReturnsOrderAmount_int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.OrderAmount);
    }
  }
}