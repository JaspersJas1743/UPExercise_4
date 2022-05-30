using System;
using System.Collections.Generic;
using System.Linq;

namespace Задание__4
{
    internal class Math
    {
        public static int Sum(int x, int y) => x + y;
    }

    internal class Program
    {
        delegate void Printer();
        delegate int Operation(int x, int y);

        public static void printMorning() => Console.WriteLine("Утро");
        public static void printAfternoon() => Console.WriteLine("День");
        public static void printEvening() => Console.WriteLine("Вечер");
        public static void printNight() => Console.WriteLine("Ночь");

        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;

        public static void Main(string[] args)
        {
            Console.WriteLine("1. Cоздание делегата и добавление в него метода в щависимости от времени суток: ");
            int hour = DateTime.Now.Hour;
            Printer printer = Enumerable.Range(4, 8).Contains(hour) ? printMorning : (Enumerable.Range(12, 4).Contains(hour) ? printAfternoon : (Enumerable.Range(16, 8).Contains(hour) ? printEvening : printNight));
            printer();
            Console.WriteLine("\n2. Переопределние делега:\nДелегат \"op\" указывает на метод Add\nOperation op = Add;\nConsole.WriteLine($\"Результат: {op(4, 5)}\");");
            Operation op = Add;
            Console.WriteLine($"Результат: {op(4, 5)}\n");
            Console.WriteLine("Теперь делегат \"op\" указывает на метод Multiply\nop = Multiply;\nConsole.WriteLine($\"Результат: {Multiply(4, 5)}\");");
            op = Multiply;
            Console.WriteLine($"Результат: {op(4, 5)}\n\n3. Присваивание делегату метода из другого класса\nДелегату присваивается метод Sum из класса Math\nop = Math.Sum;\nConsole.WriteLine($\"Результат: {op(4, 5)}\");");
            op = Math.Sum;
            Console.WriteLine($"Результат: {op(10, 100)}");
        }
    }
}