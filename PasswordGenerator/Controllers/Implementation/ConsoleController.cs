﻿using PasswordGenerator.Models;
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

        public void Start()
        {
            view.SayHello();
            var passwordSettings =  view.GetPasswordDetailsFromUser();
            view.PrintPassword(factory.GeneratePassword(passwordSettings));
        }
    }
}
