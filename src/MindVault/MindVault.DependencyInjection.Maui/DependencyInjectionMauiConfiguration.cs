using Microsoft.Extensions.DependencyInjection;
using MindVault.Domain.Security;
using MindVault.Infrastructure.Maui.Security;

namespace MindVault.DependencyInjection
{
    public static class DependencyInjectionMauiConfiguration
    {
        public static IServiceCollection AddMindVaultInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ISecurePasswordStorage, MauiSecurePasswordStorage>();
            return services;
        }
    }
}
