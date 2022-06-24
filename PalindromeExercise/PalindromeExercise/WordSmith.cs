using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string s)
        {
            for(int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length-1-i]) return false;
            }
            return true;
        }
    }
}
