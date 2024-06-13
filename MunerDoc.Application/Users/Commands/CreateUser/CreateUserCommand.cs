using MunerDoc.Application.Core.Abstractions.Messaging;
using MunerDoc.Contracts.Authentication;
using MunerDoc.Domain.Core.Primitives.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MunerDoc.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : ICommand<Result<TokenResponse>>
    {
        public CreateUserCommand(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Gets the email.
        /// </summary>
        public string Email { get; }


        /// <summary>
        /// Gets the password.
        /// </summary>
        public string Password { get; }
    }
}
}
