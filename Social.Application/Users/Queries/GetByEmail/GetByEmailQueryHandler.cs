using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetByEmail;

internal sealed class GetByEmailQueryHandler : IQueryHandler<GetByEmailQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetByEmailQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetByEmailQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetByEmailAsync(request.Email, cancellationToken);
    }
}
