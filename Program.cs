using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уровень 1 - Джун минус минус");
            Console.WriteLine("Задание 1");
            Console.Write("Введите первый член арифметической прогрессии: ");
            int a_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите разность прогрессии (шаг): ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество членов прогрессии: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = ((2 * a_1 + d * (n - 1)) / 2) * n;
            Console.WriteLine($"Sn = {sum}");
            Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.Write("Введите первую сторону треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение угла между ними: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            angle = angle * (Math.PI / 180);
            double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle));
            Console.WriteLine($"Третья сторона треугольника равна: {c}");
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            Console.Write("Введите шестизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int n1 = number % 10;
            int n2 = number % 100 / 10;
            int n3 = number % 1000 / 100;
            int n4 = number % 10000 / 1000;
            int n5 = number % 100000 / 10000;
            int n6 = number / 100000;
            if ((n1 + n2 + n3) == (n4 + n5 + n6))
            {
                Console.WriteLine($"Число {number} - счастливое");
            }
            else
            {
                Console.WriteLine($"Число {number} - не счастливое");
            }
            Console.WriteLine();

            Console.WriteLine("Уровень 2 - Джун");
            Console.WriteLine("Задание 1");
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2)
            {
                double num = num1;
                num1 = num2;
                num2 = num;
            }
            if (x < num1)
            {
                Console.WriteLine($"Число {x} лежит слева относительно промежутка [{num1}; {num2}]");
            }
            else if (x > num2)
            {
                Console.WriteLine($"Число {x} лежит справа относительно промежутка [{num1}; {num2}]");
            }
            else if (x > num1 && x < num2)
            {
                Console.WriteLine($"Число {x} лежит внутри промежутка [{num1}; {num2}]");
            }
            else if (x == num1 || x == num2)
            {
                Console.WriteLine($"Число {x} лежит на границе промежутка [{num1}; {num2}]");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.Write("Введите первую сторону треугольника: ");
            double t1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            double t2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            double t3 = Convert.ToDouble(Console.ReadLine());
            if (t1 <= t2 + t3 && t2 <= t1 + t3 && t3 <= t1 + t2)
            {
                Console.WriteLine($"Треугольник со сторонами {t1}, {t2} и {t3} существует");
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами {t1}, {t2} и {t3} не существует");
            }
            Console.WriteLine();

            Console.WriteLine("Уровень 3 - Джун плюс плюс");
            Console.WriteLine("Задание 1");
            Console.Write("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine()); 
            int count = 0;
            count += (m & (1 << 0)) >> 0;
            count += (m & (1 << 1)) >> 1;
            count += (m & (1 << 2)) >> 2;
            count += (m & (1 << 3)) >> 3;
            count += (m & (1 << 4)) >> 4;
            count += (m & (1 << 5)) >> 5;
            count += (m & (1 << 6)) >> 6;
            count += (m & (1 << 7)) >> 7;
            count += (m & (1 << 8)) >> 8;
            count += (m & (1 << 9)) >> 9;
            count += (m & (1 << 10)) >> 10;
            count += (m & (1 << 11)) >> 11;
            count += (m & (1 << 12)) >> 12;
            count += (m & (1 << 13)) >> 13;
            count += (m & (1 << 14)) >> 14;
            count += (m & (1 << 15)) >> 15;
            count += (m & (1 << 16)) >> 16;
            count += (m & (1 << 17)) >> 17;
            count += (m & (1 << 18)) >> 18;
            count += (m & (1 << 19)) >> 19;
            count += (m & (1 << 20)) >> 20;
            count += (m & (1 << 21)) >> 21;
            count += (m & (1 << 22)) >> 22;
            count += (m & (1 << 23)) >> 23;
            count += (m & (1 << 24)) >> 24;
            count += (m & (1 << 25)) >> 25;
            count += (m & (1 << 26)) >> 26;
            count += (m & (1 << 27)) >> 27;
            count += (m & (1 << 28)) >> 28;
            count += (m & (1 << 29)) >> 29;
            count += (m & (1 << 30)) >> 30;
            count += (m & (1 << 31)) >> 31;
            Console.WriteLine($"number {m} contains {count} bits");
            Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.Write("Введите целое неотрицательное число: ");
            int ind = Convert.ToInt32(Console.ReadLine());
            int degree = 1 << ind;
            Console.WriteLine($"2^{ind} = {degree}");
            Console.WriteLine();

        }
    }
}
