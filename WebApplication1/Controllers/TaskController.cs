using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "Task01", "Task02" };
            return Ok(tasks);

        }

        [HttpPost]
        public IActionResult newTasks()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult updateTasks()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult deleteTaks()
        {
            var somthingWentWrong = true;
            if (somthingWentWrong)
                return BadRequest();
                return Ok();
        }

    }
        


}
