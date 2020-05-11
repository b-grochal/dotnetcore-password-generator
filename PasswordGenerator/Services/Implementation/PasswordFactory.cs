using PasswordGenerator.Extensions;
using PasswordGenerator.Models;
using PasswordGenerator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services
{
    /// <summary>
    /// Represents factory responsible for generating different passwords.
    /// </summary>
    public class PasswordFactory : IPasswordFactory
    {
        #region Fields

        /// <summary>
        /// Passwords' charsets factory.
        /// </summary>
        private readonly IPasswordCharsetFactory passwordCharsetFactory;

        /// <summary>
        /// Random number generator.
        /// </summary>
        private readonly IRandomNumberGenerator randomNumberGenerator;

        #endregion Fields

        #region Ctors

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordFactory"/> class.
        /// </summary>
        /// <param name="randomNumberGenerator">Random number generator.</param>
        /// <param name="passwordCharsetFactory">Passwords' charsets factory.</param>
        public PasswordFactory(IRandomNumberGenerator randomNumberGenerator, IPasswordCharsetFactory passwordCharsetFactory)
        {
            this.randomNumberGenerator = randomNumberGenerator;
            this.passwordCharsetFactory = passwordCharsetFactory;
        }

        #endregion Ctors

        #region Public methods

        /// <summary>
        /// Generates password of passed type.
        /// </summary>
        /// <param name="passwordSettings">Password's type.</param>
        /// <returns>Generated password.</returns>
        public string GeneratePassword(PasswordSettings passwordSettings)
        {
            if (passwordSettings.PasswordLength < 4)
                throw new ArgumentException();

            return passwordSettings.PasswordType switch
            {
                PasswordType.Simple => GenerateSimplePassword(passwordSettings.PasswordLength),
                PasswordType.Medium => GenerateMediumPassword(passwordSettings.PasswordLength),
                PasswordType.Strong => GenerateStrongPassword(passwordSettings.PasswordLength),
                _ => throw new ArgumentException()
            };
        }

        #endregion Public methods

        #region Private methods

        /// <summary>
        /// Generates simple password.
        /// </summary>
        /// <param name="passwordLength">Length of password.</param>
        /// <returns>Generated password.</returns>
        private string GenerateSimplePassword(int passwordLength)
        {
            var passwordChars = new List<char>();
            var passwordCharset = passwordCharsetFactory.GetSimplePasswordCharset();

            foreach(var s in passwordCharset)
            {
                passwordChars.Add(s[randomNumberGenerator.GenerateRandomNumber(0, s.Length)]);
            }

            var index = passwordChars.Count;

            while (index < passwordLength)
            {
                var randomCharset = passwordCharset[randomNumberGenerator.GenerateRandomNumber(0, passwordCharset.Length)];
                var randomChar = randomCharset[randomNumberGenerator.GenerateRandomNumber(0, randomCharset.Length)];
                if (!passwordChars.Contains(randomChar))
                {
                    passwordChars.Add(randomChar);
                    index++;
                }
            }
            return passwordChars.Shuffle().GenerateString();

        }

        /// <summary>
        /// Generates medium password.
        /// </summary>
        /// <param name="passwordLength">Length of password.</param>
        /// <returns>Generated password.</returns>
        private string GenerateMediumPassword(int passwordLength)
        {
            var passwordChars = new List<char>();
            var passwordCharset = passwordCharsetFactory.GetMediumPasswordCharset();

            foreach (var s in passwordCharset)
            {
                passwordChars.Add(s[randomNumberGenerator.GenerateRandomNumber(0, s.Length)]);
            }

            var index = passwordChars.Count;

            while (index < passwordLength)
            {
                var randomCharset = passwordCharset[randomNumberGenerator.GenerateRandomNumber(0, passwordCharset.Length)];
                var randomChar = randomCharset[randomNumberGenerator.GenerateRandomNumber(0, randomCharset.Length)];
                if (!passwordChars.Contains(randomChar))
                {
                    passwordChars.Add(randomChar);
                    index++;
                }
            }
            return passwordChars.Shuffle().GenerateString();

        }

        /// <summary>
        /// Generates strong password.
        /// </summary>
        /// <param name="passwordLength">Length of password.</param>
        /// <returns>Generated password.</returns>
        private string GenerateStrongPassword(int passwordLength)
        {
            var passwordChars = new List<char>();
            var passwordCharset = passwordCharsetFactory.GetStrongPasswordCharset();

            foreach (var s in passwordCharset)
            {
                passwordChars.Add(s[randomNumberGenerator.GenerateRandomNumber(0, s.Length)]);
            }

            var index = passwordChars.Count;

            while (index < passwordLength)
            {
                var randomCharset = passwordCharset[randomNumberGenerator.GenerateRandomNumber(0, passwordCharset.Length)];
                var randomChar = randomCharset[randomNumberGenerator.GenerateRandomNumber(0, randomCharset.Length)];
                if (!passwordChars.Contains(randomChar))
                {
                    passwordChars.Add(randomChar);
                    index++;
                }
            }
            return passwordChars.Shuffle().GenerateString();
        }

        #endregion Private methods
    }
}
