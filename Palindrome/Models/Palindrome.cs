using System;
using System.Collections.Generic;

namespace PalindromeFinder
{
    public class Palindrome
    {
        public string Word { get; set; }

        public Palindrome(string word)
        {
            Word = word;
        }

        public bool IsPalindrome()
        {
            char[] charArray = Word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);
            if (Word == reversedWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}