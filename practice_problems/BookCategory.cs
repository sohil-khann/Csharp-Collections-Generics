using System;
namespace OnlineMarketPlace
{
    public class BookCategory//class for Books
    {
        public string Genre { get; set; }
        public string Author { get; set; }

        public BookCategory(string genre, string author) //constructor
        {
            Genre = genre;
            Author = author;
        }
    }
    
}