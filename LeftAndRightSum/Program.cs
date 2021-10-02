﻿using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum1 += input;
            }

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum2 += input;
            }
            
            double difference = Math.Abs(sum1 - sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {                
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
