using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetByName;

internal sealed class GetByNameQueryHandler : IQueryHandler<GetByNameQuery, List<User>>
{
    public Task<List<User>> Handle(GetByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
