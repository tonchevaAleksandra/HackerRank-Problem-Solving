using System.Collections.Generic;
using API.Examples;
using Microsoft.AspNetCore.Mvc;
using Endava.Internship2020.WebApiExamples.Services;
using Endava.Internship2020.WebApiExamples.Services.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        public const string TicketNotFound = "Ticket with given id does not exist.";
        private readonly ITicketsService _ticketsService;

        public TicketsController(ITicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }

        [HttpPost]
        public IActionResult CreateTicket(TicketRequest ticketRequest)
        {
            Ticket ticket = this._ticketsService.Create(Mapper.MapToTicket(ticketRequest));
            return CreatedAtRoute("GetTicket", new { id = ticket.Id }, ticket);
        }


        [HttpGet("id", Name = "GetTicket")]
        public IActionResult GetTicket(int id)
        {
            if (!this._ticketsService.Contains(id))
            {
                return this.NotFound(TicketNotFound);
            }
            Ticket ticket = this._ticketsService.Get(id);

            return Ok(ticket);
        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            IEnumerable<Ticket> tickets = this._ticketsService.GetAll();
            return Ok(tickets);
        }

        [HttpPatch("id")]
        public IActionResult UpdateTicket(int id, JsonPatchDocument<Ticket> patchDocument)
        {
            if (!this._ticketsService.Contains(id))
            {
                return this.NotFound(TicketNotFound);
            }

            Ticket ticket = this._ticketsService.Update(id, patchDocument);

            return Ok(ticket);
        }

        [HttpDelete]
        public IActionResult DeleteTicket(int id)
        {
            if (!this._ticketsService.Contains(id))
            {
                return NotFound(TicketNotFound);
            }
            this._ticketsService.Delete(id);

            return Ok();
        }
    }
}
