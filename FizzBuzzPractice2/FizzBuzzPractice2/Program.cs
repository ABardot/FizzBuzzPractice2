using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 Fizz
            // 5 Buzz
            // 15 FizzBuzz

            //Print number from 1 to 100
            for (int i = 1; i < 100; i++)
            {
                string result = "";
                // Divisible by 3 print Fizz
                if (i % 3 == 0) result = "Fizz";

                // Divisible by 5 print Buzz
                if (i % 5 == 0) result = "Buzz";

                // Divisible by 3 and 5 print FizzBuzz
                if (i % 15 == 0) result = "FizzBuzz";

                // Print if not divisible by 3 or 5
                if (result.Length == 0) result = i.ToString();


                // Print Number 
                Console.WriteLine(result);

            }

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
