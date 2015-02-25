// Problem 12. Index of letters
// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexesOfLetters
{
    static void Main(string[] args)
    {
        char[] myArray = new char[26];
        for (int i = 0; i < 26; i++)
        {
            myArray[i] = (char)(65 + i);
        }
        Console.Write("Write a word: ");
        string word = Console.ReadLine().ToUpper();
        int index = -2;
        for (int i = 0; i < word.Length; i++)
        {
            index = Array.IndexOf(myArray, word[i]);
            Console.WriteLine("The index of {0} is {1}", word[i], index);
        }
    }
}
