/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

int RanNumber(int firstDigit, int thirdDigit)
{
    return firstDigit * 10 + thirdDigit;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine(RanNumber(firstDigit, thirdDigit));

/*
Вариант без метода

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit * 10 + thirdDigit;

Console.WriteLine(result);
*/