using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Views
{
    /// <summary>
    /// Represents console user interface.
    /// </summary>
    class ConsoleView : IView
    {
        #region Public methods

        /// <summary>
        /// Gets command from user.
        /// </summary>
        /// <returns>User's command.</returns>
        public UserCommand GetCommandFromUser()
        {
            Console.Clear();
            FlushConsoleKeyBuffer();
            ShowLogo();
            Console.WriteLine("Type one of commands listed below:");
            Console.WriteLine("- generate to generate new password");
            Console.WriteLine("- help to display application's description");
            Console.WriteLine("- exit to close application");
            Console.Write("Command: ");

            UserCommand userCommand;

            while (!Enum.TryParse(Console.ReadLine(), true, out userCommand) || !Enum.IsDefined(typeof(UserCommand), userCommand))
            {
                Console.WriteLine("Invalid command! Type command once again.");
                Console.Write("Command: ");
            }
            return userCommand;
        }

        /// <summary>
        /// Gets password's details from user.
        /// </summary>
        /// <returns>Password's details.</returns>
        public PasswordSettings GetPasswordDetailsFromUser()
        {
            Console.Clear();
            PasswordSettings passwordDetails = new PasswordSettings
            {
                PasswordLength = GetPasswordLength(),
                PasswordType = GetPasswordType()
            };
            return passwordDetails;
        }

        /// <summary>
        /// Displays password.
        /// </summary>
        /// <param name="password">Password to display.</param>
        public void ShowPassword(string password)
        {
            Console.Clear();
            Console.WriteLine($"Generated password: {password}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// Shows help for user.
        /// </summary>
        public void ShowHelp()
        {
            Console.Clear();
            Console.WriteLine("Password Generator version 1.0\n");
            Console.WriteLine("Application lets generate password based on type chosen by user.");
            Console.WriteLine("Available password types:");
            Console.WriteLine("- simple -> consists of letters (only lowercase)");
            Console.WriteLine("- medium -> consists of letters (lowercase and uppercase) and numbers");
            Console.WriteLine("- strong -> consists of letters (lowercase and uppercase), numbers and special characters");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        #endregion Public methods

        #region Private methods

        /// <summary>
        /// Gets password's length from user.
        /// </summary>
        /// <returns>Password's length.</returns>
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

        /// <summary>
        /// Gets password's type from user.
        /// </summary>
        /// <returns>Password's type.</returns>
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

        /// <summary>
        /// Displays application logo in cosole.
        /// </summary>
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

        /// <summary>
        /// Flushes console key buffer.
        /// </summary>
        private void FlushConsoleKeyBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }

        #endregion Private methods
    }
}
