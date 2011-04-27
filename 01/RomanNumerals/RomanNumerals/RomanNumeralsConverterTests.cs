using System;
using NUnit.Framework;
using FluentAssertions;

namespace RomanNumerals {
    [TestFixture]
    public class RomanNumeralsConverterTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        public void Should_Convert_Number_to_Roman(int number, string expected)
        {
            var romNum = new RomanNumeralsConverter();
            var result = romNum.NumberToRoman(number);
            Assert.AreEqual(expected, result);
        }


    }
}
