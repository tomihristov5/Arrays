// Problem 2. Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first array, integers separeted by ',' ");
        string[] firstInput = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter second array, itnegers separeted by',' ");
        string[] secondInput = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int elements = 0;
        if (firstInput.Length > secondInput.Length)
        {
            Console.WriteLine("The first array has {0} numbers less", firstInput.Length - secondInput.Length);
        }
        else if (firstInput.Length < secondInput.Length)
        {
            Console.WriteLine("The second array has {0} numbers less", secondInput.Length - firstInput.Length);
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
                Console.WriteLine("The arrays are the same ");
            }
        }
    }
}

