using System;
using System.Collections.Generic;
using System.Linq;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNPrimes(6));

            Console.ReadKey();
        }
        /// <summary>
        /// A function that calculates the starting value of the longest Collatz sequence.
        /// This function will start at 1 million and look at which value generates the
        /// longest sequence.
        /// </summary>
        /// <returns>Starting value of the longest sequence</returns>
        public static long LongestCollatzSequence()
        {
            return 0; // Default return value, replace this
        }

        /// <summary>
        /// A Function that adds up each even number in a Fibonacci Sequence until the maxValue
        /// then prints the sum of those numbers to the console
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns>The sum of every even number for the given number of Fibonacci digits</returns>
        public static long EvenFibonacciSequencer(long maxValue)
        {
            return 0; // Default return value, replace this
        }

        /// <summary>
        /// Function that finds the n'th prime indicated by the parameter
        /// </summary>
        /// <param name="maxPrime"></param>
        /// <returns>The prime number which is the n'th found</returns>
        public static int FindNPrimes(int maxPrime)
        {
            int lastPrimeNumber = 7;
            int primeCounter = 4;
            int numberToCheck = 8;
            bool isPrime = true;

            while (primeCounter < maxPrime)
            {
                if (numberToCheck % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 3; i <= (int)(Math.Sqrt(numberToCheck)); i += 2)
                    {
                        if (numberToCheck % i == 0)
                        {
                            isPrime = false;
                            break;
                        } isPrime = true;
                    }
                }
                if (isPrime)
                {
                    lastPrimeNumber = numberToCheck;
                    numberToCheck++;
                    primeCounter++;
                }
                else
                {
                    numberToCheck++;
                }
            }
            return lastPrimeNumber; // Default return value, replace this
        }
    }
}
