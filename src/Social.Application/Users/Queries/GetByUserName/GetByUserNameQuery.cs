using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetByUserName;

public sealed record GetByUserNameQuery(string UserName) : IQuery<User>;
