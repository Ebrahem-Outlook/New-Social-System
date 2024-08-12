using Microsoft.EntityFrameworkCore;
using Social.Application.Core.Abstractions.Data;
using Social.Domain.Products;

namespace Social.Infrastructure.Repositories;

internal sealed class ProductRepository(IDbContext dbContext) : IProductRepository
{
    public async Task AddAsync(Product product, CancellationToken cancellationToken)
    {
        await dbContext.Set<Product>().AddAsync(product, cancellationToken);
    }

    public Task UpdateAsync(Product product, CancellationToken cancellationToken)
    {
        dbContext.Set<Product>().Update(product);

        return Task.CompletedTask;
    }

    public Task DeleteAsync(Product product, CancellationToken cancellationToken)
    {
        dbContext.Set<Product>().Remove(product);

        return Task.CompletedTask;
    }

    public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>()
                              .AsNoTracking()
                              .ToListAsync(cancellationToken);
    }

    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>()
                              .AsNoTracking()
                              .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public async Task<List<Product>> GetByNameAsync(string name, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>()    
                              .AsNoTracking()
                              .Where(user => user.Name == name)
                              .ToListAsync(cancellationToken);

    }
}
