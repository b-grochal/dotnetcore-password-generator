using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services
{
    /// <summary>
    /// Represents factory responsible for generating different passwords.
    /// </summary>
    public interface IPasswordFactory
    {
        #region Methods

        /// <summary>
        /// Generates password of passed type.
        /// </summary>
        /// <param name="passwordSettings">Password's type.</param>
        /// <returns>Generated password.</returns>
        string GeneratePassword(PasswordSettings passwordSettings);

        #endregion Methods
    }
}
