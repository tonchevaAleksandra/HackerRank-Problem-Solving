using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HomeworkEFCore.Data.Commons;
using HomeworkEFCore.Models;

namespace HomeworkEFCore
{
  public class Program
    {
        static  async Task Main(string[] args)
        {

            var dbContext = new OrdersSummaryDbContext();
            var ordersRepository = new Repository<Order>(dbContext);
            //Console.WriteLine("Press C to seed the database!");
            //if (Console.ReadKey().Key == ConsoleKey.C)
            //{
            //    await SeedDatabase(dbContext, ordersRepository);
            //}
            
            Console.WriteLine("Press A to view all orders!");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.WriteLine();
                Console.WriteLine(ShowAllOrders(ordersRepository));
            }



        }

        public static string ShowAllOrders(IRepository<Order> ordersRepository)
        {
            StringBuilder sb = new StringBuilder();
            var orders = ordersRepository.AllAsNoTracking()
                .ToList();
            foreach (var order in orders)
            {
                sb.AppendLine(order.Name);
            }

            return sb.ToString().Trim();
        }

        public static async Task SeedDatabase(OrdersSummaryDbContext dbContext, IRepository<Order> ordersRepository)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    await ordersRepository.AddAsync(new Order
                    {
                        CreatedDate = DateTime.UtcNow,
                        Customer = new Customer() { Name = "Pesho" + i },
                        Name = "Order" + (i + 1),
                        Price = i + 10M,
                        Volume = i + 0.5M
                    });
                  await  ordersRepository.SaveChangesAsync();

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
