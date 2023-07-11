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

        [TestMethod]
        public void IsPalindrome_ChecksIfWordIsPalindrome_True()
        {
            string word = "tacocat";
            Palindrome newPalindrome = new Palindrome(word);
            Assert.AreEqual(true, newPalindrome.IsPalindrome());
        }

        [TestMethod]
        public void IsPalindrome_ChecksIfWordIsPalindrome_False()
        {
            string word = "NotAPalindrome";
            Palindrome newPalindrome = new Palindrome(word);
            Assert.AreEqual(false, newPalindrome.IsPalindrome());
        }
    }
}