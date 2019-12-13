﻿using KrzysztofJopekLab4Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrzysztofJopekLab4Zadanie.Repositories
{
    class FlightStoreGeneric<T> : IFlightStoreGeneric<T> where T : class
    {
        private readonly  FlightStoreContext _context;

        public FlightStoreGeneric()
        {
            _context = new FlightStoreContext();
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
