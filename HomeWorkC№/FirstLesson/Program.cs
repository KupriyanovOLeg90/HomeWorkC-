using System;
using FirstLesson.Classes;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle(10,20);
            Console.WriteLine($"Площадь: {rectangle.Area()}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter()}");


            rectangle.Add(5,7);
            Console.WriteLine("Прибавил значения");
            Console.WriteLine($"Площадь: {rectangle.Area()}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter()}");

            Console.WriteLine("Новыйй прямоугольник");

            Rectangle rectangle2 = new Rectangle(35, 10);
            Console.WriteLine($"Площадь: {rectangle2.Area()}");
            Console.WriteLine($"Периметр: {rectangle2.Perimeter()}");


            rectangle2.Add(rectangle);
            Console.WriteLine("добавил первый прямоугольник ко второму");
            Console.WriteLine($"Площадь: {rectangle2.Area()}");
            Console.WriteLine($"Периметр: {rectangle2.Perimeter()}");

            var sumRectangle = rectangle + rectangle2;
            Console.WriteLine("Сложил прямоугольники оператором");
            Console.WriteLine($"Площадь: {sumRectangle.Area()}");
            Console.WriteLine($"Периметр: {sumRectangle.Perimeter()}");


            Console.WriteLine($"Длина: {sumRectangle["length"]} ");
            Console.WriteLine($"Высота: {sumRectangle["height"]}");


            Console.WriteLine(sumRectangle.Description());


            Console.WriteLine();

            Console.WriteLine($"казак = {"казак".IsPalindrome()}");
            Console.WriteLine($"казаки = {"казаки".IsPalindrome()}");

            Console.ReadKey();
        }
    }
}
