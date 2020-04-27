using PasswordGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator.Helpers
{
    public static class ListExtension
    {
        public static IList<char> Shuffle(this IList<char> source)
        {
            using RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            int n = source.Count;
            while (n > 1)
            {
                n--;
                int k = randomNumberGenerator.GenerateRandomNumber(0, n + 1);
                char c = source[k];
                source[k] = source[n];
                source[n] = c;
            }
            return source;
        }

        public static string GenerateString(this IList<char> source)
        {
            return new string(source.ToArray());
        }
    }   
}
