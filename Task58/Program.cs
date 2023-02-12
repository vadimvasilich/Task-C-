/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateRndMatrixInt(int rows, int columns, int min, int max)
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
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] MultTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                multMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multMatrix;
}

int[,] matr1 = CreateRndMatrixInt(3, 2, 0, 10);
int[,] matr2 = CreateRndMatrixInt(2, 2, 0, 10);
Console.WriteLine("Матрица 1: ");
PrintMatrix(matr1);
Console.WriteLine("Матрица 2: ");
PrintMatrix(matr2);

if (matr1.GetLength(1) != matr2.GetLength(0)) 
    Console.WriteLine("Эти матрицы нельзя перемножить.");
else
{
    int[,] multTwoMatr = MultTwoMatrix(matr1, matr2);
    Console.WriteLine("Результат произведения матриц:");
    PrintMatrix(multTwoMatr);
}