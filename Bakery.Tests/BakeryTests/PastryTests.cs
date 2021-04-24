using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
  public class PastriesTests
  {
  [TestMethod] // How many pastries?
    public void PastriesChecker_TestShouldTellNumberOfPastries_PastriesHasNumber()
    {
      Pastries pastriesTest = new Pastries(30);
      Assert.AreEqual(30, pastriesTest.AmountOfPastries);
    }
  }
}