/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementsRow(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
            arr[i] = sum;
        }
    }
    return arr;
}

int FindNumberRow(int[] array)
{
    int minElem = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();

int[] sumRow = SumElementsRow(matrix);
int numberRow = FindNumberRow(sumRow);

Console.WriteLine($"{numberRow + 1} строка с наименьшей суммой элементов");
