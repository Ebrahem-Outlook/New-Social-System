using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders;

namespace Social.Application.Orders.Queries.GetByUserId;

public sealed record GetByUserIdQuery(Guid UserId) : IQuery<List<Order>>;
