/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");
}

// находим максимальный элемент массива
double MaxElementArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

// находим минимальный элемент массива
double MinElementArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

// находим разницу между максимальным и минимальным элементами массива
double Result(double maxNum, double minNum)
{
    return maxNum - minNum;
}

double[] arr = CreateArrayRndDouble(5, 0, 100);
double maxElem = MaxElementArray(arr);
double minElem = MinElementArray(arr);
double result = Math.Round(Result(maxElem, minElem), 1);

PrintArrayDouble(arr);
Console.WriteLine(result);