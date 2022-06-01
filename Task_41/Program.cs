/* Задача 41. Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Введите массив чисел через пробелы: ");
    double[] arrayM = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    double result = FindPositive(arrayM);
    Console.WriteLine($"Количество положительных чисел в массиве = {result}");
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

double FindPositive(double[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res++;
    }
    return res;
}