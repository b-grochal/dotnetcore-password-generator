using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator.Helpers
{
    public class RandomNumberGenerator : IDisposable
    {
        private readonly RNGCryptoServiceProvider rngCryptoServiceProvider;

        public RandomNumberGenerator()
        {
            rngCryptoServiceProvider = new RNGCryptoServiceProvider();
        }

        public int GenerateRandomNumber(int minValue, int maxValue)
        {
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException();

            byte[] randomGeneratdeBytes = new byte[sizeof(int)];
            rngCryptoServiceProvider.GetBytes(randomGeneratdeBytes);
            int randomNumber = BitConverter.ToInt32(randomGeneratdeBytes);
            return (int)(minValue + Math.Abs((randomNumber % (maxValue - minValue))));
        }

        public void Dispose()
        {
            rngCryptoServiceProvider.Dispose();
        }
    }
}
