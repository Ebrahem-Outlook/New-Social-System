using Social.Domain.Core.BaseType;
using Social.Domain.Messages.Events;

namespace Social.Domain.Messages;

public sealed class Message : AggregateRoot
{
    private Message(Guid userSendId, Guid userReceiveId, string messageBody)
        : base(Guid.NewGuid())
    {
        UserSendId = userSendId;
        UserReceiveId = userReceiveId;
        MessageBody = messageBody;
        SendOnUtc = DateTime.UtcNow;
    }

    private Message() : base() { }

    public Guid UserSendId { get; }
    public Guid UserReceiveId { get; }
    public string MessageBody { get; } = default!;
    public DateTime SendOnUtc { get; }

    public static Message Create(Guid userSendId, Guid userReceiveId, string messageBody)
    {
        Message message = new Message(userSendId, userReceiveId, messageBody);

        message.RaiseDomainEvent(new MessageSendedDomainEvent(message));

        return message;
    }
}
