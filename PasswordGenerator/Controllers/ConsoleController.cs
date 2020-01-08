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
        private IFactory factory;

        public ConsoleController()
        {
            this.view = new ConsoleView();
            this.factory = new PasswordFactory();
        }

        public void start()
        {
            PasswordDetails passwordDetails;
            string password;
            view.sayHello();
            passwordDetails =  view.getPasswordDetailsFromUser();
            switch(passwordDetails.passwordType)
            {
                case PasswordType.SimplePassword:
                    password = factory.generateSimplePassword(passwordDetails.PasswordLength);
                    break;
                case PasswordType.MediumPassword:
                    password = factory.generateMediumPassword(passwordDetails.PasswordLength);
                    break;
                case PasswordType.StrongPassword:
                    password = factory.generateStrongPassword(passwordDetails.PasswordLength);
                    break;
                default:
                    password = factory.generateSimplePassword(passwordDetails.PasswordLength);
                    break;
            }
            view.printPassword(password);

        }
    }
}
