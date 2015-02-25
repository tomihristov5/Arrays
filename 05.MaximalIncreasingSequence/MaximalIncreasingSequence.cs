// Problem 5. Maximal increasing sequence
// Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array,  (elements separeted by ',') --> ");
        int[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        int start = 0;
        int point = 1;
        int max = 1;
        string[] increment = new string[input.Length];
        string[] maxIncrement = new string[input.Length];
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] < input[i + 1])
            {
                point++;
            }
            else
            {
                point = 1;
                start = 0;
                increment = new string[input.Length];
            }

            if (point > max)
            {
                max = point;
                increment[start] += input[i] + ", ";
                maxIncrement[start] = increment[start];
                start++;
                maxIncrement[start] += input[i + 1];
            }
        }
        Console.WriteLine("The maximal increasing sequence is: ");
        for (int i = 0; i < max; i++)
        {
            Console.Write(maxIncrement[i]);
        }
        Console.ReadLine();
    }
}

