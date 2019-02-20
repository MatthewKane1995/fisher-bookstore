using Microsoft.EntityFrameworkCore; 

namespace Fisher.Bookstore.Models 
{
    public class BookstoreContext : DbContext  // This is the glue between our cs code and the database
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}