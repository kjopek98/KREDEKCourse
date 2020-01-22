using KrzysztofJopekLab7ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.Services
{
    public interface IUserService
    {

        public void LoadDb(ApplicationDbContext context);

        /// <summary>
        /// Zwraca listę wszystkich użytkowników
        /// </summary>
        /// <returns></returns>
        public List<User> Get();

        /// <summary>
        /// Zwraca pojedynczego użytkownika o podanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id);

        /// <summary>
        /// Metoda do dodawania nowego użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Post(User user);

        /// <summary>
        /// Metoda do edytowania istniejącego użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(User user, int id);

        /// <summary>
        /// Metoda do usuwania użytkownika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id);

    }
}

