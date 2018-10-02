using Microsoft.EntityFrameworkCore;
namespace testapi.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext>options)
          :base(options)
          {
          }
          public DbSet<todoitem> Todolist {get;set;}
        
    }
}