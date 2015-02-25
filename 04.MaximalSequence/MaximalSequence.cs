// Problem 4. Maximal sequence
// Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        Console.Title = "Maximal Sequence";
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Enter array,  (elements separeted by ',') --> ");
        char[] input = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => char.Parse(x)).ToArray();
        int sequence = 1;
        int max = 1;
        char one = input[0];

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                sequence++;
            }
            else
            {
                sequence = 1;
            }

            if (sequence > max)
            {
                one = input[i];
                max = sequence;
            }
        }
        Console.WriteLine("The maximal sequence of equal elemets is: ");
        for (int i = 0; i < max; i++)
        {
            Console.Write(one + ", ");
        }
        Console.ReadLine();
    }
}

