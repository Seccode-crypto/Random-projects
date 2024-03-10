using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;


            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("Enter the First Number: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of Operation would you like to use?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or d for division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry but that is not a valid operator ");
                return;
            }

            Console.WriteLine("The result is " + result);

            Console.ReadKey();
        }
    }
}
