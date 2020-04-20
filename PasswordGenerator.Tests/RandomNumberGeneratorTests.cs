using NUnit.Framework;
using PasswordGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Tests
{
    [TestFixture]
    class RandomNumberGeneratorTests
    {
        [Test]
        public void GenerateRandomNumber_WhenInputMinValueIs1AndInputMaxValueIs10_ShouldReturnNumberBetween1And10()
        {

        }

        [Test]
        public void GenerateRandomNumber_WhenInputMinValueIsGreaterThanInputMaxValue_ShouldThrowArgumentException()
        {

        }

        [Test]
        public void GenerateRandomNumber_WhenInputMinValuesIsEqualToInputMaxValue_ShouldThrowArgumentException()
        {

        }
    }
}
