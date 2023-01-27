// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int powNumber = Convert.ToInt32(Console.ReadLine());
double result = 1;

if (powNumber > 0)
{
    for (int i = 1; i <= powNumber; i++)
    {
        result = Math.Pow(number, i);
    }
Console.WriteLine(result);
}