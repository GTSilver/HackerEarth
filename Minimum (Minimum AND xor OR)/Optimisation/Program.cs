using System;
namespace Optimisation
{
    class Program
    {
        static void Main()
        {
            int Tests = int.Parse(Console.ReadLine());
            for (var T = 0; T < Tests; T++)
            {
                int N = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                var chars = input.Split(' ');
                var array = new int[N];
                int temporary;
                int output = int.MaxValue;

                for (var i = 0; i < N; i++)
                    array[i] = int.Parse(chars[i]);

                Array.Sort(array);

                for (var i = 0; i < N - 1; i++)
                {
                    temporary = array[i] ^ array[i + 1];
                    if (temporary < output) output = temporary;
                }
                Console.WriteLine(output);
            }
        }
    }
}