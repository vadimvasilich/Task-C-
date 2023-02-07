/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/



int BinaryNumber(int num)
{
    int res = 0;
    int count = 1;
    while ( num > 0)
    {
        res += num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return res;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int resalt = BinaryNumber(number);
if (number > 0) Console.WriteLine(resalt);
else Console.WriteLine("Ошибка ввода. Введите натуральное число");