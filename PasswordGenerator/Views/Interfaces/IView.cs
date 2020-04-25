using PasswordGenerator.Enums;
using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    interface IView
    {
        UserCommand GetCommandFromUser();
        PasswordSettings GetPasswordDetailsFromUser();
        void ShowPassword(string password);
        void ShowHelp();
    }
}
