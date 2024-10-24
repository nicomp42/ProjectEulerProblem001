﻿/* Name: Andrea Gauthier
 email: gauthiaj@mail.uc.edu
 Assignment Title: Clone Assignment
 Due Date: 10/24/2024
 Course: IS 3050
 Semester/Year: Fall 2024
 Brief Description: This project is about creating a clone repository
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEulerProblem001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SolveProjectEulerProblem001());
        }
        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below 1000
        /// https://projecteuler.net/problem=1
        /// </summary>
        /// <returns>The solution to the problem</returns>
        static int SolveProjectEulerProblem001()
        {
            int sum = 0;
            for (int i =0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
