using Social.Domain.Core.BaseType;
using Social.Domain.Products.Events;

namespace Social.Domain.Products;

public sealed class Product : AggregateRoot
{
    private Product(string UserName, string name, string description, decimal price, int stock)
        : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CreatedOnUtc = DateTime.UtcNow;
    }

    private Product() : base() { }

    public string UserName { get; } = default!;
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public DateTime CreatedOnUtc { get; }
    public DateTime? UpdatedOnUtc { get; private set; }

    public static Product Create(string UserName, string name, string description, decimal price, int stock)
    {
        Product product = new Product(UserName, name, description, price, stock);

        product.RaiseDomainEvent(new ProductCreatedDomainEvent(product));

        return product;
    }

    public void Update(string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        UpdatedOnUtc = DateTime.UtcNow;

        RaiseDomainEvent(new ProductUpdatedDomainEvent(this));
    }
}
