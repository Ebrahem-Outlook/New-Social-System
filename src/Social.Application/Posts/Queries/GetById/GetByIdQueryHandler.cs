using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Posts;

namespace Social.Application.Posts.Queries.GetById;

internal sealed class GetByIdQueryHandler : IQueryHandler<GetByIdQuery, Post>
{
    public Task<Post> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
