using PasswordGenerator.Models;
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

        public PasswordDetails getPasswordDetailsFromUser()
        {
            //int passwordLength;
            //PasswordType passwordType;
            //Console.Write("Enter password's length: ");

            //while (!int.TryParse(Console.ReadLine(), out passwordLength) || passwordLength < 0)
            //{
            //    Console.WriteLine("Invalid password's length!");
            //    Console.Write("Enter password's length: ");
            //}

            //Console.Write("Enter password's type (simple, medium or strong): ");

            //while(!Enum.TryParse(Console.ReadLine(), true, out passwordType) || !Enum.IsDefined(typeof(PasswordType), passwordType))
            //{
            //    Console.WriteLine("Invalid password's type!");
            //    Console.Write("Enter password's type: ");
            //}


            //return null;
            PasswordDetails passwordDetails = new PasswordDetails();
            passwordDetails.PasswordLength = getPasswordLength();
            passwordDetails.passwordType = getPasswordType();
            return passwordDetails;
        }

        public void printPassword(string password)
        {
            Console.WriteLine($"Generated password: {password}");
            Console.Read();
        }

        private int getPasswordLength()
        {
            int passwordLength;
            Console.Write("Enter password's length: ");
            while (!int.TryParse(Console.ReadLine(), out passwordLength) || passwordLength < 0)
            {
                Console.WriteLine("Invalid password's length!");
                Console.Write("Enter password's length: ");
            }
            return passwordLength;
        }

        private PasswordType getPasswordType()
        {
            PasswordType passwordType;
            Console.Write("Enter password's type (simple, medium or strong): ");
            while (!Enum.TryParse(Console.ReadLine(), true, out passwordType) || !Enum.IsDefined(typeof(PasswordType), passwordType))
            {
                Console.WriteLine("Invalid password's type!");
                Console.Write("Enter password's type: ");
            }
            return passwordType;
        }
    }
}
