//Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}] ");
    }
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int[] array = GenerateArray(5, 0, 10);
int[] copyArr = CopyArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(copyArr);

/*
string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    return array;
}

int[] array = GenerateArray(6, 1, 9);
int[] copy = CopyArray(array);
Console.WriteLine($"{PrintArray(array)} -> {PrintArray(copy)}");
*/