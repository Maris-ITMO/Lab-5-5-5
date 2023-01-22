using System;

namespace Lab_5_Тема_5_СамРаб_Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность N");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = (i + j) % 2 == 0 ? 1 : 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
