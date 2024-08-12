using Social.Domain.Core.Events;

namespace Social.Domain.Users.Events;

public sealed record UserEmailUpdatedDomainEvent(User User) : DomainEvent();
