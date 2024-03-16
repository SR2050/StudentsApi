using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Ef_Core; // Assuming Ef_DataContext is defined in this namespace

namespace StudentsApi.Controllers.CrudOperation // Correcting the namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindStudentsWithIdController : ControllerBase // Correcting the class name
    {
        private readonly Ef_DataContext _context; // Adding the DbContext field

        public FindStudentsWithIdController(Ef_DataContext context)
        {
            _context = context; // Injecting DbContext through constructor
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) // Removed [FromRoute], unnecessary in this case
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentsId == id); // Correcting the query

            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student); // Correcting return statement (Student -> student)
            }
        }
    }
}
