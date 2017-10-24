using System;

/*
Нам даны несколько пар значений, и нужно посчитать сумму каждой пары.
Входные данные содержат в первой строке N - общее количество пар, которые нужно посчитать.
Последующие N строк содержат по одной паре целых чисел каждая.
Ответ должен содержать результаты, разделенные пробелами.

Пример:
входные данные:
3
100 8
15 245
1945 54

ответ:
108 260 1999
*/

namespace SumsInLoop
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество пар: ");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пары: ");
            int[,] values = new int[amt, 2];

            // Считываем строки (пары) с консоли
            for (int i = 0; i < amt; i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(' ');
                for (int j = 0; j < massiveString.Length; j++)
                {
                    values[i, j] = int.Parse(massiveString[j]);
                }
            }

            // Считаем сумму каждой пары
            int sum = 0;
            for (int i = 0; i < amt; i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    sum = values[i, 0] + values[i, 1];
                }
                Console.Write("{0} ", sum);
            }

            Console.ReadKey();
        }
    }
}
