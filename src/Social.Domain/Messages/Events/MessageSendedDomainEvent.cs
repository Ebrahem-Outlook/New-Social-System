using Social.Domain.Core.Events;

namespace Social.Domain.Messages.Events;

public sealed record MessageSendedDomainEvent(Message Message) : DomainEvent();
