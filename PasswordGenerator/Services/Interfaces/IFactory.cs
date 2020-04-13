using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Services
{
    interface IFactory
    {
        string generateSimplePassword(int passwordLength);
        string generateMediumPassword(int passwordLength);
        string generateStrongPassword(int passwordLength);
    }
}
