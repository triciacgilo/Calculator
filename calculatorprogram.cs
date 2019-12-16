using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                   
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
               
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
               
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

               
                Console.Write("Enter a number: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                    numInput1 = Console.ReadLine();
                }

                
                Console.Write("Enter another number: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Invalid. Please enter an integer: ");
                    numInput2 = Console.ReadLine();
                }

                
                Console.WriteLine("Enter an operation:");
                Console.WriteLine("\ta - Addition");
                Console.WriteLine("\ts - Subtraction");
                Console.WriteLine("\tm - Multiplication");
                Console.WriteLine("\td - Division");
                Console.Write("Which of the following operations will you choose? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Answer: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("To exit the calculator console app, press 'x' and Enter. To continue, press any other key and Enter: ");
                if (Console.ReadLine() == "x") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}

