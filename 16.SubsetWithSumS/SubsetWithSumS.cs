// Problem 16.* Subset with sum S
// We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetWithSumS
{
    static void Main()
    {
        int[] myArray = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());
        bool isSubsetSum = false;
        int max = (int)Math.Pow(2, myArray.Length);
        for (int i = 0; i < max - 1; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < myArray.Length; j++)
            {
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = (iAndMask >> j);
                if (bit == 1)
                {
                    currentSum += myArray[j];
                }
            }
            if (currentSum == s)
            {
                isSubsetSum = true;
            }
        }
        Console.WriteLine(isSubsetSum == true ? "Yes" : "No");
    }
}
