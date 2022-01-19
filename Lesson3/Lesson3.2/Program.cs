using System;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            RootsOfAnEquation(1.0, 4.0, 3.0);
            SumAndAverage(new double[] { 1.2, 1.5, 2 });
            ReadNumbers();

        }

        static bool RootsOfAnEquation(double a, double b, double c)
        {
            double x1;
            double x2;
            double D;

            D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($" x1= {x1}; x2={x2}");
                return true;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"x1= {x1}");
                return true;
            }
            else
            {
                Console.WriteLine("Error");
                return false;
            }
        }
        static void SumAndAverage(double[] arr)
        {
            double sum = 0;
            double average = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                Console.WriteLine($"{sum}");
            }
            average = sum / arr.Length;
            Console.WriteLine($"{average }");
        }

        static void ReadNumbers()
        {
            int[] arr = new int[1];

            Console.WriteLine("Exit enter `exit`");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            do
            {
                var str = Console.ReadLine();
                if (str == "exit")
                {
                    break;
                }
                int num = Convert.ToInt32(str);
                AddElementToArray(num, ref arr);
            }
            while (true);

            foreach(int el in arr)
            {
                Console.WriteLine($"{el}");
            }


        }
        static void AddElementToArray(int num, ref int [] arr)
        {
            int[] arrRezerv = new int[arr.Length + 1];
            for (int i=0;i<arr.Length;i++)
            {
                arrRezerv[i] = arr[i];
            }
            arrRezerv[arrRezerv.Length-1] = num;
            arr = arrRezerv;
        }

    }
}


