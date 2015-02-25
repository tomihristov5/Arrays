// Problem 11. Binary search
// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
// Problem 11. Binary search
// Write a program that finds the index of given element
// in a sorted array of integers by using the Binary search algorithm

class BinarySearch
{
    static void Main()
    {
        Console.Title = "Binary search";
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        int[] myArray = { 1, 6, 34, 37, 11, 13, 45, 21, 46, 53, 2, 34, 23, 11 };
        Array.Sort(myArray);
        int start = 0;
        int end = myArray.Length - 1;
        int middle = myArray.Length / 2;
        int number = int.Parse(Console.ReadLine());
        while (start < end)
        {
            if (number < myArray[start] || number > myArray[end])
            {
                Console.WriteLine("There is no such number in the array!");
                break;
            }
            else if (number < myArray[middle])
            {
                end = middle;
                middle = (end - start) / 2 + start;

                if (middle == end)
                {
                    middle--;
                }
            }
            else if (number > myArray[middle])
            {
                start = middle;
                middle = (end - start) / 2 + start;

                if (middle == start)
                {
                    middle++;
                }
            }
            else if (number == myArray[middle])
            {
                Console.WriteLine("The index of {0} in the array is: {1}", number, middle);
                break;
            }
        }
    }
}

