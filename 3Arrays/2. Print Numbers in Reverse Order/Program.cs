﻿namespace _2._Print_Numbers_in_Reverse_Order
{
    using System;
    using System.Security;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            for (int i = numbers.Length-1; i >=0 ; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
