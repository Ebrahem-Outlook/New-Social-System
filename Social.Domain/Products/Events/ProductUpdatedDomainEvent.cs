using Social.Domain.Core.Events;

namespace Social.Domain.Products.Events;

public sealed record ProductUpdatedDomainEvent(Product Product) : DomainEvent();
