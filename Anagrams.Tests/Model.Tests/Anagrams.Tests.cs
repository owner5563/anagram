using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;
using System;

namespace Anagrams.Tests
{
    [TestClass]
    public class WordsTests
    {
        [TestMethod]
        public void SplitWord_GenerateArray_Array()
        {
            Words testWords = new Words();
            CollectionAssert.AreEqual(new char[] { "W", "o", "r", "d" }, testWords.SplitWord("Word"));
        }
    }
}
