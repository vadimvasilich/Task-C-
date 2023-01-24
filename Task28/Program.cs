// Напишите программу, которая
// 1.принимает на вход число N и 
// 2.выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int countNumbers = CountNumbers(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {countNumbers}");
}
else Console.WriteLine("Не правильный ввод!!!");

int CountNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}