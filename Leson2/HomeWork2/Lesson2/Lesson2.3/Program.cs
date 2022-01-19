using System;

namespace Lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            //6!
            //int[,] matrix = new int[3, 3];
            //int sum = 0;
            //Random rand = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrix[i, j] = rand.Next(1, 10);
            //        if (i == j)
            //        {
            //            sum += matrix[i, j];
            //        }
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //}
            //Console.WriteLine( );
            //Console.WriteLine(sum);

            //8
            int[] nums = new int[5];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);

                Console.Write($"{nums[i]} ");
            }

            //9!
            //int[] num = new int[5];
            //int temp = 0;

            //Random rand = new Random();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = rand.Next(1, 15);
            //    Console.WriteLine(num[i]);
            //}
            //Console.WriteLine( );
            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = 0; j < num.Length - 1; j++)
            //    {
            //        if (num[j] > num[j + 1])
            //        {
            //            temp = num[j + 1];
            //            num[j + 1] = num[j];
            //            num[j] = temp;
            //        }
            //    }

            //}

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i] + " ");
            //}

        }
    }
}
