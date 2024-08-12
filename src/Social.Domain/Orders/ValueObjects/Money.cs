using Social.Domain.Core.BaseType;
using System.Text;

namespace Social.Domain.Orders.ValueObjects;

public sealed class Money : ValueObject
{
    public Money(decimal price)
    {
        Price = price;
    }

    public decimal Price { get; private set; }
}
