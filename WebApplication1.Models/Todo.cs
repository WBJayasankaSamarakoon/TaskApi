﻿namespace WebApplication1.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Due { get; set; }
        public TodoStatus Status { get; set; }
    }
}
