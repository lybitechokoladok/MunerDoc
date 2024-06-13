using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Contracts.Authentication
{
    public sealed class TokenResponse
    {
        public TokenResponse(string token) => Token = token;

        /// <summary>
        /// Gets the token.
        /// </summary>
        public string Token { get; }
    }
}
