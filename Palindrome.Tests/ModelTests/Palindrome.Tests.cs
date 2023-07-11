using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeFinder;
using System.Collections.Generic;
using System;

namespace PalindromeFinder.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void PalindromeConstuctor_CreatesInstanceOfPalindrome_Palindrome()
        {
            string word = "tacocat";
            Palindrome newPalindrome = new Palindrome(word);
            Assert.AreEqual(typeof(Palindrome), newPalindrome.GetType());
        }

        [TestMethod]
        public void PalindromeConstuctor_CreatesInstanceOfPalindromeWithProperty_String()
        {
            string word = "tacocat";
            Palindrome newPalindrome = new Palindrome(word);
            Assert.AreEqual(word, newPalindrome.Word);
        }
    }
}