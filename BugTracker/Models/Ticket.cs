
namespace BugTracker.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string ErrorTypeID { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Submitter { get; set; }
        public IEnumerable<ErrorType> ErrorType { get; set; }
 
    }
}
