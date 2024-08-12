using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Users.Commands.UpdateUser;

public sealed record UpdateUserCommand(Guid UserId, string FirstName, string LastName) : ICommand<string>;
