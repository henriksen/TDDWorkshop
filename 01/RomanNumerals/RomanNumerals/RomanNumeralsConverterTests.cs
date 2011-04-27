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
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(13, "XIII")]
        [TestCase(33, "XXXIII")]
        [TestCase(49, "ILIX")]
        [TestCase(50, "L")]
        [TestCase(3888, "MMMDCCCLXXXVIII")]
        public void Should_Convert_Number_to_Roman(int number, string expected)
        {
            var romNum = new RomanNumeralsConverter();
            var result = romNum.NumberToRoman(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Number_greater_than_3999_should_thow_exception()
        {
            var romNum = new RomanNumeralsConverter();
            romNum.NumberToRoman(4000);
        }

    }
}
