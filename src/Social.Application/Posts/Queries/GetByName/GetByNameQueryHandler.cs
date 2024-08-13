using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Posts;

namespace Social.Application.Posts.Queries.GetByName;

internal sealed class GetByNameQueryHandler : IQueryHandler<GetByNameQuery, List<Post>>
{
    public Task<List<Post>> Handle(GetByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
