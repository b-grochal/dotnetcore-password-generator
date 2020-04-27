using Autofac;
using PasswordGenerator.Controllers;
using PasswordGenerator.Services;
using PasswordGenerator.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Configuration
{
    public static class ContainerConfiguration
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsoleView>().As<IView>();
            builder.RegisterType<ConsoleController>().As<IController>();
            builder.RegisterType<PasswordFactory>().As<IPasswordFactory>();
            builder.RegisterType<RandomNumberGenerator>().As<IRandomNumberGenerator>();

            return builder.Build();
        }
    }
}
