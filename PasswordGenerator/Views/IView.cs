using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    interface IView
    {
        void sayHello();
        PasswordDetails getPasswordDetailsFromUser();
        void printPassword(string password);
    }
}
