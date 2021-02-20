using System;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Models
{
    public class OnlineBookContext : DbContext
    {
        //constructor for passing the context into the DB
        public OnlineBookContext (DbContextOptions<OnlineBookContext> options) : base (options)
        {
           
        }
        public DbSet<Book> Books { get; set; }
    }
}
