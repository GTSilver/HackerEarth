using System;

namespace Massive_Inverser_2D
{
    class Program
    {
        static void Main()
        {
            Int16 T = Int16.Parse(Console.ReadLine());
            for (var times = 0; times < T; times++)
            {
                Int16 N = Int16.Parse(Console.ReadLine());
                Int16[][] array = new Int16[N][];

                for (var i = 0; i < N; i++)
                {
                    array[i] = Array.ConvertAll(Console.ReadLine().Split(' '), Int16.Parse);
                }

                UInt16 count = 0;
                for (var i = 0; i < N; i++)
                    for (var j = 0; j < N; j++)
                        for (var q = i; q < N; q++)
                            for (var p = j; p < N; p++)
                                if (array[i][j] > array[q][p]) count++;
                Console.WriteLine(count);
            }
        }
    }
}