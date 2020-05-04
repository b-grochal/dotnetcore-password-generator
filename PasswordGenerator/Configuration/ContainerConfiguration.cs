using Autofac;
using PasswordGenerator.Controllers;
using PasswordGenerator.Services;
using PasswordGenerator.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Configuration
{
    /// <summary>
    /// Provides dependency injection container configuration. 
    /// </summary>
    public static class ContainerConfiguration
    {
        #region Public methods

        /// <summary>
        /// Configures dependency injection container.
        /// </summary>
        /// <returns>Dependency injection container.</returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleView>().As<IView>();
            builder.RegisterType<ConsoleController>().As<IController>();
            builder.RegisterType<PasswordFactory>().As<IPasswordFactory>();
            builder.RegisterType<RandomNumberGenerator>().As<IRandomNumberGenerator>();

            return builder.Build();
        }

        #endregion Public methods
    }
}
