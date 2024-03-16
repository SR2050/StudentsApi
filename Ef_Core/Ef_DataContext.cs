using Microsoft.EntityFrameworkCore;

namespace StudentsApi.Ef_Core
{
    public class Ef_DataContext : DbContext
    {
        public Ef_DataContext(DbContextOptions<Ef_DataContext> options) : base(options) { }

        // DbSet properties for your entity classes can be added here

        public DbSet<Students> Students { get; set; }


    }
}
