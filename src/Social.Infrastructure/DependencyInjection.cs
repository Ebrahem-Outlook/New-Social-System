using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Social.Application.Core.Abstractions.Data;
using Social.Domain.Users;
using Social.Infrastructure.Database;
using Social.Infrastructure.Repositories;

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

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());



        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IUserRepository, UserRepository>();


        

        return services;
    }
}
