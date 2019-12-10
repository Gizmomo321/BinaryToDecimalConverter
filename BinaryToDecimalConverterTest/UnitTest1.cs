using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryToDecimalConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertMyBinaryNumber()
        {
            //list of valueas to convert
            string[] values = new string[] { "1100", "101100", "100010001000", "11110100001001000000", "1001001010", "1010111000110000011100111011110000000000111011010101001110000" };
            //list of correct result for each values
            long[] result = new long[] { 12, 44, 2184, 1000000, 586, 1568957426598521456 };
            
            BinaryToDecimalConverter.DecimalConverterFromBinary converter = new BinaryToDecimalConverter.DecimalConverterFromBinary();
            string valToConvert;
            for(int i = 0; i< values.Length; i++)
            {
                valToConvert = values[i]; //value to convert
                Console.WriteLine($"Converting {valToConvert}");
                Assert.AreEqual(result[i], result[i]); //comparaison between converter result and waited result
            }
        }
    }
}
