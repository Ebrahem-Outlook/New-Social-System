/*using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using Social.Domain.Users;
using Social.Infrastructure.Repositories;

namespace Social.Infrastructure.Caching;

internal sealed class CachedUserRepository(UserRepository decorated, IDistributedCache cache) : IUserRepository
{
    private const string UserByIdCacheKey = "UserById-";
    private const string UserByEmailCacheKey = "UserByEmail-";
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

    public async Task AddAsync(User user, CancellationToken cancellationToken)
    {
        await decorated.AddAsync(user, cancellationToken);
        string key = $"{UserByIdCacheKey}{user.Id}";
        await cache.RemoveAsync(key, cancellationToken);
    }

    public async Task Update(User user, CancellationToken cancellationToken)
    {
        await decorated.Update(user, cancellationToken);
        string key = $"{UserByIdCacheKey}{user.Id}";
        await cache.RemoveAsync(key, cancellationToken);
    }

    public async Task Delete(User user, CancellationToken cancellationToken)
    {
        await decorated.Delete(user, cancellationToken);
        string key = $"{UserByIdCacheKey}{user.Id}";
        await cache.RemoveAsync(key, cancellationToken);
    }

    public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken)
    {
        // Implement caching here if needed, depending on use case
        return await decorated.GetAllAsync(cancellationToken);
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken)
    {
        string key = $"{UserByEmailCacheKey}{email}";
        User? user = await GetFromCacheAsync(key, cancellationToken);
        if (user is null)
        {
            user = await decorated.GetByEmailAsync(email, cancellationToken);
            if (user is not null)
            {
                await SetCacheAsync(key, user, cancellationToken);
            }
        }

        return user;
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        string key = $"{UserByIdCacheKey}{id}";
        User? user = await GetFromCacheAsync(key, cancellationToken);
        if (user is null)
        {
            user = await decorated.GetByIdAsync(id, cancellationToken);
            if (user is not null)
            {
                await SetCacheAsync(key, user, cancellationToken);
            }
        }

        return user;
    }

    public async Task<bool> IsEmailUnique(string email, CancellationToken cancellationToken)
    {
        return await decorated.IsEmailUnique(email, cancellationToken);
    }

    public async Task<bool> IsUserNameUnique(string userName, CancellationToken cancellationToken)
    {
        return await decorated.IsUserNameUnique(userName, cancellationToken);
    }

    private async Task<User?> GetFromCacheAsync(string key, CancellationToken cancellationToken)
    {
        string? cachedData = await cache.GetStringAsync(key, cancellationToken);
        if (cachedData is not null)
        {
            try
            {
                return JsonSerializer.Deserialize<User>(cachedData, JsonOptions);
            }
            catch (JsonException)
            {
                // Handle deserialization failure (e.g., corrupted cache)
                await cache.RemoveAsync(key, cancellationToken);
            }
        }

        return null;
    }

    private async Task SetCacheAsync(string key, User user, CancellationToken cancellationToken)
    {
        var cacheOptions = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30) // Set to a reasonable expiration
        };
        string serializedData = JsonSerializer.Serialize(user, JsonOptions);
        await cache.SetStringAsync(key, serializedData, cacheOptions, cancellationToken);
    }
}
*/