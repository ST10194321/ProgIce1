namespace TaskManager.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Details { get; set; }
        public DateTime DueDate { get; set; }
        public string TaskStatus { get; set; }

    }
}
