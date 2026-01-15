using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше имя:");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");

        Console.WriteLine($"Сегодня: {DateTime.Now.ToString("dd.MM.yyyy")}");
        Console.WriteLine($"День недели: {DateTime.Now.DayOfWeek}");

        Console.Write("Хотите продолжить? (y/n): ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "y")
        {
            Console.WriteLine("Продолжаем работу...");
        }
        else
        {
            Console.WriteLine("Завершение работы.");
        }
    }
}