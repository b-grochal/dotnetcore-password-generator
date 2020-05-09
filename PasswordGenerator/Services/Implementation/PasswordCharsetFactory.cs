using PasswordGenerator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services.Implementation
{
    /// <summary>
    /// Represents factory responsible for creating passwords' charsets.
    /// </summary>
    public class PasswordCharsetFactory : IPasswordCharsetFactory
    {
        #region Public methods

        /// <summary>
        /// Creates charset for simple password.
        /// </summary>
        /// <returns>Simple password's charset.</returns>
        public string[] GetSimplePasswordCharset()
        {
            return new string[]
            {
                "abcdefghijklmnopqrstuvwxyz",
                "1234567890"
            };
        }

        /// <summary>
        /// Creates charset for medium password.
        /// </summary>
        /// <returns>Medium password's charset.</returns>
        public string[] GetMediumPasswordCharset()
        {
            return new string[]
            {
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "1234567890"
            };
        }

        /// <summary>
        /// Creates charset for strong password.
        /// </summary>
        /// <returns>Strong password's charset.</returns>
        public string[] GetStrongPasswordCharset()
        {
            return new string[]
            {
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "1234567890",
                "?!@#$%^&*",
            };
        }

        #endregion Public methods
    }
}
