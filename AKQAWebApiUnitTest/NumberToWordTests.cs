using System;
using NUnit;
using NUnit.Framework;
using AKQACodingTestApp.Models;
namespace AKQAWebApiUnitTest
{
    [TestFixture]
    public class NumberToWordTests
    {
        [TestCase(1,"One Dollar")]
        [TestCase(2, "Two Dollars")]
        [TestCase(2.0, "Two Dollars")]
        [TestCase(-2, "Negative Two Dollars")]
        [TestCase(10, "Ten Dollars")]
        [TestCase(123.45, "One Hundred Twenty-Three Dollars and forty-five Cents")]
        public void ShouldReturnValidWordConversion(decimal number,string expectedResult)
        {
            var sut = new NumberToWord();
            var result = sut.NumberToCurrencyText(number);

            Assert.That(result, Is.EqualTo(expectedResult.ToUpper()));
        }
    }
}
