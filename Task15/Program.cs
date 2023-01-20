//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool HoliDay(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
// ??? string number = Console.ReadLine();

bool result = HoliDay(number);

Console.Write(result ? "да" : "нет");

//if (number > 7) Console.Write("Вы ввели неправильное число!!!");