using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Posts;

namespace Social.Application.Posts.Queries.GetByName;

public sealed record GetByNameQuery(string Name) : IQuery<List<Post>>;
