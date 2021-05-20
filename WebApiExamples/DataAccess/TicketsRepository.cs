using System.Collections.Generic;
using System.Linq;
using Endava.Internship2020.WebApiExamples.Services;
using Endava.Internship2020.WebApiExamples.Services.Models;

namespace Endava.Internship2020.WebApiExamples.DataAccess
{
    public class TicketsRepository : ITicketsRepository
    {
        private readonly DataContext dataContext;

        public TicketsRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Ticket Create(Ticket ticket)
        {
            var ticketEntity = Mapper.Map(ticket);

            dataContext.Tickets.Add(ticketEntity);
            dataContext.SaveChanges();

            return Mapper.Map(ticketEntity);
        }

        public IReadOnlyCollection<Ticket> GetAll()
        {
            return dataContext.Tickets.Select(t => Mapper.Map(t)).ToList();
        }

        public Ticket Get(int id)
        {
            var ticketEntity = dataContext.Tickets.Find(id);
            return Mapper.Map(ticketEntity);
        }

        public Ticket Update(Ticket ticket)
        {
            var ticketEntity = dataContext.Tickets.Find(ticket.Id);

            ticketEntity.EventName = ticket.EventName;
            ticketEntity.Owner = ticket.Owner;

            dataContext.Tickets.Update(ticketEntity);
            dataContext.SaveChanges();

            return Mapper.Map(ticketEntity);
        }

        public void Delete(int id)
        {
            var ticketEntity = dataContext.Tickets.Find(id);

            dataContext.Tickets.Remove(ticketEntity);
            dataContext.SaveChanges();
        }

        public bool Contains(int id)
        {
            return dataContext.Tickets.Any(t => t.Id == id);
        }
    }
}
