using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static ObservableCollection<Book> GetBooks()
        {
            var books = new ObservableCollection<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Fuum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Vue", Author = "Futm", CoverImage = "Assets/11.png" });
            books.Add(new Book { BookId = 3, Title = "Vuate", Author = "Fuum", CoverImage = "Assets/12.png" });
            books.Add(new Book { BookId = 4, Title = "Vute", Author = "Fum", CoverImage = "Assets/10.png" });
            books.Add(new Book { BookId = 5, Title = "Vue", Author = "Fuum", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 6, Title = "Vte", Author = "Futum", CoverImage = "Assets/3.png" });
            books.Add(new Book { BookId = 6, Title = "te", Author = "Fum", CoverImage = "Assets/4.png" });
            books.Add(new Book { BookId = 6, Title = "Vjte", Author = "Futuum", CoverImage = "Assets/5.png" });
            books.Add(new Book { BookId = 6, Title = "jjte", Author = "Futum", CoverImage = "Assets/6.png" });
            books.Add(new Book { BookId = 6, Title = "jte", Author = "Futm", CoverImage = "Assets/7.png" });
            books.Add(new Book { BookId = 6, Title = "Vjpate", Author = "Fum", CoverImage = "Assets/8.png" });
            books.Add(new Book { BookId = 6, Title = "Vuje", Author = "Fum", CoverImage = "Assets/9.png" });
            books.Add(new Book { BookId = 6, Title = "Vuje", Author = "Fum", CoverImage = "Assets/1.png" });

            return books;
        }
    }
}
