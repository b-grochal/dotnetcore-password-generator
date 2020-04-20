using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Models
{
    public class PasswordSettings
    {
        public int PasswordLength { get; set; }
        public PasswordType PasswordType { get; set; }
    }
}
