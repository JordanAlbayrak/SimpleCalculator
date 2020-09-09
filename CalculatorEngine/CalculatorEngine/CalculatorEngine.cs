using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
   public class CalculatorEngine
    {
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch (argOperation.ToLower())
            {
                case "+":
                    result = argFirstNumber + argSecondNumber;

                    break;

                case "-":
                    result = argFirstNumber - argSecondNumber;

                    break;

                case "*":
                    result = argFirstNumber * argSecondNumber;

                    break;

                case "/":
                    result = argFirstNumber / argSecondNumber;

                    break;
                case "^":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;

                default:
                    throw new InvalidOperationException("Specified operation is not recognized, please try again and choose from the list.");

            }


            return result;

        }



    }
}
