using System.Collections.Generic;
using Endava.Internship2020.WebApiExamples.Services.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Endava.Internship2020.WebApiExamples.Services
{
  public  interface ITicketsService
  {
      bool Contains(int id);

      IReadOnlyCollection<Ticket> GetAll();

      Ticket Get(int id);

      Ticket Create(Ticket ticket);

      Ticket Update(Ticket ticket);

      Ticket Update(int id, JsonPatchDocument<Ticket> patch);

      void Delete(int id);
  }
}
