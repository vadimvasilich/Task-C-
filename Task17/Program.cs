/* Напишите программу, которая принимает на вход координаты точек (х и у), причём (х не = 0 и у не = 0)
и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quater = Quater(x, y);
string result = quater > 0 ? $"Указанные координаты соответствуют четверти -> {quater}"
                           : "Введены не корректные координаты";
Console.WriteLine(result);

int Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}