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
            ShowLogo();
            Console.WriteLine("Password Generator Application.");
            Console.WriteLine("Version: 1.0");
        }

        public PasswordSettings GetPasswordDetailsFromUser()
        {
            PasswordSettings passwordDetails = new PasswordSettings();
            passwordDetails.PasswordLength = GetPasswordLength();
            passwordDetails.PasswordType = GetPasswordType();
            return passwordDetails;
        }

        public void ShowPassword(string password)
        {
            Console.WriteLine($"Generated password: {password}");
            Console.Read();
        }

        public void ShowHelp()
        {

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

        private void ShowLogo()
        {
            string[] logo = new string[]
            {
                "\n",
                @" _____                                    _    _____                           _             ",
                @"|  __ \                                  | |  / ____|                         | |            ",
                @"| |__) |_ _ ___ _____      _____  _ __ __| | | |  __  ___ _ __   ___ _ __ __ _| |_ ___  _ __ ",
                @"|  ___/ _` / __/ __\ \ /\ / / _ \| '__/ _` | | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|",
                @"| |  | (_| \__ \__ \\ V  V / (_) | | | (_| | | |__| |  __/ | | |  __/ | | (_| | || (_) | |   ",
                @"|_|   \__,_|___/___/ \_/\_/ \___/|_|  \__,_|  \_____|\___|_| |_|\___|_|  \__,_|\__\___/|_|   ",
                "\n"
            };

            foreach(string row in logo)
            {
                Console.WriteLine(row);
            }
        }
    }
}
