using BugTracker.Models;
using System.Collections.Generic;

namespace BugTracker
   
{
    public interface ITicketRepository
    {
        public IEnumerable<Ticket> GetAllTicket();

    
    }
}
