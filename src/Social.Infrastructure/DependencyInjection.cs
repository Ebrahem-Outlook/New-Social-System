using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Social.Infrastructure.Database;

namespace Social.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            string ConnectionString = configuration.GetConnectionString("Local-SqlServer") ?? throw new InvalidOperationException("ConnectionString Does't exsit....");

            options.UseSqlServer(ConnectionString);
        });


        return services;
    }
}
