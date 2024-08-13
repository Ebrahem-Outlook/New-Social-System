using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Posts;

namespace Social.Application.Posts.Queries.GetById;

public sealed record GetByIdQuery(Guid PostId) : IQuery<Post>;
