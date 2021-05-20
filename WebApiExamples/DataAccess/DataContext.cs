using System;
using Endava.Internship2020.WebApiExamples.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Endava.Internship2020.WebApiExamples.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TicketEntity> Tickets { get; set; } = null!;
    }
}
