/* Напишите программу, которая заданному номеру четверти  показывает диапазон 
возможных координат точек в этой четверти (х, у)
*/

Console.WriteLine("Введите номер четверти координат: ");
string number = Console.ReadLine();

string quater = Quater(number);

Console.WriteLine($"Интервал координат: {quater}");

string Quater(string num)
{
    switch (num)
    {
    case "1": return "x > 0 и y > 0";
    case "2": return "x < 0 и y > 0";
    case "3": return "x < 0 и y < 0";
    case "4": return "x > 0 и y < 0";
    default: return "Ввод не корректен!";
    }
//     if (num == "1") return "x > 0 и y > 0";
//     if (num == "2") return "x < 0 и y > 0";
//     if (num == "3") return "x < 0 и y < 0";
//     if (num == "4") return "x > 0 и y < 0";
//     return "Ввод не корректен!";
}