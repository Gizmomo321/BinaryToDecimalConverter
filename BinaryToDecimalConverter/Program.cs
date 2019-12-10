using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace BinaryToDecimalConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNmberToConvert;
            
            //binary pattern... to be sure that we have a binary number entered by the user
            Regex numbersAllowed = new Regex("^[0-1]+$"); 
            
            Console.WriteLine("Please  type the decimal number to convert or [q] to exit");
            while (true)
            {
                binaryNmberToConvert = Console.ReadLine().ToLower();
                
                //if we want to quit, just quit
                if (binaryNmberToConvert == "q")
                    return;

                //if that not match with the good patttern, try again or quit
                if (!numbersAllowed.IsMatch(binaryNmberToConvert))
                    Console.WriteLine("invalid number... please  type the decimal number to convert or [q] to exit");
                else
                {
                    //Else, let's convert
                    DecimalConverterFromBinary converter = new DecimalConverterFromBinary();
                    Console.WriteLine(converter.ConvertToDecimal(binaryNmberToConvert));
                }                
            }
        }
    }
}
