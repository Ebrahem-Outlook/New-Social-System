using Social.Domain.Core.Events;

namespace Social.Domain.Users.Events;

public sealed record UserPasswordUpdatedDomainEvent(User User) : DomainEvent();
