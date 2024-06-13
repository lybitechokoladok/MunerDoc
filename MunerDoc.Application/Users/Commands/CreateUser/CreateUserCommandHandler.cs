using MunerDoc.Application.Core.Abstractions.Authentication;
using MunerDoc.Application.Core.Abstractions.Cryptography;
using MunerDoc.Application.Core.Abstractions.Data;
using MunerDoc.Application.Core.Abstractions.Messaging;
using MunerDoc.Contracts.Authentication;
using MunerDoc.Domain.Core.Primitives;
using MunerDoc.Domain.Core.Primitives.Result;
using MunerDoc.Domain.Entites;
using MunerDoc.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunerDoc.Application.Users.Commands.CreateUser
{
    public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Result<TokenResponse>>
    {

        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private IUnitOfWork _unitOfWork;
        private readonly IJwtProvider _jwtProvider;

        public CreateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IJwtProvider jwtProvider, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _jwtProvider = jwtProvider;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<TokenResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {


            if (!await _userRepository.IsEmailUniqueAsync(request.Email))
            {
                return Result.Failure<TokenResponse>(new Error("Email.Duplicate", "The email was duplicated"));
            }

            string passwordHash = _passwordHasher.Hash(request.Password);

            var user = User.Create(request.Username, request.Email, passwordHash);

            _userRepository.Insert(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            string token = _jwtProvider.Create(user);

            return Result.Success(new TokenResponse(token));
        }
    }
}
