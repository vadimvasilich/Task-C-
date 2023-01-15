/*Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Максимальное число: {numberA}");
    Console.WriteLine($"Минимальное число: {numberB}");
}
else 
{
    Console.WriteLine($"Максимальное число: {numberB}");
    Console.WriteLine($"Минимальное число: {numberA}");
}