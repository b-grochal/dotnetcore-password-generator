using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    class ConsoleView : IView
    {
        public void SayHello()
        {
            Console.WriteLine("Password Generator Application.");
            Console.WriteLine("Version: 1.0");
        }

        public PasswordSettings GetPasswordDetailsFromUser()
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
            PasswordSettings passwordDetails = new PasswordSettings();
            passwordDetails.PasswordLength = GetPasswordLength();
            passwordDetails.PasswordType = GetPasswordType();
            return passwordDetails;
        }

        public void PrintPassword(string password)
        {
            Console.WriteLine($"Generated password: {password}");
            Console.Read();
        }

        private int GetPasswordLength()
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

        private PasswordType GetPasswordType()
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
