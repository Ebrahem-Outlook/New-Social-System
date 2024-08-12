using Microsoft.EntityFrameworkCore;
using Social.Application.Core.Abstractions.Data;
using Social.Domain.Users;

namespace Social.Infrastructure.Repositories;

internal sealed class UserRepository(IDbContext dbContext) : IUserRepository
{
    public async Task AddAsync(User user, CancellationToken cancellationToken)
    {
        await dbContext.Set<User>().AddAsync(user, cancellationToken);
    }

    public Task Update(User user, CancellationToken cancellationToken)
    {
        dbContext.Set<User>().Update(user);

        return Task.CompletedTask;
    }

    public Task Delete(User user, CancellationToken cancellationToken)
    {
        dbContext.Set<User>().Remove(user);

        return Task.CompletedTask;
    }

    public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().ToListAsync(cancellationToken);
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().SingleOrDefaultAsync(user => user.Email == email, cancellationToken);
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public async Task<bool> IsEmailUnique(string email, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().AnyAsync(user => user.Email == email, cancellationToken);
    }

    public async Task<bool> IsUserNameUnique(string userName, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().AnyAsync(user => user.UserName == userName, cancellationToken);
    }
}
