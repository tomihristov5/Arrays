// Problem 8. Maximal sum
// Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter array,  (elements separeted by ',') --> ");
        int[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        int startIndex = 0;
        int currentSum = 0;
        int bestSum = int.MinValue;
        int bestStart = 0;
        int bestEnd = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }
            currentSum += input[i];
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }
        Console.Write("The sequence of maximal sum in the given array is: ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            if (i != bestEnd)
            {
                Console.Write("{0}, ", input[i]);
            }
            else
            {
                Console.WriteLine("{0}", input[i]);
            }
        }
    }
}

