using WordService.Core.Domain.Interfaces;
using WordService.Infrastructure;

namespace WordService.Application.Extensions; 

/// <summary>
/// Extension methods for <see cref="IServiceCollection"/>.
/// </summary>
public static class ServiceAndRepositoryExtension {
    /// <summary>
    /// Adds the services and repositories.
    /// </summary>
    public static IServiceCollection AddServicesAndRepositories(this IServiceCollection services) {
        services.AddSingleton<IDatabase, Database>();
        
        return services;
    }
}
