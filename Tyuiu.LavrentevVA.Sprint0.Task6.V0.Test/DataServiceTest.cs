using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LavrentevVA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.LavrentevVA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void TestSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void TestMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
