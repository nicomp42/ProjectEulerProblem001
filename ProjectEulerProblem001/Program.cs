/*
* Name: Peter Phan
* email:  phanpv@mail.uc.edu
* Assignment Number: Assignment INCLASS 
* Due Date:   10 / 24 / 2024
* Course #/Section:   IS3050-001
* Semester / Year:   Fall semester 2024
* Brief Description of the assignment:  Learning about Github features alongside C#

* Brief Description of what this module does. Introduce us to Methods and Github in C#
* Citations:
* Anything else that's relevant:
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
