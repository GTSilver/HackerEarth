using System;
using System.Text;

namespace Massive_Turner_1D
{
    class Program
    {
        static void Main()
        {
            int input1 = int.Parse(Console.ReadLine());
            for (var j = 0; j < input1; j++)
            {
                string[] input2 = Console.ReadLine().Split(' ');
                int N = int.Parse(input2[0]);
                int K = int.Parse(input2[1]);

                StringBuilder input3 = new StringBuilder(512);
                input3.Append(Console.ReadLine());

                var switcher = 0;
                var length = input3.Length;

                var separateCount = K;
                var index = 0;
                if (K >= N) separateCount = K - N * (int)Math.Floor(K / N * 1.0);

                if (separateCount <= N / 2)
                {
                    index = length - 1;
                    while (switcher < separateCount)
                    {
                        if (input3[index] == ' ')
                        {
                            switcher++;
                            index--;
                        }
                        else
                            index--;
                    }
                    index += 2;
                }
                else
                {
                    index = 0;
                    var deltha = N - separateCount;
                    while (switcher < deltha)
                    {
                        if (input3[index] == ' ')
                        {
                            switcher++;
                            index++;
                        }
                        else
                            index++;
                    }
                }

                var subIndex = index;
                StringBuilder subString = new StringBuilder(512);
                for (var i = 0; subIndex < length; i++)
                {
                    subString.Append(input3[subIndex]);
                    subIndex++;
                }

                if (subString.Length > 0) subString.Append(' ');
                input3.Remove(index - 1, length - index + 1);
                input3.Insert(0, subString);

                Console.WriteLine(input3);

                {//int T = int.Parse(Console.ReadLine());
                 //for (var j = 0; j < T; j++)
                 //{
                 //    string[] Q = Console.ReadLine().Split(' ');
                 //    int N = int.Parse(Q[0]);
                 //    int K = int.Parse(Q[1]);

                 //    string[] A = Console.ReadLine().Split(' ');
                 //    int B = 0;
                 //    int l = A.Length;

                 //    for (var i = 0; i < l; i++)
                 //    {
                 //        B = i + l - K;
                 //        if (B < 0) B = B + l * (int)Math.Floor(Math.Abs(B) / l * 1.0 + 1);
                 //        if (B >= l) B = B - l * (int)Math.Floor(B / l * 1.0);
                 //        Console.Write(A[B] + " ");
                 //    }
                 //    Console.Write("\r\n");
                }
            }
        }
    }
}