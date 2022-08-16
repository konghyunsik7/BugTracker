using BugTracker.Models;
using System.Collections.Generic;
using BugTracker.Models;

namespace BugTracker
   
{
    public interface ITicketRepository
    {
        public IEnumerable<Ticket> GetAllTicket();
        public Ticket GetTicketinfo(int id);
        //Create a new ticket
        public void InsertTicket(Ticket ticketToInsert);
        public IEnumerable<ErrorType> GetErrorType();
        public Ticket AssignErrorType();

    }
}
