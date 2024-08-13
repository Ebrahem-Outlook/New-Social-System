using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders;

namespace Social.Application.Orders.Queries.GetAll;

public sealed record GetAllOrdersQuery() : IQuery<List<Order>>;
