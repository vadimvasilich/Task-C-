/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void CreateMatrixSpiral(int[,] arr, int n)
{
    int i = 0;
    int j = 0;
    int temp = 1;
    for (int k = 0; k < n * n; k++)
    {
        int e = 0;
        do { arr[i, j++] = temp++; } while (++e < n - 1);
        for (e = 0; e < n - 1; e++) arr[i++, j] = temp++;
        for (e = 0; e < n - 1; e++) arr[i, j--] = temp++;
        for (e = 0; e < n - 1; e++) arr[i--, j] = temp++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int[4, 4];
CreateMatrixSpiral(matrix, 4);
PrintMatrix(matrix);