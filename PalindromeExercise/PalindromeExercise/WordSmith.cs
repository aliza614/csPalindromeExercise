using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string s)
        {   /*s=s.ToLower();
            for(int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length-1-i]) return false;
            }
            return true;*/

            return s.Replace(" ","").ToLower().SequenceEqual(s.ToLower().Replace(" ","").Reverse());
        }
    }
}
