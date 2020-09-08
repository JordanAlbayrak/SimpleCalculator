using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        // public double ConvertInputToNumeric(string argTextInput)
        //{
        //old version of C# way

        //double convertedNumber;

        //if (!double.TryParse(argTextInput, out double convertedNumber))
        // throw new ArgumentException("Expected a numberic value.");
        //return convertedNumber;


        //ternary operator
        //var a = 10;
        //var b = a > 11 ? 9 : 8;

        //  return double.TryParse(argTextInput, out double convertedNumber) ? 
        //   convertedNumber : throw new ArgumentException("Numeric value expected.");


        public double ConvertedInputToNumeric(string argTextInput) =>
          double.TryParse(argTextInput, out double convertedNumber) ?
          convertedNumber : throw new ArgumentException("Numeric value expected, please try again.");

    }
}

