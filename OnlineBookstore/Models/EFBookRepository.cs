using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private OnlineBookContext _context;
        //constructor
        public EFBookRepository(OnlineBookContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
