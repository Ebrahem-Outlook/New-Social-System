using Social.Domain.Core.Events;
using Social.Domain.Products;

namespace Social.Domain.Posts.Events;

public sealed record PostUpdatedDomainEvent(Post Post) : DomainEvent();
