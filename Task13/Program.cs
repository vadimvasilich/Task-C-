/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99) Console.WriteLine($"Третья цифра -> {ThirdDigit(number)}");
else Console.Write("Третьей цифры нет!");