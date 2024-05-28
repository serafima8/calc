using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        enum Cal
        {
            Сложение, Вычитание, Деление, Умножение
        }


        static void Main(string[] args)
        {

            Console.WriteLine($"Ввеите значение переменной A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите значение переменной B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("0 - Сложение:");
                Console.WriteLine("1 - Вычитание:");
                Console.WriteLine("2 - Деление:");
                Console.WriteLine("3 - Умножение:");

                int cal = int.Parse(Console.ReadLine());
                switch ((Cal)cal)
                {

                    case Cal.Сложение:
                        Console.WriteLine($"Рельтат сложенпия равен: {a + b}");
                        break;
                    case Cal.Вычитание:
                        Console.WriteLine($"Рельтат вычитания равен: {a - b}");
                        break;
                    case Cal.Деление:
                        Console.WriteLine($"Рельтат деления равен: {a / b}");
                        break;
                    case Cal.Умножение:
                        Console.WriteLine($"Рельтат умножения равен: {a * b}");
                        break;
                    default:
                        Console.WriteLine("Попробуйте еще раз");
                        break;

                }

                Console.ReadKey();







            }
        }
    }
}
