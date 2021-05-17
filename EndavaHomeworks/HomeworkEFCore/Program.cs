using System;
using System.Linq;
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
            Console.WriteLine("Press C to seed the database!");
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                await SeedDatabase(ordersRepository);
            }

            Console.WriteLine("Press N to see the next 2 orders, P to see previous two orders or A to see all orders!");

            ConsoleKey key = Console.ReadKey().Key;
            var index = 0;
            while (key==ConsoleKey.N || key==ConsoleKey.P || key== ConsoleKey.A)
            {
                if (key==ConsoleKey.N)
                {
                    Console.WriteLine(ShowNextTwoOrders(ordersRepository, index));
                    index += 2;
                }
                else if (key == ConsoleKey.P)
                {
                    index -= 2;
                    Console.WriteLine(ShowPreviousTwoOrders(ordersRepository, index));
                }
                else
                {
                    Console.WriteLine(ShowAllOrders(ordersRepository));
                }

                key = Console.ReadKey().Key;
            }
        }

        public static string ShowPreviousTwoOrders(IRepository<Order> ordersRepository, int skippedNumber)
        {
            StringBuilder sb = new StringBuilder();
            var orders = ordersRepository.AllAsNoTracking()
                .ToList()
                .Skip(skippedNumber)
                .Take(2);
            foreach (var order in orders)
            {
                sb.AppendLine(order.Name);
            }

            return sb.ToString().Trim();
        }

        public static string ShowNextTwoOrders(IRepository<Order> ordersRepository, int skippedNumber)
        {
            StringBuilder sb = new StringBuilder();
            var orders = ordersRepository.AllAsNoTracking()
                .ToList()
                .Skip(skippedNumber)
                .Take(2);
            foreach (var order in orders)
            {
                sb.AppendLine(order.Name);
            }

            return sb.ToString().Trim();
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

        public static async Task SeedDatabase(IRepository<Order> ordersRepository)
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
