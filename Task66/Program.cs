/* Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int SumNaturalNumbers(int numberM, int numberN)
{
    if (numberM == numberN + 1) return 0;
    if (numberM > numberN) return SumNaturalNumbers(numberN, numberM);
    return numberM += SumNaturalNumbers(numberM + 1, numberN);
}

Console.WriteLine("Введите два числа:");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());



if (numberM > 0 && numberN > 0) Console.WriteLine(SumNaturalNumbers(numberM, numberN));
else Console.WriteLine("Ошибка!!! Число не натуральное.");