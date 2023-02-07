/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
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

int[,] ReplacingRowsColumns(int[,] matrix)
{
    int[,] mtx = new int[matrix.GetLength(0), matrix.GetLength(0)];
    if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Действие невозмжно");
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                mtx[j, i] = matrix[i, j];
            }
        }
    }
    return mtx;
}

bool IsSquareMatrix(int[,] matrix)
{
    return (matrix.GetLength(0) == matrix.GetLength(1));
}

int[,] matrix2 = CreateMatrixRndInt(4, 3, 0, 9);
PrintMatrix(matrix2);
if (IsSquareMatrix(matrix2))
{
    Console.WriteLine();
    int[,] replacingRowsColumns = ReplacingRowsColumns(matrix2);
    PrintMatrix(replacingRowsColumns);
}
else Console.WriteLine("Действие невозможно");