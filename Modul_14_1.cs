#region using

using System;
using System.IO;

#endregion

namespace ConsoleApp3
{
    struct Student : IComparable
    {
        string Name;
        int Birthday;
        public static int School;
        string Adress;
        int NumberSchool;

        public Student(string Name, int Birthday, string Adress, int NumberSchool) : this()
        {
            this.Name = Name;
            this.Birthday = Birthday;
            this.Adress = Adress;
            this.NumberSchool = NumberSchool;
        }

        public bool checkshool()
        {
            if (NumberSchool == School)
                return true;

            else
                return false;
        }

        public int CompareTo(object obj)
        {
            Student person = (Student)obj;
            return this.Birthday.CompareTo(person.Birthday);
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}\n", Name, Birthday, Adress, NumberSchool);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[4];
            string[] fileData = new string[3];
            string[] fileData2 = new string[4];
            int i = 0;
            int newSize = 0;
            string data = string.Empty;
            StreamReader file = new StreamReader("input_for_14_pract.txt");
            while ((data = file.ReadLine()) != null)
            {
                string name = string.Empty;
                int ymd = 0;
                string adress = string.Empty;
                int school = 0;
                fileData = data.Split(", ".ToCharArray());

                name = fileData[0];
                ymd = Convert.ToInt32(fileData[2]);
                adress = fileData[4];
                school = Convert.ToInt32(fileData[6]);

                student[i] = new Student(name, ymd, adress, school);
                i++;
            }

            foreach (Student a in student)
            {
                Console.Write(a.ToString());
            }

            Console.WriteLine();

            Array.Sort(student);

            Student.School = 3;


            for (int j = 0; j < fileData2.Length; j++)
            {
                if (!student[j].checkshool())
                {
                    continue;
                }

                fileData2[j] = student[j].ToString();

                if (!(fileData2[j] == null))
                {
                    newSize++;
                }
            }

            for (int j = 0; j < fileData2.Length - 1; j++)
            {
                string temp;
                if (fileData2[j] == null)
                {
                    temp = fileData2[j + 1];
                    fileData2[j + 1] = fileData2[j];
                    fileData2[j] = temp;
                }
            }

            Array.Resize(ref fileData2, newSize);
            File.WriteAllLines("output.txt", fileData2);
        }
    }
}