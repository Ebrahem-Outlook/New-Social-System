using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetAll;

internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository _userRepository;

    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAllAsync(cancellationToken);
    }
}
