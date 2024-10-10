using Microsoft.EntityFrameworkCore;
using ToDoList_Backend.Models;

namespace ToDoList_Backend.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>()
                .HasKey(t => t.TaskId);
        }
    }
}
