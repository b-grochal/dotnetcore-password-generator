using PasswordGenerator.Helpers;
using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services
{
    class PasswordFactory : IPasswordFactory
    {
        private readonly string[] charsTable;

        public PasswordFactory()
        {
            charsTable = new string[]
            {
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "1234567890",
                "?!@#$%^&*",
            };
        }

        public string GeneratePassword(PasswordSettings passwordSettings)
        {
            return passwordSettings.PasswordType switch
            {
                PasswordType.Simple => GenerateSimplePassword(passwordSettings.PasswordLength),
                PasswordType.Medium => GenerateMediumPassword(passwordSettings.PasswordLength),
                PasswordType.Strong => GenerateStrongPassword(passwordSettings.PasswordLength),
                _ => throw new ArgumentException()
            };
        }

        private string GenerateSimplePassword(int passwordLength)
        {
            List<char> passwordChars = new List<char>();
            int index = 0;

            using RandomNumberGenerator rng = new RandomNumberGenerator();

            while (index < passwordLength)
            {
                char randomChar = charsTable[0][rng.GenerateRandomNumber(0, charsTable[0].Length)];
                if (!passwordChars.Contains(randomChar))
                {
                    passwordChars.Add(randomChar);
                    index++;
                }
            }
            return passwordChars.Shuffle().GenerateString();

        }

        //Litery (male i duze) + cyfry
        private string GenerateMediumPassword(int passwordLength)
        {
            List<char> passwordChars = new List<char>();

            using RandomNumberGenerator rng = new RandomNumberGenerator();

            //mala litera
            passwordChars.Add(charsTable[0][rng.GenerateRandomNumber(0, charsTable[0].Length)]);
            //duza litera
            passwordChars.Add(charsTable[1][rng.GenerateRandomNumber(0, charsTable[1].Length)]);
            //cyfra
            passwordChars.Add(charsTable[2][rng.GenerateRandomNumber(0, charsTable[2].Length)]);

            int index = passwordChars.Count;

            while (index < passwordLength)
            {
                string randomCharset = charsTable[rng.GenerateRandomNumber(0, charsTable.Length)];
                char randomChar = randomCharset[rng.GenerateRandomNumber(0, randomCharset.Length)];
                if (!passwordChars.Contains(randomChar))
                {
                    passwordChars.Add(randomChar);
                    index++;
                }
            }
            return passwordChars.Shuffle().GenerateString();

        }



        private string GenerateStrongPassword(int passwordLength)
        {
            List<char> passwordChars = new List<char>();

            using RandomNumberGenerator rng = new RandomNumberGenerator();

            //mala litera
            passwordChars.Add(charsTable[0][rng.GenerateRandomNumber(0, charsTable[0].Length)]);
            //duza litera
            passwordChars.Add(charsTable[1][rng.GenerateRandomNumber(0, charsTable[1].Length)]);
            //cyfra
            passwordChars.Add(charsTable[2][rng.GenerateRandomNumber(0, charsTable[2].Length)]);
            //znak specjalny
            passwordChars.Add(charsTable[3][rng.GenerateRandomNumber(0, charsTable[3].Length)]);

            int index = passwordChars.Count;

            while (index < passwordLength)
            {
                string randomCharset = charsTable[rng.GenerateRandomNumber(0, charsTable.Length)];
                char randomChar = randomCharset[rng.GenerateRandomNumber(0, randomCharset.Length)];
                if (!passwordChars.Contains(randomChar))
                {
                    passwordChars.Add(randomChar);
                    index++;
                }
            }
            return passwordChars.Shuffle().GenerateString();

        }
    }
}
