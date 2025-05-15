using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Entities;

namespace SimpleBookCatalog.DataAccess.Repositories
{
    public class LoggingBookRepository : IBookRepository
    {
        private readonly IBookRepository repository;

        public LoggingBookRepository(IBookRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddBookAsync(Book book)
        {
            await repository.AddBookAsync(book);
            Console.WriteLine("Book added: " + book.Title);
        }
    }
}
