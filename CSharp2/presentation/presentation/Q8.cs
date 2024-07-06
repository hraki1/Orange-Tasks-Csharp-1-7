﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    public class Q8
    {
        public void printPattren()
        {
            int rows = 4; 
            int currentNumber = 1; 
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" "); 
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{currentNumber} "); 
                    currentNumber++; 
                }

                Console.WriteLine(); 
            }
        }
    }
}