using MediatR;

namespace Social.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid EventId { get; }
    DateTime OccuredOn { get; }
}
