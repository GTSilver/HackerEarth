using System;
using System.Diagnostics;
using System.Text;

namespace Optimisation
{
    class Program
    {
        public static void stringBuilderArrayOne(string input, int length, int times)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (var t = 0; t < times; t++)
            {
                //StringBuilder как массив со сканированием от начало до конца
                StringBuilder A = new StringBuilder();
                A.Append(input);

                StringBuilder B = new StringBuilder();
                B.Append(input);

                int switcher = 1;
                int matches = 0;

                for (var i = 0; i < length; i++)
                {
                    switcher = 1;
                    B.Insert(0, B[length - 1]);
                    B.Remove(length, 1);
                    for (var j = 0; j < length; j++)
                    {
                        if (A[j] != B[j])
                        {
                            switcher = 0;
                            break;
                        }
                    }
                    if (switcher == 1)
                        matches++;
                }
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            string et1 = String.Format("{2:00},{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);
            Console.WriteLine(et1);
        }

        public static void stringBuilderArrayTwo(string input, int length, int times)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (var t = 0; t < times; t++)
            {
                //StringBuilder как массив с сканом от начала до середины и от конца до середины
                StringBuilder A = new StringBuilder();
                A.Append(input);

                StringBuilder B = new StringBuilder();
                B.Append(input);

                int switcher = 1;
                int matches = 0;
                int halfLength = length / 2 + 1;
                int indexLength = length - 1;


                for (var i = 0; i < length; i++)
                {
                    switcher = 1;
                    B.Insert(0, B[indexLength]);
                    B.Remove(length, 1);
                    for (var j = 0; j < halfLength; j++)
                    {
                        if (A[j] != B[j])
                        {
                            switcher = 0;
                            break;
                        }

                        if (A[indexLength - j] != B[indexLength - j])
                        {
                            switcher = 0;
                            break;
                        }
                    }
                    if (switcher == 1)
                        matches++;
                }
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            string et1 = String.Format("{2:00},{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);
            Console.WriteLine(et1);
        }

        public static void stringBuilderEquals(string input, int length, int times)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (var t = 0; t < times; t++)
            {
                //StringBuilder сравнение методом Equals
                StringBuilder A = new StringBuilder();
                A.Append(input);

                StringBuilder B = new StringBuilder();
                B.Append(input);

                int matches = 0;

                for (var i = 0; i < length; i++)
                {
                    B.Insert(0, B[length - 1]);
                    B.Remove(length, 1);
                    A.Capacity = B.Capacity;
                    if (A.Equals(B))
                        matches++;
                }
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            string et1 = String.Format("{2:00},{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);
            Console.WriteLine(et1);
        }

        public static void stringSelf(string input, int length, int times)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (var t = 0; t < times; t++)
            {
                //Проверка строки со сканом от начала до конца

                int switcher = 1;
                int matches = 0;
                int indexLength = length - 1;
                int shiftedIndex = 0;

                for (var i = 0; i < length; i++)
                {
                    switcher = 1;
                    for (var j = 0; j < length; j++)
                    {
                        shiftedIndex = j + i + 1;
                        if (shiftedIndex > indexLength)
                            shiftedIndex -= indexLength + 1;

                        if (input[j] != input[shiftedIndex])
                        {
                            switcher = 0;
                            break;
                        }
                    }
                    if (switcher == 1)
                        matches++;
                }
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            string et1 = String.Format("{2:00},{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);
            Console.WriteLine(et1);
        }

        public static void stringBuilderSelf(string input, int length, int times)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (var t = 0; t < times; t++)
            {
                //Проверка строки в StringBuilder со сканом от начала до конца

                StringBuilder A = new StringBuilder();
                A.Append(input);

                int switcher = 1;
                int matches = 0;
                int indexLength = length - 1;
                int shiftedIndex = 0;

                for (var i = 0; i < length; i++)
                {
                    switcher = 1;
                    for (var j = 0; j < length; j++)
                    {
                        shiftedIndex = j + i + 1;
                        if (shiftedIndex > indexLength)
                            shiftedIndex -= indexLength + 1;

                        if (A[j] != A[shiftedIndex])
                        {
                            switcher = 0;
                            break;
                        }
                    }
                    if (switcher == 1)
                        matches++;
                }
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            string et1 = String.Format("{2:00},{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);
            Console.WriteLine(et1);
        }

        public static void charArraySelf(string input, int length, int times)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (var t = 0; t < times; t++)
            {
                //Конвертация в массив символов со сканом от начала до конца
                char[] array = input.ToCharArray();

                int switcher = 1;
                int matches = 0;
                int indexLength = length - 1;
                int shiftedIndex = 0;

                for (var i = 0; i < length; i++)
                {
                    switcher = 1;
                    for (var j = 0; j < length; j++)
                    {
                        shiftedIndex = j + i + 1;
                        if (shiftedIndex > indexLength)
                            shiftedIndex -= indexLength + 1;

                        if (array[j] != array[shiftedIndex])
                        {
                            switcher = 0;
                            break;
                        }
                    }
                    if (switcher == 1)
                        matches++;
                }
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            string et1 = String.Format("{2:00},{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);
            Console.WriteLine(et1);
        }

        static void Main()
        {
            string input = "1010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010";
            int length = input.Length;
            int times = 65536;
            int tests = 11;

            Console.ReadLine(); Console.Clear();

            Console.WriteLine("Тест 1: Два массива StringBuilder сравнивается с одной стороны");
            for (var t = 0; t < tests; t++)
                stringBuilderArrayOne(input, length, times);

            Console.WriteLine();

            Console.WriteLine("Тест 2: Два массива StringBuilder сравнивается с двух сторон");
            for (var t = 0; t < tests; t++)
                stringBuilderArrayTwo(input, length, times);

            Console.WriteLine();

            Console.WriteLine("Тест 3: Два массива StringBuilder сравниваются через метод Equals");
            for (var t = 0; t < tests; t++)
                stringBuilderEquals(input, length, times);

            Console.WriteLine();

            Console.WriteLine("Тест 4: String проверяет сам себя через сдвинутый индекс с одной стороны");
            for (var t = 0; t < tests; t++)
                stringSelf(input, length, times);

            Console.WriteLine();

            Console.WriteLine("Тест 5: StringBuilder проверяет сам себя через сдвинутый индекс с одной стороны");
            for (var t = 0; t < tests; t++)
                stringBuilderSelf(input, length, times);

            Console.WriteLine();

            Console.WriteLine("Тест 6: Массив символов проверяет сам себя через сдвинутый индекс с одной стороны");
            for (var t = 0; t < tests; t++)
                charArraySelf(input, length, times);

            Console.ReadLine();
        }
    }
}