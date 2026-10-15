using LibraryManagement.Application.Interfaces;
using LibraryManagement.Infrastructure.DAL;
using LibraryManagement.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            services.AddScoped<IProductDAL, ProductDAL>();
            services.AddScoped<IEmailService, EmailService>();

            return services;
        }
    }
}