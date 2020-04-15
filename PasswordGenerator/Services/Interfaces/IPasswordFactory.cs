using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services
{
    interface IPasswordFactory
    {
        string GeneratePassword(PasswordSettings passwordSettings);
    }
}
