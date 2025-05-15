using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Entities;
using SimpleBookCatalog.DataAccess.Context;

namespace SimpleBookCatalog.DataAccess.Repositories
{
    public class DapperBookRepository : IBookRepository
    {
        private readonly SimpleBookCatalogDbContext context;

        public DapperBookRepository(SimpleBookCatalogDbContext context)
        {
            this.context = context;
        }

        public Task AddBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
