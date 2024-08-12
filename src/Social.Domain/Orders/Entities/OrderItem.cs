using Social.Domain.Core.BaseType;

namespace Social.Domain.Orders.Entities;

public sealed class OrderItem : Entity
{
    public string Name { get; } = default!;
    public decimal Price { get; private set; }
}
