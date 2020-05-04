using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Controllers
{
    /// <summary>
    /// Represents application's controller.
    /// </summary>
    public interface IController
    {
        #region Methods

        /// <summary>
        /// Runs the application.
        /// </summary>
        void Start();

        #endregion Methods
    }
}
