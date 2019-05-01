using System;
using System.Collections.Generic;
using System.Text;

namespace Vira.Core.Domain
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
