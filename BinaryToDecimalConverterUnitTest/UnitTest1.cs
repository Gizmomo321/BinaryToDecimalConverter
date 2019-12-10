using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryToDecimalConverterUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1(int valueToTest)
        {
            int answer = 8;
            Assert.Equals(answer, valueToTest);
        }
    }
}
