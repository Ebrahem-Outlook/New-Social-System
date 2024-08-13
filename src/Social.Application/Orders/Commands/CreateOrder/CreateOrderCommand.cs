using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders.Entities;

namespace Social.Application.Orders.Commands.CreateOrder;

public sealed record CreateOrderCommand(List<OrderItem> OrderItems) : ICommand<string>;
