/*Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

bool Multiple(int number)
{
    return ((number % 7 == 0) && (number % 23 == 0));
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(number);

if (result == true) Console.WriteLine("да");
else Console.WriteLine("нет");
