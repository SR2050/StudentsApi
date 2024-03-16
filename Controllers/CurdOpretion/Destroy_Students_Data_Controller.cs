using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsApi.Ef_Core; // Assuming your DbContext is defined in this namespace

namespace StudentsApi.Controllers.CrudOperation // Correcting the namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestroyStudentsDataController : ControllerBase // Correcting the class name
    {
        private readonly Ef_DataContext _context; // Adding the DbContext field

        public DestroyStudentsDataController(Ef_DataContext context)
        {
            _context = context; // Injecting DbContext through constructor
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) // Removed [FromRoute], unnecessary in this case
        {
            var student = _context.Students.Find(id); // Corrected query to find student

            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
