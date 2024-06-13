using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Application.Core.Abstractions.Cryptography
{
    public interface IPasswordHasher
    {
        string Hash(string password);
    }
}
