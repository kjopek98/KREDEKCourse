using EntityFrameworkLab4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab4.Repositories
{
    class SkiJumpingGeneric<T> : ISkiJumpingGeneric<T> where T : class
    {
        private readonly SkiJumpingContext _context;

        public SkiJumpingGeneric()
        {
            _context = new SkiJumpingContext();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
