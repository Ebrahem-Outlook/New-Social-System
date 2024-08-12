using Social.Domain.Core.Events;

namespace Social.Domain.Core.BaseType;

public abstract class AggregateRoot : Entity, IAggregateRoot
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly IList<IDomainEvent> domainEvents = [];

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

    public void RaiseDomainEvent(IDomainEvent @event) => domainEvents.AsReadOnly();

    public void ClearDomainEvent() => domainEvents.Clear();
}

public interface IAggregateRoot
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void RaiseDomainEvent(IDomainEvent @event);
    void ClearDomainEvent();
}
