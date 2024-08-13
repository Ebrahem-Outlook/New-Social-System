using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetByName;

public sealed record GetByNameQuery(string Name) : IQuery<List<User>>;
