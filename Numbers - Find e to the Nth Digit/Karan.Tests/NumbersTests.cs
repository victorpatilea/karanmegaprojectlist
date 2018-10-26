using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karan.FindEToTheNthDigit;

namespace Karan.Tests
{
    [TestClass]
    public class NumbersTests
    {
        [TestMethod]
        public void EToTheNthDigit()
        {
            Assert.IsTrue(Utilities.GetEToTheNthDigit(10) == "2.7182818284");
        }
    }
}
