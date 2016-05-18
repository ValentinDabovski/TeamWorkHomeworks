﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sort_Array_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(Convert.ToInt32(input[i]));       
              
            }

            numbers.Sort();

            foreach (var num in numbers)
            {
              
                Console.Write("{0}" + " ",num);
            }
        }
    }
}
