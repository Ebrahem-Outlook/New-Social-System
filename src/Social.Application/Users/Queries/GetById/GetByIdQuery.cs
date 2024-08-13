using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetById;

public sealed record GetByIdQuery(Guid UserId) : IQuery<User>;
