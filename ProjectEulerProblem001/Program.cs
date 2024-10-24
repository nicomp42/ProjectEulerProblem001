/*
*Name: Derick Bellofatto
*email:  Bellofdk@mail.uc.edu
*Assignment Number: Assignment InClass10/24/2024
*Due Date: 10/24/2024
*Course #/Section:   IS3050-001
* Semester / Year:   Fall 2024
*Brief Description of the assignment:  Make changes to a repository off github

*Brief Description of what this module does: Module itself finds all multiples of 3 and 5 below 1000 and adds them together
*Citations: Original Document ~ https://github.com/nicomp42/ProjectEulerProblem001
*Anything else that's relevant:
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
