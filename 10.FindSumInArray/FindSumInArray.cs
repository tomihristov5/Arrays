// Problem 10. Find sum in array
// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Linq;
using System.Collections.Generic;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array,  (elements separeted by ',') --> ");
        int[] myArray = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        Console.Write("s = ");
        int s = int.Parse(Console.ReadLine());
        int currentSum = 0;
        List<int> result = new List<int>();
        CheckSum(myArray, currentSum, result, s);
        PrintResult(myArray, currentSum, result, s);
    }

    static void PrintResult(int[] myArray, int currentSum, List<int> result, int s)
    {
        if (result.Count > 0)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] != result[result.Count - 1])
                {
                    Console.Write("{0}, ", result[i]);
                }
                else
                {
                    Console.WriteLine(result[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("There is no sequence in the array, which sum is equal to {0}", s);
        }
    }

    static void CheckSum(int[] myArray, int currentSum, List<int> result, int s)
    {
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            if (myArray[i] < s)
            {
                int temp = i;
                while (currentSum < s)
                {
                    currentSum += myArray[temp];

                    if (temp == myArray.Length - 1)
                    {
                        break;
                    }
                    temp++;
                }
                if (currentSum == s)
                {
                    for (int j = i; j < temp; j++)
                    {
                        result.Add(myArray[j]);
                    }
                    currentSum = 0;
                }
                else
                {
                    currentSum = 0;
                }
            }
        }
    }
}


