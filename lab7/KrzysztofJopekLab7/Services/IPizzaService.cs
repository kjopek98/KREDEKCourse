using KrzysztofJopekLab7.Models;
using System.Collections.Generic;

namespace KrzysztofJopekLab7.Services
{
    public interface IPizzaService
    {
        List<Pizza> Get();
        int Post(Pizza pizza);
        bool Put(Pizza pizza, int id);
        bool Delete(int id);
    }
}