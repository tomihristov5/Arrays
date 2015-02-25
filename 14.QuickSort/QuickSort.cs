﻿using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;
            while (numbers[right] > pivot)
                right--;
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if (pivot > 1)
                QuickSort_Recursive(arr, left, pivot - 1);
            if (pivot + 1 < right)
                QuickSort_Recursive(arr, pivot + 1, right);
        }
    }
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
        Console.Write("Before sort: ");
        foreach (var num in numbers)
        {
            Console.Write(" " + num);
        }
        int len = 9;
        Console.WriteLine();
        Console.Write("QuickSort: ");
        QuickSort_Recursive(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
            Console.Write(" " + numbers[i]);
        Console.WriteLine();
    }
}

