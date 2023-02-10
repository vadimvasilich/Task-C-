/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);