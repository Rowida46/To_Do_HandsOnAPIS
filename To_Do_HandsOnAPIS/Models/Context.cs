using Microsoft.EntityFrameworkCore;

namespace To_Do_HandsOnAPIS.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options
            ) : base(options){}

       public DbSet<ToDoItem> ToDoItems { get; set; }


    }
}
