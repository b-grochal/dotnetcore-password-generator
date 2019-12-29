using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    class ConsoleView : IView
    {
        public void sayHello()
        {
            Console.WriteLine("Password Generator Application.");
            Console.WriteLine("Version: 1.0");
        }
    }
}
