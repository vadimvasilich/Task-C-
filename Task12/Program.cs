// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Multiple(number1, number2);
if (result == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток {result}");


int Multiple(int number1, int number2)
{
    if(number1 % number2 == 0) return 0;
    return number1 % number2;
}
