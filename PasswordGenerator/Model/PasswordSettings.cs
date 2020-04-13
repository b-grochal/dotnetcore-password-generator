using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Models
{
    class PasswordSettings
    {
        public int PasswordLength { get; set; }
        public PasswordType PasswordType { get; set; }
    }
}
