using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {


         
            bool continueCase = true;
            Console.WriteLine("Choose option:");
 
            while (continueCase)
            {
                Console.WriteLine("Making Calculator for the first time in C#");
                Console.WriteLine("Choose what you want to do");
                Console.WriteLine("1 : Add");
                Console.WriteLine("2  : Subtract");
                Console.WriteLine("3: Divide");
                Console.WriteLine("4: Multiplication");
                Console.WriteLine("5: Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Divide();
                        break;
                    case 4:
                        Multiplication();
                        break;
                    case 5:
                        continueCase = false;
                        break;
                    default:
                        Console.WriteLine("Wrong option given");
                        break;

                }
            }



            static void Add()
            {
                Console.WriteLine("Enter the numbers:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double value = a + b;
                Console.WriteLine($"Result of {a} + {b} => {value}");
            }

            static void Subtract()
            {
                Console.WriteLine("Enter the numbers:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double value = a - b;
                Console.WriteLine($"Result of {a} - {b} => {value}");
            }

            static void Multiplication()
            {
                Console.WriteLine("Enter the numbers:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double value = a * b;
                Console.WriteLine($"Result of {a} * {b} => {value}");
            }

            static void Divide()
            {
                Console.WriteLine("Enter the numbers:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                if (b != 0)
                {
                    double value = a / b;
                    Console.WriteLine($"Result of {a} / {b} => {value}");
                }
                else
                {
                    Console.WriteLine("Dont make divisor 0 , it is undefined");
                }

            }

        }
    }
}