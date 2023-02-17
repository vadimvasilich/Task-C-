/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));
}


Console.WriteLine("Введите натуральное число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ack(num1, num2);
Console.WriteLine($"A(m, n) = {functionAkkerman} ");
