﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            Console.WriteLine();
        }
    }
}
