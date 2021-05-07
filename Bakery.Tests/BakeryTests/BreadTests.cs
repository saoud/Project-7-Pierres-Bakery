using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bread.Tests {
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadNumber_DoesBreadReturnNumber_BreadHasNumber()
        {
        Bread breadTest = new Bread(6);
        Assert.AreEqual(6, breadTest.AmountOfBread);
        }
        [TestMethod] 
        public void BreadPrice_WhatIsPriceOfBread_BreadHasPrice()
        {
        Bread breadTest = new Bread(6);
        Assert.AreEqual(20, breadTest.Price());
        }
    }
}