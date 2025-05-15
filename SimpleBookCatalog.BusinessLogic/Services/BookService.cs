using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Entities;

namespace SimpleBookCatalog.BusinessLogic.Services;

public class BookService
{
    private readonly IBookRepository repository;

    public BookService(IBookRepository repository)
    {
        if (repository == null)
            throw new ArgumentNullException(nameof(repository));

        this.repository = repository;
    }

    public async Task AddBook(
        string title,
        string author,
        DateOnly publicationDate)
    {

        var book = new Book
        {
            Title = title,
            Author = author,
            PublicationDate = publicationDate
        };

        await repository.AddBookAsync(book);
    }
}
