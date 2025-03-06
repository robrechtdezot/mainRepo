using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_challenges
{
    class reverseInt
    {
        public class IntReverse
        {

            /* public int ReverseInteger(int start)
             {
                 var reverse = string.Join("", Math.Abs(start).ToString().Reverse());
                 return int.Parse(reverse) * Math.Sign(start);
             }
            Half right
            public class Solution {
    public bool IsPalindrome(int x) 
    {
         var reverse = string.Join("", Math.Abs(x).ToString().Reverse());
        double reversedNumber = double.Parse(reverse) * Math.Sign(x);

        if (x == Math.Abs(reversedNumber))
        {
         return true;
        }
        else
        {
        return false;
         }
    }
}
             */
            public IntReverse() { }

            public bool IsPalindrome(int x)
            {
                if (x < 0 || x == int.MinValue)
                {
                    return false;
                }
                int original = x;
                int reversed = 0;
                while (x != 0)
                {
                    int pop = x % 10;
                    x /= 10;
                    // Check for overflow
                    if (reversed > (int.MaxValue - pop) / 10)
                    {
                        return false;
                    }
                    reversed = reversed * 10 + pop;
                }
                return original == reversed;
            

            }

        }
    }
}