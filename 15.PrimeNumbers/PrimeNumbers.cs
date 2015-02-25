using System;
using System.Collections.Generic;
using System.Linq;
// Problem 15. Prime numbers
// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the Sieve of Eratosthenes algorithm.

class PrimeNumbers
{
    static void Main()
    {
        bool[] Arr = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(Arr.Length); i++)
        {
            if (Arr[i] == false)
            {
                for (int j = i * i; j < Arr.Length; j = j + i)
                {
                    Arr[j] = true;
                }
            }
        }
        for (int i = 2; i < Arr.Length; i++)
        {
            if (Arr[i] == false)
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}

