using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Contracts.Users
{
    public sealed class UserResponse
    {
        public Guid Id { get; set; }
        public string Username { get;  set; }
        public string Description { get;  set; }
        public string Settings { get;  set; }
        public string Email { get;  set; }
    }
}
