using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsApi.Ef_Core; // Assuming your DbContext is defined in this namespace

namespace StudentsApi.Controllers.CrudOperation // Correcting the namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateNewStudentsDataController : ControllerBase // Correcting the class name
    {
        private readonly Ef_DataContext _context; // Adding the DbContext field

        public CreateNewStudentsDataController(Ef_DataContext context)
        {
            _context = context; // Injecting DbContext through constructor
        }

        [HttpPost]
        public IActionResult Create([FromBody] Students students)
        {
            if (students == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Students.Add(students); // Corrected reference to Students DbSet in the DbContext
                _context.SaveChanges();
                // return CreatedAtAction(nameof(GetById), new { id = students.StudentsId }, students); 
                // Corrected property name (StudentsId -> StudentId)

                //return CreatedAtAction("GetById", "FindStudentsWithId", new { id = students.StudentsId }, students);
                return CreatedAtAction("GetById", "FindStudentsWithId", new { id = students.StudentsId }, students);

            }
        }
    }
}
