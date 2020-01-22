using KrzysztofJopekLab7ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.Services
{
    public class BookService : IBookService
    {

        private ApplicationDbContext _context;

        /// <summary>
        /// Wczytywanie bazy
        /// </summary>
        /// <param name="context"></param>
        public void LoadDb(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Zwraca listę wszystkich książek
        /// </summary>
        /// <returns></returns>
        public List<Book> Get()
        { 

            return _context.Books.ToList();

        }
        /// <summary>
        /// Zwraca pojedynczą książkę o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBook(int id)
        {
            

            var book = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

            return book;
        }
        /// <summary>
        /// Metoda do dodawania nowej książki
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Post(Book book)
        {
            _context.Books.Add(book);

            _context.SaveChanges();

            return true;
        }
        /// <summary>
        /// Metoda do edytowania istniejącej książki
        /// </summary>
        /// <param name="book"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Book book, int id)
        {
            var bookToUpdate = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

            if (bookToUpdate == null)
                return false;

                bookToUpdate.Title = book.Title;

                bookToUpdate.Author = book.Author;
       
                bookToUpdate.Year = book.Year;

                bookToUpdate.Type = book.Type;

                bookToUpdate.Type = book.Type;

            bookToUpdate.Description = book.Description;


            //zapisanie zmian w bazie danych
            _context.SaveChanges();
            return true;

        }
        /// <summary>
        /// Metoda do usuwania zawodnika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var bookToDelete = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

            if (bookToDelete == null)
            {
                return false;
            }
            else
            {
                _context.Remove(bookToDelete);
                //zapisanie zmian w bazie danych
                _context.SaveChanges();
            }


            return true;
        }

    }
}
