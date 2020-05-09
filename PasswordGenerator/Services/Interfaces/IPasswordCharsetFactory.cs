using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services.Interfaces
{
    /// <summary>
    /// Represents factory responsible for creating passwords' charsets.
    /// </summary>
    public interface IPasswordCharsetFactory
    {
        #region Methods

        /// <summary>
        /// Creates charset for simple password.
        /// </summary>
        /// <returns>Simple password's charset.</returns>
        string[] GetSimplePasswordCharset();

        /// <summary>
        /// Creates charset for medium password.
        /// </summary>
        /// <returns>Medium password's charset.</returns>
        string[] GetMediumPasswordCharset();

        /// <summary>
        /// Creates charset for strong password.
        /// </summary>
        /// <returns>Strong password's charset.</returns>
        string[] GetStrongPasswordCharset();

        #endregion Methods
    }
}
