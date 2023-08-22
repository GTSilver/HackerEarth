using System;
using System.Collections.Generic;
using System.Linq;

namespace Optimisation
{
    class Program
    {
        static void Main()
        {
            var T = int.Parse(Console.ReadLine());
            for (var t = 0; t < T; t++)
            {
                var N1 = int.Parse(Console.ReadLine());
                var input = Console.ReadLine().Split(' ');
                var growths = new List<int>();

                for (var i = 0; i < N1; i++)
                    growths.Add(int.Parse(input[i]));
                
                var counts = growths.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                var minValue = counts.OrderBy(x => x.Value).FirstOrDefault().Value;
                var maxValue = counts.OrderByDescending(x => x.Value).FirstOrDefault().Value;

                if (maxValue - minValue <= 0)
                    Console.WriteLine(-1);
                else
                    Console.WriteLine(maxValue - minValue);
            }
        }
    }
}