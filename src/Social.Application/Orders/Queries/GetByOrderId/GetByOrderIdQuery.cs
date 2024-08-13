using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders;

namespace Social.Application.Orders.Queries.GetByOrderId;

public sealed record GetByOrderIdQuery(Guid OrderId) : IQuery<Order>;
