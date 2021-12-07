using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApp2
{
    class DateClass
    {
        DateTime date;

        public DateClass(int year, int month, int day)
        {
            date = new DateTime(year, month, day);
        }
        
    public DateClass()
        {
            date = new DateTime(2021, 12, 8);
        }

        public DateTime PrevDay()
        {
            return date.AddDays(-1);
        }

        public DateTime NextDay()
        {
            return date.Add(TimeSpan.FromDays(1));
        }

        public int DaysLeft()
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }

        public DateTime Data
        {
            set { date = value; }
            get { return date; }
        }

        public bool IsLeap
        {
            get { return DateTime.IsLeapYear(date.Year); }
        }


        public DateTime this[int index] 
        {
            get
            {
                return date.AddDays(index);
            }
        }

        public static bool operator !(DateClass a)
        {
            return a.date.Day != DateTime.DaysInMonth(a.date.Year, a.date.Month);
        }

        public static bool operator true(DateClass a)
        {
            return a.date.Day == 1 && a.date.Month == 1;
        }

        public static bool operator false(DateClass a)
        {
            return a.date.Day != 1 || a.date.Month != 1;
        }

        public static bool operator &(DateClass a, DateClass b)
        {
            return a.date.Equals(b.date);
        }

        public static explicit operator String(DateClass obj)
        {
            return obj.date.Year + "." + obj.date.Month + "." + obj.date.Day;
        }
    }

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Текущая дата: " + DateTime.Now);

            DateClass newdate = new DateClass();

            Console.WriteLine("Заданная дата: {0}", (string)newdate);

            newdate = new DateClass(2010, 1, 01);

            Console.WriteLine("Изменить дату " + DateTime.Now + " на 2010, 1, 1: {0}", (string)newdate);

            Console.WriteLine("вычислить дату предыдущего дня: {0}", newdate.PrevDay());

            Console.WriteLine("вычислить дату следующего дня: {0}", newdate.NextDay());

            Console.WriteLine("определить сколько дней осталось до конца месяца {0}", newdate.DaysLeft());

            Console.WriteLine("Индексатор, позволяющий определить дату i-того по счету дня относительно установленной даты (при отрицательных значениях индекса отсчет ведется в обратном порядке).", newdate[10]);

            Console.WriteLine("позволяющее определить является ли год высокосным (доступно только для чтения) {0}", newdate.IsLeap);

            Console.WriteLine("операции !: возвращает значение true, если установленная дата не является последним днем месяца, иначе false; {0}", !newdate);

            Console.WriteLine("Проверка на перегрузку операций, с новым объектом");

            DateClass newdate1 = new DateClass(2021, 12, 17);

            Console.WriteLine("операции &: возвращает значение true, если поля двух объектов равны, иначе false. {0}", newdate1 & newdate);

         
        }
    }
}