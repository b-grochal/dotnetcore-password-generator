using PasswordGenerator.Enums;
using PasswordGenerator.Models;
using PasswordGenerator.Services;
using PasswordGenerator.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Controllers
{
    class ConsoleController : IController
    {
        private IView view;
        private IPasswordFactory factory;

        public ConsoleController(IView view, IPasswordFactory passwordFactory)
        {
            this.view = view;
            this.factory = passwordFactory;
        }

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
    }
}
