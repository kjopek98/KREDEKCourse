using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KrzysztofJopekLab7.Models;
using KrzysztofJopekLab7.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KrzysztofJopekLab7.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService pizzaService;
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        public PizzaController(IPizzaService _pizzaService)
        {
            pizzaService = _pizzaService;
        }
        /// <summary>
        /// Metoda Get pobierająca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = pizzaService.Get();
            return Ok(pizzas);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Pizza pizza)
        {
            var id = pizzaService.Post(pizza);
            return Ok(id);
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Pizza pizza, [FromRoute] int id)
        {
            if (id != pizza.Id)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccesful = pizzaService.Put(pizza, id);
                if (isUpdateSuccesful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
                
            }
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool isDeleteSuccesful = pizzaService.Delete(id);
            if (isDeleteSuccesful)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }

        }
    }
}