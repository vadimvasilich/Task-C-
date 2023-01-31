/*32. Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/


int[] GenerateArray(int size, int min, int max)
{
    int[] arrayNumbers = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arrayNumbers[i] = rnd.Next(min, max + 1);
    }
    return arrayNumbers; 
}
// Через строку

// string PrintArray(int[] arr)
// {
//     string str = String.Empty;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         str += $"{arr[i]} ";
//     }
//     return str;
// }

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

void RevertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0) arr[i] = -arr[i];
    }
}

//int[] arrayNumbers = new int[12];
int[] arrayRnd = GenerateArray(12, -10, 10);
// GenerateArray(arrayNumbers, -10, 10);
// Console.WriteLine($"Сгенерированный массив: [{PrintArray(arrayNumbers)}]");
PrintArray(arrayRnd);
Console.Write(" -> ");
RevertArray(arrayRnd);
PrintArray(arrayRnd);
// Console.WriteLine($"Сгенерированный массив с заменой знака: [{PrintArray(arrayNumbers)}]");
