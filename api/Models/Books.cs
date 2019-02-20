using System; 

namespace Fisher.Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; } // shortcut to build a property: "prop" + tab

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public DateTime publicationDate { get; set; }
    }
}