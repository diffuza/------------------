using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример возведения числа в несколько степеней
            byte l = 2, i = 0; // присвоение локальной переменной целого типа byte и объявление переменной i
            int result = 1;  // присвоение локальной переменной целого типа int

            while (i < 10) // применение цикла while и указание условия
            {
                i++; // указание условия
                result *= l; // вычисление значения локальной 
                Console.WriteLine("{0} в степени {1} равно {2}", l, i, result); // вывод на экран строки с вычисленными значеними указанных переменных
            }

            Console.ReadLine(); //чтение строк
        }
    }
}
