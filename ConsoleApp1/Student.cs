using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Gender
    {
        Male, Female
    }

    class Student
    {
        public string FullName { get; set; }
        public int Year { get; set; }
        public Gender Gender { get; set; }
        public Student() { }

        public Student(string fullName, int year, Gender gender)
        {
            this.FullName = fullName;
            this.Year = year;
            this.Gender = gender;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ФИО:{FullName}\nГод рождения:{Year}\nПол:{Gender}");
        }

        public void Info(List<Student> students)
        {
            foreach(var elem in students)
            {
                elem.ShowInfo();
            }
        }

        static public Student Print()
        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пол: ");
            string s = Console.ReadLine();
            Gender gender = (Gender)Enum.Parse(typeof(Gender),s);
            return new Student(name, year, gender);
        }


        public void ShowInfoGender(List<Student> students)
        {
            Console.WriteLine("Мужчины");
            foreach (var elem in students)
            {
                if ("Male" == elem.Gender.ToString())
                {
                    elem.ShowInfo();
                }
            }

            Console.WriteLine("Девушки");
            foreach (var elem in students)
            {
                if ("Female" == elem.Gender.ToString())
                {
                    elem.ShowInfo();
                }
            }
        }













    }
}
