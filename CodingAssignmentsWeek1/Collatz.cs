using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAssignmentsWeek1
{
    public class Collatz
    {
        public static string CompareCollatzSteps(int a, int b)
        {
            int stepsA = CountCollatzSteps(a);
            int stepsB = CountCollatzSteps(b);

            return stepsA < stepsB ? "a" : "b";
        }

        // private function below to separate main function of solution which is declared above for a and b integers, hence runs twice for comparison

        private static int CountCollatzSteps(int n)
        {
            int steps = 0;

            while (n != 1)
            {
                // if n is divisible by 2, use modulo, %
                if (n % 2 == 0)
                {
                    // similar to increment/decrement, but dividing
                    n /= 2;
                }
                else
                {
                    n = (3 * n) + 1;
                }

                // increments by +1
                steps++;
            }

            return steps;
        }
    }
}
