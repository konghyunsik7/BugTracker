using BugTracker.Models;
using Dapper;
using System;
using System.Data;



namespace BugTracker
{
    public class TicketRepository : ITicketRepository
    {  
        //SHOW ALL TICKETS

        private readonly IDbConnection _conn;
        public TicketRepository(IDbConnection conn)
        {
            _conn = conn;
        }
      
        public IEnumerable<Ticket> GetAllTicket()
        {
            return _conn.Query<Ticket>("SELECT * FROM bugtracker.ticket;");
        }
        //SHOW SINGLE TICKET INFO
        public Ticket GetTicketinfo(int id)
        {
            return _conn.QuerySingle<Ticket>("SELECT * FROM ticket WHERE ticketID = @id", new { id = id });
        }

        //CREATE A TICKET
        public void InsertTicket(Ticket ticketToInsert)
        {
            _conn.Execute("INSERT INTO ticket (ErrorTypeID, Description,Submitter) VALUES (@errortypeid, @description, @submitter);",
                new { errortypeid = ticketToInsert.ErrorTypeID, description = ticketToInsert.Description, submitter = ticketToInsert.Submitter});
        }

        public IEnumerable<ErrorType> GetErrorType()
        {
            return _conn.Query<ErrorType>("SELECT * FROM errortype;");
        }
        public Ticket AssignErrorType()
        {
            var errorTypeList = GetErrorType();
            var errorTpye = new Ticket();
            errorTpye.ErrorType = errorTypeList;
            return errorTpye;
        }
    }
}
