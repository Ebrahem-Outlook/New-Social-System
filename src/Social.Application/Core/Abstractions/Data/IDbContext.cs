using Microsoft.EntityFrameworkCore;
using Social.Domain.Core.BaseType;

namespace Social.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
