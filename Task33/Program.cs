// Задайте массив. 
//Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine("Укажите длину массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите число для поиска:");
int numberToFind = Convert.ToInt32(Console.ReadLine());
int[] arr = GenerateArray(sizeArray, 0, 10);
PrintArray(arr);

bool arrayNumb = FindNumber(arr, numberToFind);
Console.WriteLine(arrayNumb ? " -> да" : " -> нет");
