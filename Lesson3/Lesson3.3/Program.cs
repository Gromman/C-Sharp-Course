using System;
using System.IO;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            CountsNumberOfSpaces("Hello, my friend");

            string str = "Haw are you?";
            string searchWord = "you";
            SearchWordInString(str, searchWord);

            string path = "D:/Test1";
            LargestFileInFolder(path);

            ListOfFolderPaths(new string[] { "D:/Test1", "D:/Test2", "D:/Test3" });



        }

        static void CountsNumberOfSpaces(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c==' ')
                {
                    count++;
                } 
            }
            Console.WriteLine(count);
        }

        static bool SearchWordInString(string str, string searchWord)
        {
            bool b = str.Contains(searchWord);
            if (b)
            {
                int index = str.IndexOf(searchWord);
                if (index >= 0)
                    Console.WriteLine($"You word found - {searchWord} begins at character position {index + 1}");
                return true;
            }
            else
            {
                Console.WriteLine("Word not found");
                return false;
            }   
        }
        static FileInfo LargestFileInFolder(string path)
        {
            DirectoryInfo folderInfo = new DirectoryInfo(path);
            FileInfo[] files = folderInfo.GetFiles();

            long largestSize = 0;
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Length > largestSize)
                    largestSize = files[i].Length;
            }
            Console.WriteLine(largestSize);
            return files[files.Length - 1];
        }
        static string ListOfFolderPaths(string[] folderPaths)
        {
            foreach (var folder in folderPaths)
            {
                LargestFileInFolder(folder);

                    
            }

            return " ";
        }
    }
}

