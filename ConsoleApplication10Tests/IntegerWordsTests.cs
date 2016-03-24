using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordsFromInteger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsFromInteger.Tests
{
    [TestClass()]
    public class IntegerWordsTests
    {
        [TestMethod()]
        public void ZeroTest()
        {
            string expected = "zero";
            string actual = new IntegerWords().WordsFromInteger(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TeenTest()
        {
            string expected = "twelve";
            string actual = new IntegerWords().WordsFromInteger(12);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void OnesTest()
        {
            string expected = "two";
            string actual = new IntegerWords().WordsFromInteger(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Twenty2Test()
        {
            string expected = "twenty two";
            string actual = new IntegerWords().WordsFromInteger(22);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void OneHundredTwo()
        {
            string expected = "one hundred two";
            string actual = new IntegerWords().WordsFromInteger(102);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void OneThousandThreeHundredFourteen()
        {
            string expected = "one thousand three hundred fourteen";
            string actual = new IntegerWords().WordsFromInteger(1314);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TwentyMillionOneThousandThreeHundredFourteen()
        {
            string expected = "twenty million one thousand three hundred fourteen";
            string actual = new IntegerWords().WordsFromInteger(20001314);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TwentyMillionOne()
        {
            string expected = "twenty million one";
            string actual = new IntegerWords().WordsFromInteger(20000001);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TooLarge()
        {
            string expected = "Error too large";
            string actual = new IntegerWords().WordsFromInteger(1000000000);
            Assert.AreEqual(expected, actual);
        }

    }
}