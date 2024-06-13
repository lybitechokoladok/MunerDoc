using MunerDoc.Domain.Core.Primitives;
using MunerDoc.Domain.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Domain.Entites
{
    public sealed class User : Entity
    {
        private string _passwordHash;

        private User(string username, string email, string passwordHash)
            : base(Guid.NewGuid())
        {
            Ensure.NotEmpty(username, "The username is required", nameof(username));
            Ensure.NotEmpty(email, "The email is required", nameof(email));
            Ensure.NotEmpty(passwordHash, "The password hash is required", nameof(passwordHash));

            Username = username;
            Email = email;

            _passwordHash = passwordHash;
        }

        private User()
        {

        }
        public string Username { get; private set; }
        public string Description { get; private set; }
        public string Settings { get; private set; }
        public string Email { get; private set; }

        public static User Create(string username, string email, string passwordHash)
        {
            return new User(username, email, passwordHash);
        }
    }
}
