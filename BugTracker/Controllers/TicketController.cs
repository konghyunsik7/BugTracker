using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository repo;

        public TicketController(ITicketRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var ticket = repo.GetAllTicket();
            return View(ticket);
        }
        //SELECT SIGNLE TICKET DETAILED
        public IActionResult GetTicketinfo(int id)
        {
            var ticket = repo.GetTicketinfo(id);
            return View(ticket);
        }
        //CREATE A TICKET
        public IActionResult InsertTicket()
        {
            var tick = repo.AssignErrorType();
            return View(tick);
        }
        public IActionResult InsertErrorTypeToDatabase(Ticket ticketToInsert)
        {
            repo.InsertTicket(ticketToInsert);
            return RedirectToAction("Index");
        }

    }
}
