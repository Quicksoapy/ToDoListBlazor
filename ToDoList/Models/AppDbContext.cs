using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions)
        : base(dbContextOptions)
        {
            
        }
        public DbSet<Task> Tasks { get; set; }
    }
}