using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Posts;

namespace Social.Application.Posts.Queries.GetAll;

public sealed record GetAllPostsQuery() : IQuery<List<Post>>;
