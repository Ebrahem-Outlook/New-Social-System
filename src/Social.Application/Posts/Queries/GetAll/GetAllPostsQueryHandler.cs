using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Posts;

namespace Social.Application.Posts.Queries.GetAll;

internal sealed class GetAllPostsQueryHandler : IQueryHandler<GetAllPostsQuery, List<Post>>
{
    public Task<List<Post>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
