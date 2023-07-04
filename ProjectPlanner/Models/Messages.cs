using System;

namespace ProjectPlanner.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
        public int SenderId { get; set; }
    }
}
