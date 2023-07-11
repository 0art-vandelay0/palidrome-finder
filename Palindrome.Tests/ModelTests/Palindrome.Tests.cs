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
            Palindrome newPalindrome = new Palindrome();
            Assert.AreEqual(typeof(Palindrome), newPalindrome.GetType());
        }
    }
}