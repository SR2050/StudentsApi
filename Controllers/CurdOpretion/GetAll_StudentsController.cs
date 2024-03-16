using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Ef_Core;
using System.Linq; // Adding System.Linq for ToList()

namespace StudentsApi.Controllers.CrudOperation // Correcting the namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllStudentsController : ControllerBase // Correcting the class name
    {
        private readonly Ef_DataContext _context; // Adding the DbContext field

        public GetAllStudentsController(Ef_DataContext context)
        {
            _context = context; // Injecting DbContext through constructor
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _context.Students.ToList(); // Correcting the query and accessing Students from the DbContext

            return Ok(students); // Correcting return statement
        }
    }
}
