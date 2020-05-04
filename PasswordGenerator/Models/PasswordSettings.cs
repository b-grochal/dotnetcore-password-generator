using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Models
{
    /// <summary>
    /// Represents password details used during password generation process.
    /// </summary>
    public class PasswordSettings
    {
        #region Properties

        /// <summary>
        /// Gets or sets the password's length.
        /// </summary>
        public int PasswordLength { get; set; }

        /// <summary>
        /// Gets or sets password's type.
        /// </summary>
        public PasswordType PasswordType { get; set; }

        #endregion Properties
    }
}
