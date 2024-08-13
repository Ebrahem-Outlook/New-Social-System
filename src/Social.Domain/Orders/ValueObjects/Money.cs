using Social.Domain.Core.BaseType;

namespace Social.Domain.Orders.ValueObjects;

public sealed class Money : ValueObject
{
    private Money(decimal price)
    {
        Price = price;
    }

    public decimal Price { get; private set; }

    public static Money Create(decimal price)
    {
        return new Money(price);
    }
}
