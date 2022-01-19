using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
        //    WriteWord("Hello", 5);
        //    Console.WriteLine( );
        //    bool prime = PrimeNumber(7);
        //    Console.WriteLine(prime);
        //    Console.WriteLine( );
            ArrayCopy(new int[] {3,5,7});

        }
        static void WriteWord(string word, int count)
        {
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(word);
            }
        }

        static bool PrimeNumber(int number)
        {
            int count = 0;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
                return true;
            else
                return false;
        }

        static void ArrayCopy(int [] arr1)
        {
            int [] arr2 = new int[6];

            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine("Error");
            }
            else if (arr1.Length <= arr2.Length)
            {
                arr2 = new int[arr1.Length + 1];
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr2[i] = arr1[i];
                }
            }
            foreach (int el in arr2)
            {
                Console.WriteLine($"{el}");
            }

        }
    }
}
