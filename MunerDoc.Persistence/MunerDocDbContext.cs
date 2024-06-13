using Microsoft.EntityFrameworkCore;
using MunerDoc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Persistence
{
    public sealed class MunerDocDbContext : DbContext
    {
        public MunerDocDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
