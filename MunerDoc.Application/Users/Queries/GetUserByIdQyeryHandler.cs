using Microsoft.EntityFrameworkCore;
using MunerDoc.Application.Core.Abstractions.Messaging;
using MunerDoc.Contracts.Users;
using MunerDoc.Domain.Core.Primitives.Maybe;
using MunerDoc.Domain.Entites;
using MunerDoc.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Application.Users.Queries
{
    public class GetUserByIdQyeryHandler : IQueryHandler<GetUserBiIdQuery, Maybe<UserResponse>>
    {
        private readonly MunerDocDbContext _dbContext;

        public GetUserByIdQyeryHandler(MunerDocDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Maybe<UserResponse>> Handle(GetUserBiIdQuery request, CancellationToken cancellationToken)
        {
            UserResponse response = await _dbContext.Set<User>()
               .Where(x => x.Id == request.Id)
               .Select(user => new UserResponse
               {
                   Id = user.Id,
                   Email = user.Email,
                   Description = user.Description,
                   Settings = user.Settings,
               })
               .SingleOrDefaultAsync(cancellationToken);

            if (response is null)
            {
                return Maybe<UserResponse>.None;
            }


            return response;
        }
    }
}
