using PasswordGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="IList{T}"/> collection.
    /// </summary>
    public static class ListExtension
    {
        #region Public methods

        /// <summary>
        /// Shuffles input collection.
        /// </summary>
        /// <param name="source">Input collection.</param>
        /// <returns>Shuffled collection.</returns>
        public static IList<char> Shuffle(this IList<char> source)
        {
            using RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            var n = source.Count;
            while (n > 1)
            {
                n--;
                var k = randomNumberGenerator.GenerateRandomNumber(0, n + 1);
                var c = source[k];
                source[k] = source[n];
                source[n] = c;
            }
            return source;
        }

        /// <summary>
        /// Generates string form chars' collection.
        /// </summary>
        /// <param name="source">Input collection.</param>
        /// <returns>String generated form chars' collection.</returns>
        public static string GenerateString(this IList<char> source)
        {
            return new string(source.ToArray());
        }

        #endregion Public methods
    }
}
