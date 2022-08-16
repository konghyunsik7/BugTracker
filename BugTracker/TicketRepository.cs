using BugTracker.Models;
using Dapper;
using System;
using System.Data;



namespace BugTracker
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IDbConnection _conn;
        public TicketRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        //SHOW ALL TICKETS
        public IEnumerable<Ticket> GetAllTicket()
        {
            return _conn.Query<Ticket>("SELECT * FROM bugtracker.ticket;");
        }
        //CREATING A TICKET
      
    }
}
