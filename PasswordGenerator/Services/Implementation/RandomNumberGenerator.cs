using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator.Services
{
    /// <summary>
    /// Represents class responsible for generating random numbers.
    /// </summary>
    public class RandomNumberGenerator : IDisposable, IRandomNumberGenerator
    {
        #region Fields

        /// <summary>
        /// Cryptographic random number generator.
        /// </summary>
        private readonly RNGCryptoServiceProvider rngCryptoServiceProvider;

        #endregion Fields

        #region Ctors

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomNumberGenerator"/> class.
        /// </summary>
        public RandomNumberGenerator()
        {
            rngCryptoServiceProvider = new RNGCryptoServiceProvider();
        }

        #endregion Ctors

        #region Public methods

        /// <summary>
        /// Generates random integer that is within specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of random number returned.</param>
        /// <param name="maxValue">The exclusive upper bound of random number returned.</param>
        /// <returns>Random non-negative integer number.</returns>
        public int GenerateRandomNumber(int minValue, int maxValue)
        {
            if (minValue >= maxValue || minValue < 0 || maxValue < 0)
                throw new ArgumentException();

            var randomGeneratdeBytes = new byte[sizeof(int)];
            rngCryptoServiceProvider.GetBytes(randomGeneratdeBytes);
            var randomNumber = BitConverter.ToInt32(randomGeneratdeBytes);
            return (int)(minValue + Math.Abs((randomNumber % (maxValue - minValue))));
        }

        /// <summary>
        /// Releases unmanaged resources. 
        /// </summary>
        public void Dispose()
        {
            rngCryptoServiceProvider.Dispose();
        }

        #endregion Public methodsS
    }
}
