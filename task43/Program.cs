// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

Console.WriteLine("Введите значения первого отрезка ");
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения второго отрезка ");
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);

double InterTwoLines(double x, double first, double second)
{
    double y = first * x + second;
    return y;
}

double y1 = InterTwoLines(x, k1, b1);
double y2 = InterTwoLines(x, k2, b2);

Console.WriteLine($"Точка пересечения -> ({Math.Round(y1,1)}; {Math.Round(y2,1)})");