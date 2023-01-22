//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool HoliDay(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1 && number < 7) Console.Write(HoliDay(number) ? "да" : "нет");
else Console.Write("Вы ввели неправильное число!!!");