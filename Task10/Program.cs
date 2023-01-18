/*Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/

int SecondDigit(int number)
{
    return number % 100 / 10;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number < 1000 && number > 99 ) Console.WriteLine(SecondDigit(number));
else  Console.Write("Это число не трёхзначное!!!");

