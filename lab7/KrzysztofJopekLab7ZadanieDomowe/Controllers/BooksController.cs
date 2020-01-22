using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KrzysztofJopekLab7ZadanieDomowe.Models;
using AutoMapper;
using KrzysztofJopekLab7ZadanieDomowe.Services;

namespace KrzysztofJopekLab7ZadanieDomowe.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BooksController(ApplicationDbContext context, IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;

            _bookService.LoadDb(context);
        }

        // GET: api/Books
        [HttpGet]
        public IActionResult Get()
        {

            var books = _bookService.Get();

            return Ok(books);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            var id = _bookService.Post(book);
            return Ok(id);
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Book book, [FromRoute] int id)
        {
            if (id != book.Id)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccesful = _bookService.Put(book, id);
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
            bool isDeleteSuccesful = _bookService.Delete(id);
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
