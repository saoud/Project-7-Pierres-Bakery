using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
      [TestMethod]
    public void GetCost_ReturnsCost_int()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(0, newBread.Cost);
    }

  }
}