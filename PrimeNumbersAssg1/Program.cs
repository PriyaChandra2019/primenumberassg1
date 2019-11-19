using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersAssg1
{
    class Program
    {
        //C# Program to Print  All the Prime Numbers Between 1- 100 and Multiples of three Print "Fizz" , Multiples of five Print "Buzz".
        public static void Main()
        {
            int n = 100;

            // to loop for 100 times
            for (int i = 1; i <= n; i++)
            {
                // number divisible by 3, print "Fizz"
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz" + " ");
                }

                // number divisible by 5 print "Buzz"
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz" + " ");
                }
                else
                    Console.WriteLine(i + " ");
                                            
                
                // print the numbers

            
            }
            
            Console.ReadKey();
        }
    }
}
