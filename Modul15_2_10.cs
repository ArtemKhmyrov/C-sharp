using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Student
    {
        public string Name;
        public int Data;
        public string Position;
        public int Salary;
        public int Experience;


        public Student(string name, int data, string position, int salary, int experience)
        {
            Name = name;
            Data = data;
            Position = position;
            Salary = salary;
            Experience = experience;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите должность: ");
            string position = Console.ReadLine();
            //источник данных – список студентов
            List<Student> list = new List<Student> { new Student("Иванов Петр сергеевич", 1999, "Программист", 34278, 22),
                                                     new Student("Петров Федор степанович", 2001, "Учитель", 79123, 19),
                                                     new Student("Сидоров Артем Михайлович", 2016, "Секретарь", 91292, 5),
                                                     new Student("Ткачев Денис Георгиевич", 2021, "Менеджер", 12712, 0),
                                                     new Student("Смирнов Василий Федорович", 1945, "Программист", 84301, 76),
                                                     new Student("Цукерман Цаца Цацилович", 1980, "Бухгалтер", 13284, 41)};
            //создаем запрос по номеру студента
            var students = from n in list
                           where n.Position == position
                           select n;
            //выполняем запрос
            foreach (var x in students)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", x.Name, x.Data, x.Position, x.Salary, x.Experience);
            }
        }
    }
}
