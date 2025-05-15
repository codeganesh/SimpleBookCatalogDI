using Microsoft.Extensions.DependencyInjection.Extensions;
using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Services;
using SimpleBookCatalog.DataAccess.Repositories;

namespace SimpleBookCatalog.WebUI.Extensions
{
    public static class SimpleBookCatalogServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<BookService>();
            services.AddScoped<IBookRepository, BookRepository>();

            //services.AddScoped<IBookRepository, DapperBookRepository>();
            

            return services;
        }
    }
}
