using Bread;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bread.Tests {
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
    public void BreadPrice_GetPriceOfBread_Int()
    {
      int breadOrder = 1;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadPrice();
      Assert.AreEqual(5, result);
    }
    }
}