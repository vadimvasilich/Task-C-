/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

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
int resalt = BinaryNumber(number);
Console.WriteLine(resalt);