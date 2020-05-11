using PasswordGenerator.Models;
using PasswordGenerator.Services;
using PasswordGenerator.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Controllers
{
    /// <summary>
    /// Represents application's controller.
    /// </summary>
    class ConsoleController : IController
    {
        #region Fields

        /// <summary>
        /// Application's user interface.
        /// </summary>
        private readonly IView view;

        /// <summary>
        /// Passwords' factory responsible for generating passwords.
        /// </summary>
        private readonly IPasswordFactory factory;

        #endregion Fields

        #region Ctors

        /// <summary>
        /// Initializes new instance of the <see cref="ConsoleController"/> class.
        /// </summary>
        /// <param name="view">Application's view.</param>
        /// <param name="passwordFactory">Passwords' factory.</param>
        public ConsoleController(IView view, IPasswordFactory passwordFactory)
        {
            this.view = view;
            this.factory = passwordFactory;
        }

        #endregion Ctors

        #region Public methods

        /// <summary>
        /// Runs the application.
        /// </summary>
        public void Start()
        {
            UserCommand? userCommand = null;
            while(userCommand != UserCommand.Exit)
            {
                userCommand = view.GetCommandFromUser();
                switch(userCommand)
                {
                    case UserCommand.Generate:
                        var passwordSettings = view.GetPasswordDetailsFromUser();
                        view.ShowPassword(factory.GeneratePassword(passwordSettings));
                        break;
                    case UserCommand.Help:
                        view.ShowHelp();
                        break;
                }
            }   
        }

        #endregion Public methods
    }
}
