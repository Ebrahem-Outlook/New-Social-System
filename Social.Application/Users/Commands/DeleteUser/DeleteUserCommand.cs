using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Users.Commands.DeleteUser;

public sealed record DeleteUserCommand(Guid UserId) : ICommand<string>;
