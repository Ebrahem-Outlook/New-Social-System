using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetByEmail;

public sealed record GetByEmailQuery(string Email) : IQuery<User>;
