using Microsoft.AspNetCore.Http;
using MunerDoc.Application.Core.Abstractions.Authentication;
using System.Security.Claims;

namespace MunerDoc.Infrastructure.Authentication
{
    internal sealed class UserIdentifierProvider : IUserIdentifierProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentifierProvider"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public UserIdentifierProvider(IHttpContextAccessor httpContextAccessor)
        {
            string userIdClaim = httpContextAccessor.HttpContext?.User?.FindFirst("id").Value
                ?? throw new ArgumentException("The user identifier claim is required.", nameof(httpContextAccessor));

            UserId = new Guid(userIdClaim);
        }

        /// <inheritdoc />
        public Guid UserId { get; }
    }
}
