using System.Collections.Generic;
using Endava.Internship2020.WebApiExamples.Services.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Endava.Internship2020.WebApiExamples.Services
{
    public class TicketsService
    {
        private readonly ITicketsRepository repository;

        public TicketsService(ITicketsRepository repository)
        {
            this.repository = repository;
        }

        public bool Contains(int id)
        {
            return repository.Contains(id);
        }

        public IReadOnlyCollection<Ticket> GetAll()
        {
            return repository.GetAll();
        }

        public Ticket Get(int id)
        {
            return repository.Get(id);
        }

        public Ticket Create(Ticket ticket)
        {
            return repository.Create(ticket);
        }

        public Ticket Update(Ticket ticket)
        {
            return repository.Update(ticket);
        }

        public Ticket Update(int id, JsonPatchDocument<Ticket> patch)
        {
            var existingTicket = Get(id);

            patch.ApplyTo(existingTicket);

            return repository.Update(existingTicket);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
