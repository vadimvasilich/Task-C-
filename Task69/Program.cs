/* Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int RowNumber(int num1, int num2)
{
    return num2 == 0 ? 1 : num1 * RowNumber(num1, num2 - 1); 
    // как в предыдущей только с помощью тернарного оператора
}

Console.Write("Введите число :");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа :");
int number2 = Convert.ToInt32(Console.ReadLine());

int rowNumber = RowNumber(number1,number2);
Console.WriteLine(rowNumber);