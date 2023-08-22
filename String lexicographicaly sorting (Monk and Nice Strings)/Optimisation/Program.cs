using System;
using System.Collections.Generic;
using System.Text;

namespace Optimisation
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var unsortedByte = new List<byte[]>();
            var unsortedFloat = new List<double>();
            var sortedFloat = new List<double>();
            for (var i = 0; i < N; i++)
            {
                unsortedByte.Add(Encoding.ASCII.GetBytes(Console.ReadLine()));
                var temporaryString = "0,";

                for (var j = 0; j < unsortedByte[i].Length; j++)
                    temporaryString += (unsortedByte[i][j] - 23);

                var temporaryFloat = double.Parse(temporaryString);
                unsortedFloat.Add(temporaryFloat);
                sortedFloat.Add(temporaryFloat);
            }
            
            sortedFloat.Sort();
            for (var i = 0; i < N; i++)
            {
                var tenderString1 = unsortedFloat[i];
                var count = 0;
                for (var j = 0; j < i; j++)
                {
                    var tenderString2 = unsortedFloat[j];
                    for (var m = 0; m < N; m++)
                    {
                        if (tenderString1 == sortedFloat[m])
                            break;

                        if (tenderString2 == sortedFloat[m])
                        {
                            count++;
                            break;
                        }
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}