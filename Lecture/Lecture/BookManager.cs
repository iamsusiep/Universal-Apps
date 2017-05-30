using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lecture.Models
{
    public class BookManager
    {

        public static ObservableCollection<Book> GetBooks()
        {
            var books = new ObservableCollection<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurm", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/3.png" });

            return books;
        }
    }
}