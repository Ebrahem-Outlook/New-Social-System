using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Users.Commands.UpdateEmail;

public sealed record UpdateEmailCommand(Guid UserId, string Email) : ICommand<string>;
