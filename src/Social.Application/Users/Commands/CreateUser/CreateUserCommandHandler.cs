using Social.Application.Core.Abstractions.Authentication;
using Social.Application.Core.Abstractions.Cryptography;
using Social.Application.Core.Abstractions.Data;
using Social.Application.Core.Abstractions.Emails;
using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, string>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IEmailService _emailService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IEmailService emailService, IJwtProvider jwtProvider, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _emailService = emailService;
        _jwtProvider = jwtProvider;
        _unitOfWork = unitOfWork;
    }

    public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {

        bool isEmailUnique = !await _userRepository.IsEmailUnique(request.Email, cancellationToken);
        bool isUserNameUnique = !await _userRepository.IsUserNameUnique(request.UserName, cancellationToken);

        if (isEmailUnique || isUserNameUnique)
        {
            return string.Empty;
        }

        string PasswordHash = await _passwordHasher.HashPassword(request.Password);

        User user = User.Create(request.FirstName, request.LastName, request.UserName, request.Email, PasswordHash);

        await _userRepository.AddAsync(user, cancellationToken);

        string token = _jwtProvider.GenerateToken(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return token;
    }
}
