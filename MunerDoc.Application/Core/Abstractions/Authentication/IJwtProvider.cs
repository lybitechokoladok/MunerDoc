using MunerDoc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Application.Core.Abstractions.Authentication
{
    public interface IJwtProvider
    {
        string Create(User user);
    }
}
