/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.

А (3, 6); В (2, 1) -> 5,09
*/

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distanceRound}");


double Distance(int a1, int b1, int a2, int b2)
{
    return Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2-b1), 2));
}