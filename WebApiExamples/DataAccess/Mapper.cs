using Endava.Internship2020.WebApiExamples.DataAccess.Entities;
using Endava.Internship2020.WebApiExamples.Services.Models;

namespace Endava.Internship2020.WebApiExamples.DataAccess
{
    public static class Mapper
    {
        public static TicketEntity Map(Ticket ticket)
        {
            return new TicketEntity
            {
                Id = ticket.Id,
                EventName = ticket.EventName,
                Owner = ticket.Owner
            };
        }

        public static Ticket Map(TicketEntity ticketEntity)
        {
            return new Ticket
            {
                Id = ticketEntity.Id,
                EventName = ticketEntity.EventName,
                Owner = ticketEntity.Owner
            };
        }
    }
}
