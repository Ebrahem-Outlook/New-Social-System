using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Messages.Commands.DeleteMessage;

public sealed record DeleteMessageCommand(Guid UserId, Guid MessageId) : ICommand<string>;
