using KrzysztofJopekLab7ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.Services
{
    interface IBookService
    {
        public void LoadDb(ApplicationDbContext context);

        /// <summary>
        /// Zwraca listę wszystkich książek
        /// </summary>
        /// <returns></returns>
        public List<Book> Get();
   
        /// <summary>
        /// Zwraca pojedynczą książkę o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBook(int id);

        /// <summary>
        /// Metoda do dodawania nowej książki
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Post(Book book);
       
        /// <summary>
        /// Metoda do edytowania istniejącej książki
        /// </summary>
        /// <param name="book"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Book book, int id);
      
        /// <summary>
        /// Metoda do usuwania zawodnika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id);
       
    }
}
