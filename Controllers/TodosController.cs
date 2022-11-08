
using ApiProject.Services;
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
    public class TodosController : ControllerBase
    {
        //  private TodoService _todoService;
        private ITodoRepositary _todoService;
        public TodosController(ITodoRepositary repositary)
        {
            // _todoService = new TodoService();
            _todoService = repositary;
        }


        [HttpGet("{id}")]
       public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService. Alltodos();
            if (id is null) return Ok(myTodos);
            myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);

        }

       
    }
}
