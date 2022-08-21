namespace To_Do_HandsOnAPIS.Models
{
    // The model for this app is a single TodoItem class.
    public class ToDoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; } // allow null val
        public bool IsComplete { get; set; }
    }
}
