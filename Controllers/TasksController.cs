using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Task()
        {
            var tasks = new string[] { "task1", "task2", "task3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult CreteTask()
        {
            return Ok();
        }
        [HttpPut ]
        public IActionResult EditTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var sometingwentwrong = true;
            if (sometingwentwrong)
                return BadRequest();

            return Ok();
        }
    }
}
