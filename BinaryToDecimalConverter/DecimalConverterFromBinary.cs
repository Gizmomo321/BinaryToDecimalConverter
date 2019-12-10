using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalConverter
{
    public class DecimalConverterFromBinary
    {
        public long ConvertToDecimal(string valueToConvert)
        {
            long result = 0;
            int j = valueToConvert.Length - 1; //need of the length for the calculation. the first element is the highest exponent
            for (int i = 0; i < valueToConvert.Length; i++)
            {
                if (valueToConvert[i] == '1') //we calculate the value only if the actual number is 1
                    result += (long)Math.Pow(2, j);
                j--;//decreasing our exponent for next number.
            }
            return result;
        }
    }
}
