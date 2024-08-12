using Social.Application.Core.Abstractions.Authentication;
using Social.Application.Core.Abstractions.Cryptography;
using Social.Application.Core.Abstractions.Data;
using Social.Application.Core.Abstractions.Emails;
using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Commands.UpdatePassword;

internal sealed class UpdatePasswordCommandHandler : ICommandHandler<UpdatePasswordCommand, string>
{
    private readonly IUserIdentifierProvider _userIdentifierProvider;
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUnitOfWork _unitOfWork;

    public UpdatePasswordCommandHandler(IUserIdentifierProvider userIdentifierProvider, IUserRepository userRepository, IEmailService emailService, IJwtProvider jwtProvider, IPasswordHasher passwordHasher, IUnitOfWork unitOfWork)
    {
        _userIdentifierProvider = userIdentifierProvider;
        _userRepository = userRepository;
        _emailService = emailService;
        _jwtProvider = jwtProvider;
        _passwordHasher = passwordHasher;
        _unitOfWork = unitOfWork;
    }

    public async Task<string> Handle(UpdatePasswordCommand request, CancellationToken cancellationToken)
    {
        if (_userIdentifierProvider.UserId != request.UserId)
        {
            return string.Empty;
        }

        User? user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return string.Empty;
        }

        string passwordHash = await _passwordHasher.HashPassword(request.Password);

        if(user.PasswordHash == passwordHash)
        {
            return string.Empty;
        }

        user.UpdatePassword(passwordHash);

        await _userRepository.Update(user, cancellationToken);

        _emailService.SendEmailAsync("noreplay@gmail.com", "anyone@gmail.com", "Hello World..");

        string token = _jwtProvider.GenerateToken(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return token;
    }
}
