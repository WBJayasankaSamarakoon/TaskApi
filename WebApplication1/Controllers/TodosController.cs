using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoServices;

        public TodosController(ITodoRepository repository)
        {
            _todoServices = repository;
        }


        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = _todoServices.AllTodos();
            return Ok(todos);
        }

        
    }
}

