using System;
using System.IO;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int res = -1 + (4 * 6);
            Console.WriteLine(res);
            double res2 = (35 + 5) % 7;
            Console.WriteLine(res2);
            //double res3 = 14.0 + ((-4.0 * 6.0 )/ 11.0);
            double res3 = 14 + ((-4 * 6) / 11);
            Console.WriteLine(res3);
            double res4 = 2 + ((15 / 6) * 1) - (7 % 2);
            Console.WriteLine(res4);
            Console.WriteLine();

            //2
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            Console.WriteLine(num1 + " " + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine();

            //3

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num}*{i}={result}");
            }
            Console.WriteLine();

            //4
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(first_last(str1));
            Console.WriteLine(first_last(str2));

            static string first_last(string ustr)
            {
                return ustr.Length > 1
                    ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            }
            Console.WriteLine();

            //5

            string str;
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
            Console.WriteLine();

            //6

            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double result2;

            if (a > b)
            {
                Console.WriteLine(result2 = (a - b) * 2);
            }
            else
            {
                Console.WriteLine(result2 = b - a);
            }
            Console.WriteLine();

            //7
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
            Console.WriteLine();

            //8
            int number = 7;
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {

                Console.Write(" simple number - " + number);
            }
            else
            {
                Console.Write("difficult number- " + number);
            }


            Console.WriteLine();

            //9

            string yourString = Console.ReadLine();
            string yourStringCorect = yourString.Trim();
            Console.WriteLine(yourStringCorect);
            Console.WriteLine();

            //10

            FileInfo f = new FileInfo("D:/myfile.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
            Console.WriteLine();

            //11

            string numberInРexadecimal = "4B0";
            Console.WriteLine("Hexadecimal number: " + numberInРexadecimal);
            int decValue = int.Parse(numberInРexadecimal, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimal number: " + decValue);
            Console.WriteLine();

            //12

            string yourWord = Console.ReadLine();
            Console.WriteLine((yourWord.Length < 6 && yourWord.Equals("Hello")) || (yourWord.StartsWith("Hello") && yourWord[5] == ' '));
            Console.WriteLine();

            //13

            string str3 = "PHP Tutorial";
            Console.WriteLine((str3.Substring(1, 2).Equals("HP") ? str3.Remove(1, 2) : str3));
            Console.WriteLine();

            //14

            var perent = Directory.GetParent("D:/New folder (2)/New folder/1.txt").Parent;
            Console.WriteLine(perent);
        }
    }
}
