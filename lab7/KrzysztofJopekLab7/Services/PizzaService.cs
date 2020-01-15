using KrzysztofJopekLab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KrzysztofJopekLab7.Services
{
    public class PizzaService : IPizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>();

        public List<Pizza> Get()
        {
            return pizzas;
        }
        public int Post(Pizza pizza)
        {
            int id;
            if (pizzas.Count == 0)
            {
                id = 0;
                pizza.Id = id;
            }
            else
            {
                id = pizzas.Max(x => x.Id);
                pizza.Id = ++id;
            }
            pizzas.Add(pizza);
            return id;
        }

        public bool Put(Pizza pizza, int id)
        {

            var pizzaToUpdate = pizzas.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (pizzaToUpdate == null)
            {
                return false;
            }
            pizzaToUpdate.Name = pizza.Name;
            pizzaToUpdate.Cost = pizza.Cost;
            pizzaToUpdate.Description = pizza.Description;
            return true;
        }
        public bool Delete(int id)
        {
            var pizzaToDelete = pizzas.Where(x => x.Id.Equals(id)).SingleOrDefault();
            if (pizzaToDelete == null)
            {
                return false;
            }
            pizzas.Remove(pizzaToDelete);
            return true;
        }
    }
}
