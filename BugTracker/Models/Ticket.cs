
namespace BugTracker.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Priorty { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }

 
    }
}
