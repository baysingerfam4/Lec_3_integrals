using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System;

namespace Lec_3_integrals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1(); // Method Call
            Part2(); // Method Call

        }

        public static void Part1()
        {
            // Ask the user for 3 numbers
            // Create a variable called q1
            // Add user number1 and user number2 together, and save them to q1
            // Create a new variable called q2.
            // Multiple q1 by 3, and save the result to q2.
            // Display q2


            Console.Write("Enter a number 1: ");

            // Ask user for a number, save as a string
            string userInput = Console.ReadLine();
            // Try <-- to convert string to an int
            int num1 = int.Parse(userInput);
            Console.Write("Enter a number 2: ");
            userInput = Console.ReadLine();
            int num2 = int.Parse(userInput);
            Console.Write("Enter a number 3: ");
            userInput = Console.ReadLine();
            int num3 = int.Parse(userInput);
            int num5 = 3;
            int q1 = num1 + num2;
            int q2 = num3 - num1 + num2;
            int q3 = num3 * num2 - num3;
            int q4 = num1 / num3 - num1;
            int q5 = num3 + num3 - num2 * num5;
            int q6 = q1 * q3;
            int q7 = q2 / q4;
            int q8 = q5 + q1 + num2;
            int q9 = q3 - q6 + num1 * q4;
            int q10 = q3 * q2 + q4 + num2 - q6 / q8;


            Console.WriteLine(q2);
            Console.WriteLine(q1);
            Console.WriteLine(q3);
            Console.WriteLine(q4);
            Console.WriteLine(q5);
            Console.WriteLine(q6);
            Console.WriteLine(q7);
            Console.WriteLine(q8);
            Console.WriteLine(q9);
            Console.WriteLine(q10);
            // "Your number is " + num1

            Console.WriteLine($"Your number is {num1}");
        }
        
        public static void Part2()
        {
            //Samantha runs a small bakery.In one day, she bakes 5 batches of cookies, with each batch containing 24 cookies.She sells each cookie for $2.At the end of the day, she gives away 10 cookies to her neighbors and had to throw away 8 cookies that were accidentally burnt.How much money did Samantha make from selling the cookies after giving away and throwing away some of them ?
            //Cost of a single cookie: $2
            //Number of cookies in a batch: 24
            //Cost for a batch of cookies: $48
            //Total cookies in 5 batches: 120
            //Total cost for 5 batches of cookies: $240
            //Number of cookies given away: 10
            //Cost of cookies given away: $20
            //Number of cookies thrown away: 8
            //Cost of cookies thrown away: $16
            //Total earnings after giving away and throwing away some cookies: $204
            int cookies = 2;
            int bat = 24;
            int batcost = 48;
            int q5 = bat * 5;
            int q6 = 5 * batcost;
            int cga = 10;
            int cgacost = 20;
            int cookiesthrown = 8;
            int coothrocost = 16;
            Console.WriteLine($"bat * 5 - cga - cookiesthrown * cookies");

        }

    }
}
