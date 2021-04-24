using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bread.Tests {
    [TestClass]
    public class BreadTests
    {
        [TestMethod] // What is bread amount
        public void BreadNumber_DoesBreadReturnNumber_BreadHasNumber()
        {
        Bread breadTest = new Bread(5);
        Assert.AreEqual(5, breadTest.AmountOfBread);
        }
    }
}