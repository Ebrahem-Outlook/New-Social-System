using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetByUserName;

internal sealed class GetByUserNameQueryHandler : IQueryHandler<GetByUserNameQuery, User>
{
    public Task<User> Handle(GetByUserNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
