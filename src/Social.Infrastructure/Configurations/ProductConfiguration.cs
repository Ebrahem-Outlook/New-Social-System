using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Social.Domain.Products;

namespace Social.Infrastructure.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Configuration Table Name.
        builder.ToTable("Products", "Product_Schema_1");

        // Configuration Key.
        builder.HasKey(product => product.Id);

        // Configuration Name.
        builder.Property(product => product.Name)
            .HasColumnName(nameof(Product.Name))
            .HasMaxLength(50)
            .IsRequired();

        // Configuration Description.
        builder.Property(product => product.Description)
            .HasColumnName(nameof(Product.Description))
            .HasMaxLength(500)
            .IsRequired();

        // Configuration Name.
        builder.Property(product => product.Price)
            .HasColumnName(nameof(Product.Name))
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        // Configuration Stock.
        builder.Property(product => product.Stock)
            .HasColumnName(nameof(Product.Stock))
            .IsRequired();

        // Configuration CreatedOnUtc.
        builder.Property(product => product.CreatedOnUtc)
            .HasColumnName(nameof(Product.CreatedOnUtc))
            .IsRequired();

        // Configuration UpdatedOrUtc.
        builder.Property(product => product.UpdatedOnUtc)
            .HasColumnName(nameof(Product.UpdatedOnUtc))
            .IsRequired(false);

        // Configuration DomainEvents.
        builder.Ignore(product => product.DomainEvents);
    }
}
