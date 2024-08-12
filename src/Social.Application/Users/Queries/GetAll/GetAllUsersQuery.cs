using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Users;

namespace Social.Application.Users.Queries.GetAll;

public sealed record GetAllUsersQuery() : IQuery<List<User>>;
