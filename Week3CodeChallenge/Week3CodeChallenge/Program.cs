using System;
using System.Collections.Generic;
using System.Linq;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// A function that calculates the starting value of the longest Collatz sequence.
        /// This function will start at 1 million and look at which value generates the
        /// longest sequence.
        /// </summary>
        /// <returns>Starting value of the longest sequence</returns>
        public static long LongestCollatzSequence()
        {
            //keep track of number with longest chain during all tests
            long longestCollatzNumber = 0;
            //count length of chain for each number
            long count = 0;
            //keep track of longest chain to determine number with longest Collatz Sequence
            long longestCount = 0;
            //check all numbers up to 1,000,000
            for (int i = 1; i <= 1000000; i++)
            {
                long n = i;
                count = 0;
                while (n >= 1)
                {
                    if (n == 1)
                    {
                        count++;
                        break;
                    }
                    //if number is even...
                    else if (n % 2 == 0)
                    {
                        n = n / 2;
                        count++;
                    }
                    //else if number is odd...
                    else
                    {
                        n = 3 * n + 1;
                        count++;
                    }
                }
                //if chain length of current number is longer than previous numbers then label it as the longest so far and keep trac of its length for comparing to future numbers
                if (count > longestCount)
                {
                    longestCollatzNumber = (long)i;
                    longestCount = count;
                }              
            }
            return longestCollatzNumber; // Default return value, replace this
        }

        /// <summary>
        /// A Function that adds up each even number in a Fibonacci Sequence until the maxValue
        /// then prints the sum of those numbers to the console
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns>The sum of every even number for the given number of Fibonacci digits</returns>
        public static long EvenFibonacciSequencer(long maxValue)
        {
            //all sequences start with 1 and 2
            long previousFib = 1;
            long nextFib = 2;
            //add together only the even Fib numbers, beginning with 2
            long evenFibs = 2;
            //keeps track of current Fib number to check against the maxValue
            long fibToCheck = 0;

            while (fibToCheck < maxValue)
            {
                //add together previous two Fib numbers to get next one
                fibToCheck = previousFib + nextFib;
                //if it's even then add it to sum of previous even Fib's
                if (fibToCheck % 2 == 0)
                {
                    evenFibs += fibToCheck;
                    previousFib = nextFib;
                    nextFib = fibToCheck;
                }else
                {
                    previousFib = nextFib;
                    nextFib = fibToCheck;
                }
            }
            //return sum of all even Fibs prior to reaching maxValue
            return evenFibs; // Default return value, replace this
        }

        /// <summary>
        /// Function that finds the n'th prime indicated by the parameter
        /// </summary>
        /// <param name="maxPrime"></param>
        /// <returns>The prime number which is the n'th found</returns>
        public static int FindNPrimes(int maxPrime)
        {
            //in order to run efficient function must start at Prime number of 7
            int lastPrimeNumber = 7;
            //keeps track of prime numbers counted
            int primeCounter = 4;
            //next number to check
            int numberToCheck = 8;
            bool isPrime = true;

            while (primeCounter < maxPrime)
            {
                //if number is even it's not prime and don't need to check further
                if (numberToCheck % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    //only need to check up to the squareroot of the current number, and only need to check every other number in sequence since even numbers have all been ruled out
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
                    //keep track of latest prime number
                    lastPrimeNumber = numberToCheck;
                    numberToCheck++;
                    //keep track of prime numbers counted to stop the loop when maxPrime is reached
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
