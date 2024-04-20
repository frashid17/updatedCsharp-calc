using System;
using System.Globalization;
using System.Net.Security;
using System.Numerics;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("WELCOME TO THE CALCULATOR!");

        while (true)
        {
            Console.WriteLine("ENTER OPERATION,FLOAT,FLOAT OR E TO EXIT");

            Char op = Console.ReadLine()[0];
            if (op == 'e')
            {
                Console.WriteLine("EXITING THE CALCULATOR, GOODBYE!");
                break;
            }

            Console.WriteLine("ENTER NUM1: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("ENTER NUM2: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            float result = 0;

            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
                result = num1 * num2;
            }
            else if (op == '/')
            {
                if (num1 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("ERROR: DIVISION BY ZERO!");
                    continue;
                }
     
            }
            else
            {
                Console.WriteLine("ERROR: INVALID OPERATION!");
                continue;
            }
            Console.WriteLine("RESULTS IS : " + result);

        }

    }
}


