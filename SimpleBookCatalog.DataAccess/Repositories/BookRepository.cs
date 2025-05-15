using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Entities;
using SimpleBookCatalog.DataAccess.Context;

namespace SimpleBookCatalog.DataAccess.Repositories;

public class BookRepository : IBookRepository
{
    private readonly SimpleBookCatalogDbContext context;

    public BookRepository(SimpleBookCatalogDbContext context)
    {
        this.context = context;
    }

    public async Task AddBookAsync(Book book)
    {
        context.Books.Add(book);
        await context.SaveChangesAsync();
    }
}
