using System;

namespace Operators
{
    class Program
    {
        static decimal solve(double meal_cost, int tip_percent, int tax_percent)
        {
            decimal price = (decimal)(meal_cost + (meal_cost * tip_percent) / 100);
            price += (decimal)((meal_cost * tax_percent) / 100);
            return price;
        }
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

           decimal totalPrice= solve(meal_cost, tip_percent, tax_percent);
            Console.WriteLine(Math.Round(totalPrice));
        }
    }
}
