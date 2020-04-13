using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    interface IView
    {
        void SayHello();
        PasswordSettings GetPasswordDetailsFromUser();
        void PrintPassword(string password);
    }
}
