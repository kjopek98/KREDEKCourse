using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KrzysztofJopekLab7ZadanieDomowe.Models;
using KrzysztofJopekLab7ZadanieDomowe.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KrzysztofJopekLab7ZadanieDomowe.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(ApplicationDbContext context, IUserService userService)
        {
            _userService = userService;
            _userService.LoadDb(context);
        }
        [HttpGet]
        public IActionResult Get()
        {

            var users = _userService.Get();

            return Ok(users);
        }
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            var id = _userService.Post(user);
            return Ok(id);
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] User user , [FromRoute] int id)
        {
            if (id != user.ID)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccesful = _userService.Put(user, id);
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
            bool isDeleteSuccesful = _userService.Delete(id);
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