using PasswordGenerator.Controllers;
using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            IController controller = new ConsoleController();
            controller.start();
        }
    }
}
