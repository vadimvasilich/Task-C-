// Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] NewRandomArray(int size,int min, int max)
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
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]}," );
        else  Console.Write(arr[i]);
    }
}

int [] array = NewRandomArray(8, 0, 20);

PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.WriteLine("]");