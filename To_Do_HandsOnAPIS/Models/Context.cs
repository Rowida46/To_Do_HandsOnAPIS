using Microsoft.EntityFrameworkCore;

namespace To_Do_HandsOnAPIS.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options
            ) : base(options){}

       DbSet<ToDoItem> ToDoItems { get; set; }


    }
}
