using System;

namespace variables_and_data_types
{
    internal class Task_1
    {
        // Задача:
        // Вывести на консоль текст - Введите первое число
        // Считать число с консоли и присвоить в переменную типа string
        // Преобразовать предыдущую переменную типа string в новую переменную типа int
        // Вывести значение переменной на консоль в виде - Ваше первое число <число>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string firstNumberAsString = Console.ReadLine();
            int firstNumber = int.Parse(firstNumberAsString);
            Console.WriteLine($"Ваше первое число {firstNumber}");
        }
    }
}
