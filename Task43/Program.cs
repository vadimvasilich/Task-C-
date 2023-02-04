// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y=k1*x+b1, y=k2*x+b2,
// значения b1, k1, b2, k2 задаются пользователем.
//b1=2, k1=5, b2=4, k2=9 -> (-0,5; -0,5)

double PointXIntersection(int b1c, int k1c, int b2c, int k2c)
{
    double xc = default;
    xc = (double)(b2c - b1c) / (k1c - k2c);
    return xc;
}

double PointYIntersection(int b1c, int k1c, int b2c, int k2c)
{
    double yc = default;
    yc = (double)k1c * (b2c - b1c) / (k1c - k2c) + b1c;
    return yc;
}

Console.WriteLine("Введите 4 числа, описывающие прямые: ");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
double x = PointXIntersection(b1, k1, b2, k2);
double y = PointYIntersection(b1, k1, b2, k2);

if (k1 != k2 && b1 != b2) Console.Write($"({x}; {y})");
else Console.WriteLine("Ошибка: прямые параллельны или совпадают!");