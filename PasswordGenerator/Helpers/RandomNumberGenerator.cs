using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator.Helpers
{
    public class RandomNumberGenerator
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
            int scale = int.MaxValue;

            while(scale == int.MaxValue)
            {
                rngCryptoServiceProvider.GetBytes(randomGeneratdeBytes);
                scale = BitConverter.ToInt32(randomGeneratdeBytes);
            }

            return (int)(minValue + (maxValue - minValue) * (scale / int.MaxValue));
        }
    }
}
