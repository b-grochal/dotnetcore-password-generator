using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PasswordGenerator.Services;

namespace PasswordGenerator.Tests
{
    [TestFixture]
    class PasswordFactoryTests
    {
        private PasswordFactory passwordFactory;

        [SetUp]
        public void SetUp()
        {
            passwordFactory = new PasswordFactory();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsSimple_ShouldReturnSimplePassword()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsMedium_ShouldReturnMediumPassword()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsStrong_ShouldReturnStrongPassword()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsSimpleAndPasswordLengthIs10_ShouldReturn10CharactersSimplePassword()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsMediumAndPasswordLengthIs10_ShouldReturn10CharactersMediumPassword()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsStrongAndPasswordLengthIs10_ShouldReturn10CharactersStrongPassword()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsNull_ShouldThrowArgumentException()
        {
            Assert.Pass();
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordLengthIsNotPositive_ShouldThrowArgumentException()
        {
            Assert.Pass();
        }


    }
}
