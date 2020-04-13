using System;
using System.Text;

namespace PasswordGenerator.Services
{
    class PasswordFactory : IFactory
    {
        public string generateMediumPassword(int passwordLength)
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

        public string generateSimplePassword(int passwordLength)
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

        public string generateStrongPassword(int passwordLength)
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
