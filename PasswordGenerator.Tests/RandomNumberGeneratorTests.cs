using NUnit.Framework;
using PasswordGenerator.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Tests
{
    [TestFixture]
    class RandomNumberGeneratorTests
    {
        [Test]
        public void GenerateRandomNumber_WhenInputMinValueIs1AndInputMaxValueIs3_ShouldReturnNumberBetween1And3()
        {
            using var randomNumberGenerator = new RandomNumberGenerator();
            var result = randomNumberGenerator.GenerateRandomNumber(1, 3);
            Assert.IsTrue(result >= 1 && result < 3);
        }

        [Test]
        public void GenerateRandomNumber_WhenInputMinValueIsGreaterThanInputMaxValue_ShouldThrowArgumentException()
        {
            using var randomNumberGenerator = new RandomNumberGenerator();
            Assert.Throws<ArgumentException>(() => randomNumberGenerator.GenerateRandomNumber(2, 1));
        }

        [Test]
        public void GenerateRandomNumber_WhenInputMinValueIsEqualToInputMaxValue_ShouldThrowArgumentException()
        {
            using var randomNumberGenerator = new RandomNumberGenerator();
            Assert.Throws<ArgumentException>(() => randomNumberGenerator.GenerateRandomNumber(1, 1));
        }

        [Test]
        public void GenerateRandomNumber_WhenInputMinValueIsNegative_ShouldThrowArgumentException()
        {
            using var randomNumberGenerator = new RandomNumberGenerator();
            Assert.Throws<ArgumentException>(() => randomNumberGenerator.GenerateRandomNumber(-1, 3));
        }

        [Test]
        public void GenerateRandomNumber_WhenInputMaxValueIsNegative_ShouldThrowArgumentException()
        {
            using var randomNumberGenerator = new RandomNumberGenerator();
            Assert.Throws<ArgumentException>(() => randomNumberGenerator.GenerateRandomNumber(1, -3));
        }

        [Test]
        public void GenerateRandomNumber_WhenInputMinValueAndInputMaxValueAreNegative_ShouldThrowArgumentException()
        {
            using var randomNumberGenerator = new RandomNumberGenerator();
            Assert.Throws<ArgumentException>(() => randomNumberGenerator.GenerateRandomNumber(-1, -3));
        }

    }
}
