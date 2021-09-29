using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            String s = Console.ReadLine();
            massage(s);
        }
        static char[] splitter = { ' ', '[', ']', '(', ')', '{', '}', '*', ',', '.', ';', ':', '\u2026', '#', '=' }; // это для разбиения на классы и на оссмысленные слова
        static void massage (String s)
        {
            Console.WriteLine(s);
            String[] words = s.Split(splitter);
            Object[,] array = new Object[2, words.Length];
            int min = 0;
            int max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                array[0, i] = words[i].Length; 
                array[1, i] = words[i];     
                if (words[i].Length < min)
                {
                    min = words[i].Length; 
                }
                if (words[i].Length > max)
                {
                    max = words[i].Length; 
                }
            }

            for (int j = min; j <= max; j++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if ((int)array[0, i] == j) 
                    {
                        Console.WriteLine("({0}) {1}", array[0, i], array[1, i]); 
                    }
                }
            }
        }
    }
}