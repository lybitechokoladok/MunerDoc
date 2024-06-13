﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Application.Core.Abstractions.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
