using Social.Domain.Core.Events;

namespace Social.Domain.Products.Events;

public sealed record ProductDeletedDomainEvent(Product Product) : DomainEvent();
