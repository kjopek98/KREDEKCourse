using KrzysztofJopekLab7ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7ZadanieDomowe.Services
{
    public class UserService : IUserService
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
        /// Zwraca listę wszystkich użytkowników
        /// </summary>
        /// <returns></returns>
        public List<User> Get()
        {
            return _context.Users.ToList();
        }
        /// <summary>
        /// Zwraca pojedyńczego użytkownika o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id)
        {
            var user = _context.Users.SingleOrDefault(p => p.ID.Equals(id));

            return user;
        }
    
        public bool Post(User user)
        {
            _context.Users.Add(user);

            _context.SaveChanges();

            return true;
        }
        public bool Put(User user, int id)
        {
            var userToUpdate = _context.Users.SingleOrDefault(p => p.ID.Equals(id));

            if (userToUpdate == null)
                return false;

            userToUpdate.Login = user.Login;

            userToUpdate.Password = user.Password;

            //zapisanie zmian w bazie danych
            _context.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            var userToDelete = _context.Users.SingleOrDefault(p => p.ID.Equals(id));

            if (userToDelete == null)
            {
                return false;
            }
            else
            {
                _context.Remove(userToDelete);
                //zapisanie zmian w bazie danych
                _context.SaveChanges();
            }


            return true;
        }



       

        
    }
}
