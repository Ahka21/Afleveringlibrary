using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afleveringlibrary
{
    public class BooksRepository 
    {
        private List<Book> _books = new List<Book>();
        public BooksRepository()
        {
            _books = new List<Book>();
            _books.Add(new Book() { Id = 1, Title = "Book 1", Price = 25 });
            _books.Add(new Book() { Id = 2, Title = "Book 2", Price = 29 });
            _books.Add(new Book() { Id = 3, Title = "Book 3", Price = 9});
            _books.Add(new Book() { Id = 4, Title = "Book 4", Price = 14});
            _books.Add(new Book() { Id = 5, Title = "Book 5", Price = 24});

        }
        public IEnumerable<Book>Get(int? filprice = null, int? sortprice = null)
        {
            IEnumerable<Book> result = new List<Book>(_books);
            if(filprice!= null)
            {
                result = result.Where(a => a.Price < filprice);

            }
            if (sortprice != null)
            {
                result = result.OrderBy(a => a.Price < sortprice);
            }
            return result;
        }
        public List<Book> GetallBook()
        {
            return new List<Book>(_books);
        }
        public Book Add(Book book)
        {
            book.validate();
            _books.Add(book);
            return book;
        }
        public Book Getbyid(int id)
        {
            foreach(Book book in _books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }
        public Book Delete(int id)
        {
            Book delete = Getbyid(id);
            if (delete != null)
            {
                _books.Remove(delete);
                return delete;
            }
            return null;
        }
        public Book Update(int id, Book book)
        {
            book.validate();
            foreach(Book _book in _books)
            {
                if(book.Id == id)
                {
                    book.Id = book.Id;
                    book.Title = book.Title;
                    book.Price = book.Price;
                    return book;
                }
            }
            return null;
        }

        public Book Deelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
