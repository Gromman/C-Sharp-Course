using System;

namespace Lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //4
            int[] num = new int[7];
            int[] num2 = new int[7];
            int len = num.Length;
            int mid = len / 2;

            Random rand = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(1, 15);
            }
            for (int j = 0; j < mid; j++)
            {
                num2[j] = num[j];
                num[j] = num[len - j - 1];
                num[len - j - 1] = num2[j];
            }
            foreach (int k in num)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
            foreach (int l in num2)
            {
                Console.Write($"{l} ");
            }


            //4 
            int[] num = new int[7];
            int[] num2 = new int[7];
            int temp = 0;

            Random rand = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(1, 15);
            }
            for (int j = num.Length - 1; j >= 0; j--)
            {
                num[j] = temp;
                num[j] = num2[j];
                temp = num[j];
            }
            foreach (int el in num)
            {
                Console.WriteLine(num[el]);
            }
            foreach (int el in num)
            {
                Console.WriteLine(num2[el]);
            }

            //5!
            int[,] matrix = new int[3, 5];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                    Console.Write(matrix[i, j] + " ");
                }
            }

            //6!
            int spaces = Convert.ToInt32(Console.ReadLine());
            int asterix = 1;
            int rang = spaces;
            for (int i = 0; i < rang; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < asterix; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
            }
        }
    }
}
