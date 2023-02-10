/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6
*/

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);
}

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);