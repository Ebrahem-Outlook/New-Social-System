using Social.Domain.Core.BaseType;
using Social.Domain.Orders.Entities;
using Social.Domain.Orders.Events;
using Social.Domain.Orders.ValueObjects;

namespace Social.Domain.Orders;

public sealed class Order : AggregateRoot
{
    private Order(Guid userId, List<OrderItem> orderItems, Func<List<OrderItem>, decimal> func)
        : base(Guid.NewGuid())
    {
        UserId = userId;
        OrderItems = orderItems;
         
        CreatedOnUtc = DateTime.UtcNow;
    }

    private Order() : base(Guid.NewGuid()) { }

    public Guid UserId { get; }
    public Money TotalPrice { get; private set; } = default!;
    public List<OrderItem> OrderItems { get; private set; } = [];
    public DateTime CreatedOnUtc { get; }

    public static Order Create(Guid userId, List<OrderItem> orderItems)
    {
        Order order = new Order(userId, orderItems, items => items.Sum(order => order.Price));

        order.RaiseDomainEvent(new OrderCreatedDomainEvent(order));

        return order;
    }
}
