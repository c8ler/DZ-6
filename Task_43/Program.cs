/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Задайте b1 для 1-й прямой: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Задайте k1 для 1-й прямой: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Задайте b2 для 2-й прямой: ");
    double b2 = double.Parse(Console.ReadLine());
    Console.Write("Задайте k2 для 2-й прямой: ");
    double k2 = double.Parse(Console.ReadLine());

    double xResult = FindX(b1, k1, b2, k2);
    double yResult = FindY(b1, k1, b2, k2);

    if (Proverka(b1, k1, b2, k2)) 
    {
        Console.WriteLine($"Координаты пересечения прямых ({Math.Round(xResult, 2)}; {Math.Round(yResult, 2)}).");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются.");
    }
    
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

bool Proverka(double b11, double k11, double b22, double k22)
{
    bool peresechenie = true;
    if (b11 == b22) peresechenie = false;
    return peresechenie;
}
double FindX(double b11, double k11, double b22, double k22)
{
    double x = (b11 - b22) / (k22 - k11);
    return x;
}
double FindY(double b11, double k11, double b22, double k22)
{
    double y = k11 * ((b11 - b22) / (k22 - k11)) + b11;
    return y;
}