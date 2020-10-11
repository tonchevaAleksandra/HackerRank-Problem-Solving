using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudyDay
{
    public class Town
    {
        public long Location { get; set; }
        public long  Population { get; set; }
        public int CountClouds { get; set; }
        public bool IsSunny { get; set; }

        public Town(long location, long population)
        {
            this.Location = location;
            this.Population = population;
            this.CountClouds = 0;
            this.IsSunny = true;
        }
    }
    public class Cloud
    {
        public long StartPoint { get; set; }
        public long EndPoint { get; set; }
        public long PopulationAtached { get; set; }
        public Cloud(long startPoint, long endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.PopulationAtached = 0;
        }
    }
    class Program
    {
        static long maximumPeople(long[] p, long[] x, long[] y, long[] r)
        {
            var towns = new List<Town>();
           var clouds =new List<Cloud>();
            for (int i = 0; i < y.Length; i++)
            {
                var cloud = new Cloud(Math.Max(y[i] - r[i], 0), y[i] + r[i]);
                clouds.Add(cloud);
            }
            for (int i = 0; i < x.Length; i++)
            {
                var town = new Town(x[i], p[i]);
                towns.Add(town);
                var currCount = clouds.Where(c => c.StartPoint <= x[i] && c.EndPoint >= x[i]).Count();
                var index = Array.BinarySearch(clouds.ToArray(), clouds.Where(c => c.StartPoint <= x[i] && c.EndPoint >= x[i]));
              
                if(currCount>0)
                {
                    clouds[index].PopulationAtached += towns[i].Population;
                    town.CountClouds = currCount;
                    town.IsSunny = false;
                }
            }


           var maxPop= towns.Where(t => t.CountClouds == 1).OrderByDescending(c => c.Population).FirstOrDefault().Population;
            var popByCloud = clouds.OrderByDescending(c => c.PopulationAtached).FirstOrDefault().PopulationAtached;
            maxPop += Math.Max(towns.Where(t => t.IsSunny == true).Select(t => t.Population).Sum(),popByCloud);
            return maxPop;
            // Return the maximum number of people that will be in a sunny town after removing exactly one cloud.
            //if (y.Length == 1 )
            //{
            //    return p.Sum();
            //}

            //var clouds = new Dictionary<long, long>();
            //for (int i = 0; i < y.Length; i++)
            //{
            //    if(!clouds.ContainsKey(Math.Max(y[i] - r[i],0)))
            //    {
            //        clouds.Add(Math.Max(y[i] - r[i], 0), y[i] + r[i]);
            //    }
            //    else
            //    {
            //        if(clouds[Math.Max(y[i] - r[i], 0)] < y[i] + r[i])
            //        {
            //            clouds[Math.Max(y[i] - r[i], 0)] = y[i] + r[i];
            //        }
            //    }
               
            //}
            //var towns= new Dictionary<long,List<long>>();
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if(!towns.ContainsKey(x[i]))
            //    {
            //        towns.Add(x[i], new List<long>());
            //    }
            //    towns[x[i]][0] += p[i];
                
            //    towns[x[i]][1] = clouds.Where(a => a.Key <= x[i] && a.Value >= x[i]).Count();

            //}
            //var currentTownSunny = towns.Where(a => a.Value[1] == 0).ToDictionary(a => a.Key, a => a.Value);
            //var sunnyPop = currentTownSunny.Select(b => b.Value[0]).ToArray().Sum();
            //var maxPopCloud = towns.Where(a => a.Value[1] == 1).ToDictionary(a => a.Key, a => a.Value).OrderByDescending(a => a.Value[0]).Take(1).ToDictionary(a=>a.Key,a=>a.Value);
            //long maxPopulation = 0;
            //foreach (var item in maxPopCloud)
            //{
            //    maxPopulation += item.Value[0];
            //}
            //return maxPopulation + sunnyPop;
           


            
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            long[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt64(pTemp))
            ;

            long[] x = Array.ConvertAll(Console.ReadLine().Split(' '), xTemp => Convert.ToInt64(xTemp))
            ;
            int m = Convert.ToInt32(Console.ReadLine());

            long[] y = Array.ConvertAll(Console.ReadLine().Split(' '), yTemp => Convert.ToInt64(yTemp))
            ;

            long[] r = Array.ConvertAll(Console.ReadLine().Split(' '), rTemp => Convert.ToInt64(rTemp))
            ;
            long result = maximumPeople(p, x, y, r);

            Console.WriteLine(result);

        }
    }
}
