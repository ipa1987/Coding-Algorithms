using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAssignmentsWeek1.Solutions
{
    public class AlmostPalindrome
    {
        public static bool IsAlmostPalindrome(string s)
        {
            // indexing of each character in the string, like an array. Hence left and right
            int left = 0;
            int right = s.Length - 1;
            int mismatchCount = 0;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    mismatchCount++;
                    if (mismatchCount > 1)
                    {
                        return false;
                    }
                }
                left++;
                right--;
            }

            // Return true if there is exactly one mismatch and the string is not already a palindrome
            return mismatchCount == 1;
        }

        private static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
