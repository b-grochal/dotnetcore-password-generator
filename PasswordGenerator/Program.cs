using Autofac;
using PasswordGenerator.Configuration;
using PasswordGenerator.Controllers;
using System;

namespace PasswordGenerator
{
    /// <summary>
    /// Application's main class.
    /// </summary>
    class Program
    {
        #region Private methods

        /// <summary>
        /// Application's main method.
        /// </summary>
        static void Main()
        {
            var container = ContainerConfiguration.Configure();

            using var scope = container.BeginLifetimeScope();
            var controller = scope.Resolve<IController>();
            controller.Start();
        }

        #endregion Private methods
    }
}
