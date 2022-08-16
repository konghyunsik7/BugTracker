
namespace BugTracker.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string ErrorID { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Submitter { get; set; }

 
    }
}
