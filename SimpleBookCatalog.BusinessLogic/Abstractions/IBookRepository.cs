using SimpleBookCatalog.BusinessLogic.Entities;

namespace SimpleBookCatalog.BusinessLogic.Abstractions;

public interface IBookRepository
{
    Task AddBookAsync(Book book);
}
