using System;
using System.Collections;
using System.Linq;

namespace MethodsExamples
{


    class Program
    {    
        public static void Main(string[] args)
        {
            int topNumber = 10;
            var numbers = new BitArray(topNumber, true);

            for (int i = 2; i < topNumber; i++)
                if (numbers[i])
                {
                    for (int j = i * 2; j < topNumber; j += i)
                        numbers[j] = false;
                }

            int primes = 0;

            for (int i = 1; i < topNumber; i++)
                if (numbers[i])
                {
                    primes++;
                    Console.Out.WriteLine(i);
                }

            Console.WriteLine();
            Console.Out.WriteLine(primes + " out of " + topNumber + " prime numbers found.");
            Console.ReadLine();
        }
    }
}
