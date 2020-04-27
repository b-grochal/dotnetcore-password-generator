using Autofac;
using PasswordGenerator.Configuration;
using PasswordGenerator.Controllers;
using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfiguration.Configure();

            using(var scope = container.BeginLifetimeScope())
            {
                var controller = scope.Resolve<IController>();
                controller.Start();
            }
        }
    }
}
