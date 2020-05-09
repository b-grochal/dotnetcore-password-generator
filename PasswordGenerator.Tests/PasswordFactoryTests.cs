using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using PasswordGenerator.Models;
using PasswordGenerator.Services;
using PasswordGenerator.Services.Implementation;

namespace PasswordGenerator.Tests
{
    [TestFixture]
    class PasswordFactoryTests
    {
        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsSimple_ShouldReturnSimplePassword()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 12,
                PasswordType = PasswordType.Simple
            };

            string result = passwordFactory.GeneratePassword(passwordDetails);

            Assert.IsTrue(Regex.IsMatch(result, "^(?=.*[a-z])(?=.*[0-9])[a-z0-9]{12}$"));
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsMedium_ShouldReturnMediumPassword()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 12,
                PasswordType = PasswordType.Medium
            };

            string result = passwordFactory.GeneratePassword(passwordDetails);

            Assert.IsTrue(Regex.IsMatch(result, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{12}$"));
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsStrong_ShouldReturnStrongPassword()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 12,
                PasswordType = PasswordType.Strong
            };

            string result = passwordFactory.GeneratePassword(passwordDetails);

            Assert.IsTrue(Regex.IsMatch(result, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[?!@#$%^&*])[a-zA-Z0-9?!@#$%^&*]{12}$"));
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsSimpleAndInputPasswordLengthIs10_ShouldReturn10CharactersSimplePassword()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 10,
                PasswordType = PasswordType.Simple
            };

            string result = passwordFactory.GeneratePassword(passwordDetails);

            Assert.That(result.Length, Is.EqualTo(10));
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsMediumAndInputPasswordLengthIs10_ShouldReturn10CharactersMediumPassword()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 10,
                PasswordType = PasswordType.Medium
            };

            string result = passwordFactory.GeneratePassword(passwordDetails);

            Assert.That(result.Length, Is.EqualTo(10));
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordTypeIsStrongAndInputPasswordLengthIs10_ShouldReturn10CharactersStrongPassword()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 10,
                PasswordType = PasswordType.Strong
            };

            string result = passwordFactory.GeneratePassword(passwordDetails);

            Assert.That(result.Length, Is.EqualTo(10));
        }

        [Test]
        public void GeneratePassword_WhenInputPasswordLengthIsNotPositive_ShouldThrowArgumentException()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = -1,
                PasswordType = PasswordType.Strong
            };

            Assert.Throws<ArgumentException>(() => passwordFactory.GeneratePassword(passwordDetails));
        }

        public void GeneratePassword_WhenInputPasswordLengthIsEqualToZero_ShouldThrowArgumentException()
        {
            var passwordFactory = new PasswordFactory(new RandomNumberGenerator(), new PasswordCharsetFactory());
            var passwordDetails = new PasswordSettings()
            {
                PasswordLength = 0,
                PasswordType = PasswordType.Strong
            };

            Assert.Throws<ArgumentException>(() => passwordFactory.GeneratePassword(passwordDetails));
        }


    }
}
