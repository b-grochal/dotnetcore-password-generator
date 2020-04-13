using PasswordGenerator.Models;
using System;
using System.Text;

namespace PasswordGenerator.Services
{
    class PasswordFactory : IFactory
    {

        public string GeneratePassword(PasswordSettings passwordSettings)
        {
            string password = null;
            switch (passwordSettings.PasswordType)
            {
                case PasswordType.Simple:
                    password = GenerateSimplePassword(passwordSettings.PasswordLength);
                    break;
                case PasswordType.Medium:
                    password = GenerateMediumPassword(passwordSettings.PasswordLength);
                    break;
                case PasswordType.Strong:
                    password = GenerateStrongPassword(passwordSettings.PasswordLength);
                    break;
            }
            return password;
        }


        private string GenerateMediumPassword(int passwordLength)
        {
           string charset = "abcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for(int i = 0; i < passwordLength; i++)
            {
                password.Append(charset[random.Next(charset.Length)]);
            }
            return password.ToString();
        }

        private string GenerateSimplePassword(int passwordLength)
        {
            string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                password.Append(charset[random.Next(charset.Length)]);
            }
            return password.ToString();
        }

        private string GenerateStrongPassword(int passwordLength)
        {
            string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!@#$%^&*";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                password.Append(charset[random.Next(charset.Length)]);
            }
            return password.ToString();
        }
    }
}
