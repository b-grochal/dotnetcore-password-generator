using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Models
{
    class PasswordDetails
    {
        public int PasswordLength { get; set; }
        public PasswordType passwordType { get; set; }
    }
}
