using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1!
            int[] num = new int[10];
            double sum = 0.0;
            double average = 0.0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum += num[i];
                if (i == 9)
                {
                    average = sum / num.Length;
                    Console.WriteLine();
                    Console.WriteLine(sum + " " + average);
                }
            }

            //2
            int[] num = new int[10];
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    num[j] = j;
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }


            //3!
            int[] num = new int[12];
            int fak = 1;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;
                fak *= num[i];
            }
            Console.WriteLine(fak);
        }
    }
}
