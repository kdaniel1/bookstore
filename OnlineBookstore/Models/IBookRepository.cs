using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public interface IBookRepository
    {
      IQueryable<Book> Books { get; }
    }
}
