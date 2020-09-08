using System;
using System.Text;



namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool status = false;
            while (status == false)
            {


                try
                {

                    InputConverter inputConverter = new InputConverter();

                    Console.WriteLine("Enter a number");
                    double firstNumber = inputConverter.ConvertedInputToNumeric(Console.ReadLine());


                    Console.WriteLine("Enter a second number");
                    double secondNumber = inputConverter.ConvertedInputToNumeric(Console.ReadLine());


                    Console.WriteLine("Enter one of the following operators : + - * / ^");
                    string operation = Console.ReadLine();

                    string wordOperation = "null";

                    double result = CalculatorEngine.CalculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    /**     if (operation.Equals("+"))
                             wordOperation = "added";
                         else if (operation.Equals("-"))
                             wordOperation = "subtracted";
                         else if (operation.Equals("*"))
                             wordOperation = "multiplied";
                         else if (operation.Equals("/"))
                             wordOperation = "divided";
                         else if (operation.Equals("^"))
                            wordOperation = "raised";
                     **/
                    switch (operation)
                    {
                        case "+":
                            wordOperation = "added";
                            break;
                        case "-":
                            wordOperation = "subtracted";
                            break;
                        case "*":
                            wordOperation = "multiplied";
                            break;
                        case "/":
                            wordOperation = "devided";
                            break;
                        case "^":
                            wordOperation = "raised";
                            break;
                        default:
                            throw new InvalidOperationException("Specified operation is not recognized, please try again and choose from the list.");
                    }


                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("The value {0:N} {1} by the value {2:N} results in {3:N} ", firstNumber, wordOperation, secondNumber, result);


                    Console.WriteLine("------------Numeric Format------------");
                    Console.WriteLine("{0:N} {1} {2:N} = {3:N} ", firstNumber, operation, secondNumber, result);
                    Console.WriteLine("-------------Typed Format-------------");
                    Console.WriteLine(sb);
                    Console.ReadLine();

                    status = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    status = false;
                    // real life - log this error
                }
            }
        }


        //double firstNumber = inputConverter.ConvertInputToNumeric("1");


    }
}

