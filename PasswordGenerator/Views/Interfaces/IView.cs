using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    interface IView
    {
        void sayHello();
        PasswordSettings getPasswordDetailsFromUser();
        void printPassword(string password);
    }
}
