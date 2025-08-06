using Microsoft.Extensions.DependencyInjection;
using MindVault.Domain.Security;

namespace MindVault.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddMindVaultInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ISecurePasswordStorage, MauiSecurePasswordStorage>();
            return services;
        }
    }
}
