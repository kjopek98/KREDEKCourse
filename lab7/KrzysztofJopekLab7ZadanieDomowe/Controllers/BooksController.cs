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

  



       
    }
}
