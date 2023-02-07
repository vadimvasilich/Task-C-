/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
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

// Преобразовываем двумерный в одномерный

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}

// Считаем кол-во одинаковых символов

void FrequencyDictionary(int[] arr)
{
    int temp = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (temp == arr[i]) count++;
        else
        {
            Console.WriteLine($"{temp} - {count}");
            temp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp} - {count}");
}

int[,] createMatrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(createMatrix);

int[] array = MatrixToArray(createMatrix);
Array.Sort(array);
Console.WriteLine();
FrequencyDictionary(array);