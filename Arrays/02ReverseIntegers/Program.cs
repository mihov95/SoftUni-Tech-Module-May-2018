﻿using System;

namespace _02ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] nums = new int[input];

            for (int i = 0; i < input; i++)
            {
                nums[i] += int.Parse(Console.ReadLine());
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
        }

    }
}
