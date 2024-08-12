using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Users.Commands.UpdatePassword;

public sealed record UpdatePasswordCommand(Guid UserId, string Password) : ICommand<string>;
