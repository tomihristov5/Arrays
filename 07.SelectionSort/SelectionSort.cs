// Problem 7. Selection sort
// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array
// Use the Selection sort algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            }
            return numbers;
        }
        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter array,  (elements separeted by ',') --> ");
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            int[] numbers1 = Sort(numbers);
            PrintNumbers(numbers1);
            Console.WriteLine();
        }
    }
}
