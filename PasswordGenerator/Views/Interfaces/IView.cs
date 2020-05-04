using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    /// <summary>
    /// Represents user interface.
    /// </summary>
    interface IView
    {
        #region Methods

        /// <summary>
        /// Gets command from user.
        /// </summary>
        /// <returns>User's command.</returns>
        UserCommand GetCommandFromUser();

        /// <summary>
        /// Gets password's details from user.
        /// </summary>
        /// <returns>Password's details.</returns>
        PasswordSettings GetPasswordDetailsFromUser();

        /// <summary>
        /// Displays password.
        /// </summary>
        /// <param name="password">Password to display.</param>
        void ShowPassword(string password);

        /// <summary>
        /// Shows help for user.
        /// </summary>
        void ShowHelp();

        #endregion Methods
    }
}
