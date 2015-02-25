// Problem 20.* Variations of set
// Write a program that reads two numbers N and K and generates all
// the variations of K elements from the set [1..N].

using System;

class VariationsOfSet
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int conv;
        for (int i = 0; i < Math.Pow(n, k); i++)
        {
            conv = i;
            int[] array = new int[k];
            for (int j = 0; j < k; j++)
            {
                array[k - j - 1] = conv % n;
                conv = conv / n;
            }
            Console.Write("{0}{1}", '{', array[0] + 1);
            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", array[j] + 1);
            }
            Console.WriteLine("}");
        }
    }
}
