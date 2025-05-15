using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.BusinessLogic.Entities;

namespace SimpleBookCatalog.DataAccess.Context;

public class SimpleBookCatalogDbContext : DbContext
{

    public SimpleBookCatalogDbContext(DbContextOptions<SimpleBookCatalogDbContext> options)
        : base(options)
    {
    }


    public DbSet<Book> Books { get; set; }
}
