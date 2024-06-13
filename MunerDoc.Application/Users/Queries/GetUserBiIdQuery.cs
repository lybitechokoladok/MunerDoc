using MunerDoc.Application.Core.Abstractions.Messaging;
using MunerDoc.Contracts.Users;
using MunerDoc.Domain.Core.Primitives.Maybe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Application.Users.Queries
{
    public class GetUserBiIdQuery : IQuery<Maybe<UserResponse>>
    {

        public GetUserBiIdQuery(Guid id) => Id = id;
        public Guid Id { get; set; }
    }
}
