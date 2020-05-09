using PasswordGenerator.Extensions;
using PasswordGenerator.Models;
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
        /// Valid characters used to generate password.
        /// </summary>
        private readonly string[] charsTable;

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
        public PasswordFactory(IRandomNumberGenerator randomNumberGenerator)
        {
            charsTable = new string[]
            {
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "1234567890",
                "?!@#$%^&*",
            };
            this.randomNumberGenerator = randomNumberGenerator;
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
            if (passwordSettings.PasswordLength <= 0)
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
            List<char> passwordChars = new List<char>();
            int index = 0;

            while (index < passwordLength)
            {
                char randomChar = charsTable[0][randomNumberGenerator.GenerateRandomNumber(0, charsTable[0].Length)];
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
            List<char> passwordChars = new List<char>();

            passwordChars.Add(charsTable[0][randomNumberGenerator.GenerateRandomNumber(0, charsTable[0].Length)]);
            passwordChars.Add(charsTable[1][randomNumberGenerator.GenerateRandomNumber(0, charsTable[1].Length)]);
            passwordChars.Add(charsTable[2][randomNumberGenerator.GenerateRandomNumber(0, charsTable[2].Length)]);

            int index = passwordChars.Count;

            while (index < passwordLength)
            {
                string randomCharset = charsTable[randomNumberGenerator.GenerateRandomNumber(0, charsTable.Length-1)];
                char randomChar = randomCharset[randomNumberGenerator.GenerateRandomNumber(0, randomCharset.Length)];
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
            List<char> passwordChars = new List<char>();

            passwordChars.Add(charsTable[0][randomNumberGenerator.GenerateRandomNumber(0, charsTable[0].Length)]);
            passwordChars.Add(charsTable[1][randomNumberGenerator.GenerateRandomNumber(0, charsTable[1].Length)]);
            passwordChars.Add(charsTable[2][randomNumberGenerator.GenerateRandomNumber(0, charsTable[2].Length)]);
            passwordChars.Add(charsTable[3][randomNumberGenerator.GenerateRandomNumber(0, charsTable[3].Length)]);

            int index = passwordChars.Count;

            while (index < passwordLength)
            {
                string randomCharset = charsTable[randomNumberGenerator.GenerateRandomNumber(0, charsTable.Length)];
                char randomChar = randomCharset[randomNumberGenerator.GenerateRandomNumber(0, randomCharset.Length)];
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
