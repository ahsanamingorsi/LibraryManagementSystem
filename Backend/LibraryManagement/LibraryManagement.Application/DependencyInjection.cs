using LibraryManagement.Application.BLL;
using LibraryManagement.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddScoped<IProductBLL, ProductBLL>();

            return services;
        }
    }
}