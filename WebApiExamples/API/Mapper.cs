using API.Examples;
using Endava.Internship2020.WebApiExamples.Services.Models;

namespace API
{
    public static class Mapper
    {
        public static Ticket MapToTicket(TicketRequest ticketRequest)
        {
            return new Ticket()
            {
                Id=ticketRequest.Id,
                Owner = ticketRequest.Owner,
                EventName = ticketRequest.EventName
            };
        }
    }
}
