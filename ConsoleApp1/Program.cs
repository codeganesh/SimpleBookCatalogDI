
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Services;
using SimpleBookCatalog.DataAccess.Context;
using SimpleBookCatalog.DataAccess.Repositories;

var services = new ServiceCollection();

services.AddScoped<BookService>();
services.AddScoped<IBookRepository, BookRepository>();
services.AddDbContext<SimpleBookCatalogDbContext>(options =>
{
    options.UseSqlServer("server=(localdb)\\mssqllocaldb;database=SimpleBookCatalogDb;integrated security=true");
});

var provider = services.BuildServiceProvider(validateScopes: true);

//var bookService1 = provider.GetRequiredService<BookService>();
//Console.WriteLine(bookService1.GetHashCode());

//var bookService2 = provider.GetRequiredService<BookService>();
//Console.WriteLine(bookService2.GetHashCode());

using (var scope = provider.CreateScope())
{
    var bookService1 = scope.ServiceProvider.GetRequiredService<BookService>();
    Console.WriteLine(bookService1.GetHashCode());

    var bookService2 = scope.ServiceProvider.GetRequiredService<BookService>();
    Console.WriteLine(bookService2.GetHashCode());
}

using (var scope = provider.CreateScope())
{
    var bookService1 = scope.ServiceProvider.GetRequiredService<BookService>();
    Console.WriteLine(bookService1.GetHashCode());

    var bookService2 = scope.ServiceProvider.GetRequiredService<BookService>();
    Console.WriteLine(bookService2.GetHashCode());
}