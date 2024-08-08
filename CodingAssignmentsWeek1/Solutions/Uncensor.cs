using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAssignmentsWeek1.Solutions
{
    public class Uncensor
    {
        public static string Perform(string censoredString, string vowels)
        {
            // vowels should be identified like an array and then set to 0 to initialise the variable
            int vowelIndex = 0;
            char[] result = censoredString.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '*')
                {
                    result[i] = vowels[vowelIndex];
                    vowelIndex++;
                }
            }

            return new string(result);
        }
    }
}
