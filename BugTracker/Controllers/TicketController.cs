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

    }
}
