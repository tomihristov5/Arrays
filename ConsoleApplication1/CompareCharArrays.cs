// Problem 3. Compare char arrays
// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first array,  (separeted by ',') --> ");
        string[] firstInput = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter second array, (separeted by ',') --> ");
        string[] secondInput = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int elements = 0;
        if (firstInput.Length > secondInput.Length)
        {
            Console.WriteLine("The first array has {0} numbers less", firstInput.Length - secondInput.Length);
        }
        else if (firstInput.Length < secondInput.Length)
        {
            Console.WriteLine("The second array has {0} numbers less)", secondInput.Length - firstInput.Length);
        }
        else
        {
            for (int counter = 0; counter < firstInput.Length; counter++)
            {
                if (firstInput[counter] != secondInput[counter])
                {
                    elements++;
                }
            }
            if (elements != 0)
            {
                Console.WriteLine("The arrays have same lenght but {0} different elements", elements);
            }
            else
            {
                Console.WriteLine("The arrays are the same, i cant believe it :) ");
            }
        }
    }
}

