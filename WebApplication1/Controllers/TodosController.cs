using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok();
        }

        //Get Todos
        private List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some test books for the school",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodoStatus.NotStarted
            };

            todos.Add(todo1);

            return todos;
        }
    }
}
