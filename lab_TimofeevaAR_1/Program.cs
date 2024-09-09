using System;

/*
Лабораторная работа №1, вариант 21.
Введите с клавиатуры вещественные числа x, у, z из области допустимых значений исходных данных. 
Для преобразования к числовой форме используйте класс Convert и метод Parse. 
Вычислите а, b в соответствии с Вашим вариантом. 
Результаты выведите на экран с использованием формата, шаблонов и управляющих символов
*/

namespace TimofeevaAR1
{
    class Program
    {
        static void Main()
        {
            /////
            //Console.SetWindowSize(40, 90);
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            

            Console.WriteLine();

            /////
            Console.WriteLine("Введите вещественное число x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вещественное число y: ");
            string buf = Console.ReadLine();
            double y = double.Parse(buf);
            //double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вещественное число z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            /////
            if (z > 1 || z < 1)
            {

                Console.WriteLine("Вычисление значений а и b: ");
                double a = ((Math.PI * Math.Pow(x, 2)) - 3.1) * (Math.Cos(z) + 0.9 - (Math.Sin(x + y) / (z - 1)));
                Console.WriteLine("a = {0:F3}", a); // формат вывода с 3  знаками после запятой

                double b = x * y + (y * Math.Pow(z, 2)) / (Math.Sqrt(Math.Abs(x + y)));
                Console.WriteLine(string.Format("b = {0:F3}", b)); // с форматом
            }
            else
            {
                Console.WriteLine($"Вы ввели недопустимое значение для z. \nДеление на 0 невозможно!"); //управляющие символы \n, \t и интерполяция $
            }
            /////
            Console.ReadKey();
            Console.Clear();
        }
    }
}