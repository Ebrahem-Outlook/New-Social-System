using Social.Application.Core.Abstractions.Authentication;
using Social.Application.Core.Abstractions.Data;
using Social.Application.Core.Abstractions.Emails;
using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Commands.DeleteUser;

internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand, string>
{
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteUserCommandHandler(IUserRepository userRepository, IEmailService emailService, IJwtProvider jwtProvider, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _emailService = emailService;
        _jwtProvider = jwtProvider;
        _unitOfWork = unitOfWork;
    }

    public async Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return string.Empty;
        }

        await _userRepository.Delete(user, cancellationToken);

        _emailService.SendEmailAsync("noreplay@gmail.com", "anyone@gmail.com", "Hello World..");

        string token = _jwtProvider.GenerateToken(user);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return token;
    }
}
