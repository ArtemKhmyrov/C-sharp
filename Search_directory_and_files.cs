using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // для быстрого примера "C:\Users\ahmyr\OneDrive\Документы\Учеба\Графика С++" и "*docx"
            string directory = Console.ReadLine();
            string fileName = Console.ReadLine();

            foreach (string findedFile in Directory.EnumerateFiles(directory, fileName,
                SearchOption.AllDirectories))
            {
                FileInfo FI;
                try
                {
                    FI = new FileInfo(findedFile);
                    Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" +
                        " Создан: " + FI.CreationTime);
                }
                catch 
                {
                    continue;
                }

            }
        }
    }
}