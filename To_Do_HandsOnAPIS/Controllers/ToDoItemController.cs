using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using To_Do_HandsOnAPIS.Models;

namespace To_Do_HandsOnAPIS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        Context context;

        public ToDoItemController(Context _context)
        {
            context = _context;
        }
        [HttpGet]
        public ToDoItem ret()
        {
            var tmp = new ToDoItem { Name = "Kfaka on the Shore Review" , IsComplete = false };
            return tmp;
        }

        [HttpGet]
        public IEnumerable<ToDoItem> Get()
        {
            var lst = context.ToDoItems.ToList();
            return lst;

        }
        public IEnumerable<ToDoItem> Details(int id)
        {
            var lst = context.ToDoItems.Where(s => s.Id == id);
            return lst;

        }

        [HttpPost]
        public IEnumerable<ToDoItem> Add(ToDoItem item)
        {
            var tmp = new ToDoItem { Name = "Kfaka on the Shore Review", IsComplete = false };
            context.ToDoItems.Add(item);
            context.ToDoItems.Add(tmp);
            context.SaveChanges();
            return context.ToDoItems.ToList();
        }

        public IEnumerable<ToDoItem> delete(int id)
        {
            var lst = context.ToDoItems.Where(s => s.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(lst);
            context.SaveChanges();
            return context.ToDoItems.ToList();

        }


    }
}
