using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAssignmentsWeek1.Solutions
{
    public class ReverseAndConcatenate
    {
        public static string Perform(int i)
        {
            return new string(i.ToString().Reverse().ToArray()) + i;
        }
    }
}
