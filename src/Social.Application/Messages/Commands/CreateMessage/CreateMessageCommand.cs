using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Messages.Commands.CreateMessage;

public sealed record CreateMessageCommand(
    Guid UserSendId, 
    Guid UserReceiveId , 
    string MessageBody) : ICommand<string>;
