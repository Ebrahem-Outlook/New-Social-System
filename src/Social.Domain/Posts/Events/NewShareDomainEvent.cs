using Social.Domain.Core.Events;
using Social.Domain.Posts.Entities;

namespace Social.Domain.Posts.Events;

public sealed record NewShareDomainEvent(Share Share) : DomainEvent();
