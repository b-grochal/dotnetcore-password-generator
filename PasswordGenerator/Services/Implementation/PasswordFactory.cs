using PasswordGenerator.Helpers;
using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services
{
    public class PasswordFactory : IPasswordFactory
    {
        private readonly string[] charsTable;
        private readonly IRandomNumberGenerator randomNumberGenerator;

        public PasswordFactory()
        {
            charsTable = new string[]
            {
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "1234567890",
                "?!@#$%^&*",
            };
            randomNumberGenerator = new RandomNumberGenerator();
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

        //małe litery
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

        //Litery (male i duze) + cyfry
        private string GenerateMediumPassword(int passwordLength)
        {
            List<char> passwordChars = new List<char>();

            //mala litera
            passwordChars.Add(charsTable[0][randomNumberGenerator.GenerateRandomNumber(0, charsTable[0].Length)]);
            //duza litera
            passwordChars.Add(charsTable[1][randomNumberGenerator.GenerateRandomNumber(0, charsTable[1].Length)]);
            //cyfra
            passwordChars.Add(charsTable[2][randomNumberGenerator.GenerateRandomNumber(0, charsTable[2].Length)]);

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



        private string GenerateStrongPassword(int passwordLength)
        {
            List<char> passwordChars = new List<char>();

            //mala litera
            passwordChars.Add(charsTable[0][randomNumberGenerator.GenerateRandomNumber(0, charsTable[0].Length)]);
            //duza litera
            passwordChars.Add(charsTable[1][randomNumberGenerator.GenerateRandomNumber(0, charsTable[1].Length)]);
            //cyfra
            passwordChars.Add(charsTable[2][randomNumberGenerator.GenerateRandomNumber(0, charsTable[2].Length)]);
            //znak specjalny
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
    }
}
