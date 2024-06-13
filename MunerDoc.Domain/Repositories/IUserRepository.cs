using MunerDoc.Domain.Core.Primitives.Maybe;
using MunerDoc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<Maybe<User>> GetUserByEmailAsync(string email);
        Task<Maybe<User>> GetUserByIdAsync(Guid id);

        Task<bool> IsEmailUniqueAsync(string email);

        void Insert(User user);
    }
}
