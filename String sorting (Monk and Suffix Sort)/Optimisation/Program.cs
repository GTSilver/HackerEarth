using System;
using System.Collections.Generic;

namespace Optimisation
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var N = input[0].Length;
            var k = int.Parse(input[1]) - 1;
            var strings = new List<string>();

            for (var i = 0; i < N; i++)
            {
                var chars = input[0].ToCharArray(i, N-i);
                strings.Add(new string(chars));
            }

            strings.Sort();

            Console.WriteLine(strings[k]);
        }
    }
}