using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Domain.Services
{
    public interface IPasswordHasherChecker
    {
        bool HashesMatch(string passwordHash, string providedPassword);
    }
}
