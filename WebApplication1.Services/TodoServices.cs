using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class TodoServices : ITodoRepository
    {
        public List<Todo> AllTodos()
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