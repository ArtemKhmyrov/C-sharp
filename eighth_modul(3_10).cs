using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eighth_modul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы через пробел ");
            String s = Console.ReadLine();
            Console.WriteLine(s.Where(Char.IsDigit).Sum(Char.GetNumericValue)); // нашел в Интернете очень интересный метод возврата из стека, но он не все числа возвращает
        }
    }
}

