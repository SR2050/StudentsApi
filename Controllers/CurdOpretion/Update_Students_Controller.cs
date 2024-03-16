using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsApi.Ef_Core;

namespace StudentsApi.Controllers.CrudOperation // Correcting the namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateStudentsController : ControllerBase // Correcting the class name
    {
        private readonly Ef_DataContext _context; // Adding the DbContext field

        public UpdateStudentsController(Ef_DataContext context)
        {
            _context = context; // Injecting DbContext through constructor
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Students student) // Removed [FromRoute], unnecessary in this case
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingStudent = _context.Students.FirstOrDefault(x => x.StudentsId == id); // Corrected query to find existing student

            if (existingStudent == null)
            {
                return NotFound();
            }

            existingStudent.StudentName = student.StudentName;

            // Update other properties as needed

            _context.SaveChanges();

            return NoContent();
        }
    }
}
