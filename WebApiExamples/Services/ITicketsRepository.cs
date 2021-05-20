using System.Collections.Generic;
using Endava.Internship2020.WebApiExamples.Services.Models;

namespace Endava.Internship2020.WebApiExamples.Services
{
    public interface ITicketsRepository
    {
        bool Contains(int id);
        Ticket Create(Ticket ticket);
        void Delete(int id);
        Ticket Get(int id);
        IReadOnlyCollection<Ticket> GetAll();
        Ticket Update(Ticket ticket);
    }
}