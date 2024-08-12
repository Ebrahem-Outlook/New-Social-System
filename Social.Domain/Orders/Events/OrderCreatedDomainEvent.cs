using Social.Domain.Core.Events;

namespace Social.Domain.Orders.Events;

public sealed record OrderCreatedDomainEvent(Order Order) : DomainEvent();
