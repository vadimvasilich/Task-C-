/*Напишите программу, которая принимаетна вход число(N)
 и выдаёт таблицу квадратов чисел от 1 до  N
*/


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine("Не корректный ввод!");
else Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,4}      {count * count,4}");
        count++;
    }
}
