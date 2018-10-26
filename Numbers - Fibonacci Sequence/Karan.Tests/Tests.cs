using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Karan.FibonacciSequence;

namespace Karan.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FibonacciSequence()
        {
            Assert.IsTrue(Utilities.GetFibonacciSequence(500) == "0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 ");
        }
    }
}
