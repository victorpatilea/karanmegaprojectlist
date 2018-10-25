using Karan.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Karan.Tests
{
    [TestClass]
    public class NumbersTests
    {
        [TestMethod]
        public void PiToTheNthDigit()
        {
            Assert.IsTrue(Utilities.GetPiToTheNthDigit(10) == "3.1415926535");
        }
    }
}
