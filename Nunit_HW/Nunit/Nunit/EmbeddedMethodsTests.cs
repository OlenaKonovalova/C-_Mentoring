using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Nunit
{
    [TestFixture]
    public class EmbeddedMethodsTests
    {
        [Category("Ex.1")]
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 9)]
        [TestCase(4, 2, 16)]
        [TestCase(5, 2, 25)]
        [TestCase(6, 2, 36)]
        public void ShouldPowTwoNumbers(int firstNumber, int secondNumber, double expectedNumber)
        {
            Assert.That(Math.Pow(firstNumber, secondNumber), Is.EqualTo(expectedNumber));
        }

        [Category("Ex.1")]
        [Test]
        public void PowTwoNumbers(
            [Values(2,3,4)]int firstNumber, 
            [Values(2)]int secondNumber)
        {
           Math.Pow(firstNumber, secondNumber);
        }

        [Category("Ex.1")]
        [TestCaseSource(typeof(TestCaseSource))]
        public void PowTwoNumbers(int firstNumber, int secondNumber, double expectedValue)
        {
            Assert.That(Math.Pow(firstNumber, secondNumber), Is.EqualTo(expectedValue));
        }

        [Category("Ex.2")]
        [Test]
        public void ShouldBeInRange()
        {
            var randomValue = new Random().Next(5,100);

            Assert.That(randomValue, Is.InRange(5, 100));
        }

        [Category("Ex.3")]
        [Test]
        public void ShouldConcatStringlength()
        {
            string str1 = "Nicole";
            string str2 = "Jack";
            string result = str1 + str2;

            Assert.That(result.Length, Is.EqualTo(str1.Length+str2.Length));
        }

        [Category("Ex.3")]
        [Test]
        public void ShouldStartWithString()
        {
            string str1 = "Nicole";
            string str2 = "Jack";
            string result = str1 + str2;

            Assert.That(result, Does.StartWith(str1));
        }

        [Category("Ex.3")]
        [Test]
        public void ShouldEndWithString()
        {
            string str1 = "Nicole";
            string str2 = "Jack";
            string result = str1 + str2;

            Assert.That(result, Does.EndWith(str2));
        }

        [Category("Ex.4")]
        [Test]
        public void ShouldContainSameSymbols()
        {
            var str = "Olena";

            Assert.That(str.Reverse(), Is.EquivalentTo(str));
        }

        #region Test Data
        public class TestCaseSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new[] { 2, 2, 4 };
                yield return new[] { 3, 2, 9 };
                yield return new[] { 4, 2, 16 };
                yield return new[] { 5, 2, 25 };
            }
        }
        #endregion




    }
}
