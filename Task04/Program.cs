/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;
if (number2 > maxNumber) {
    maxNumber = number2;
}
else if (number3 > maxNumber) {
    maxNumber = number3;
}
Console.WriteLine($"Максимальное число: {maxNumber}");
