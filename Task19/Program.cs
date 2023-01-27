// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrom(int num1, int num2, int num3, int num4)
{
    return num1 == num2 && num3 == num4;
}


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number % 100000 == number)
{
int firstDigit = number / 10000;
int lastDigit = number % 10;
int secondDigit = number / 1000 % 10;
int penultDigit = number / 10 % 10;
Console.Write(Palindrom(firstDigit, lastDigit, secondDigit, penultDigit) ? "Да" : "Нет");
}
else Console.WriteLine("Не правильный ввод!!!");