using Microsoft.EntityFrameworkCore;
using MunerDoc.Domain.Core.Primitives.Maybe;
using MunerDoc.Domain.Entites;
using MunerDoc.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Persistence.Repositories
{
    internal sealed class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly MunerDocDbContext _dbContext;
        public UserRepository(MunerDocDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Maybe<User>> GetUserByEmailAsync(string email) => await _dbContext.Users.FirstOrDefaultAsync(x=> x.Email == email);
        

        public async Task<Maybe<User>> GetUserByIdAsync(Guid id) => await _dbContext.Users.FirstOrDefaultAsync(x=> x.Id == id);

        public async Task<bool> IsEmailUniqueAsync(string email) => !await _dbContext.Users.AnyAsync(x=> x.Email == email);
    }
}
