// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше нуля ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int[] CreateArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum ++;
    }
    return sum;
}

Console.Write("Сколько чисел вы хотите посчитать?: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(number);
int sumNumbers = CountNumbers(arr);
Console.Write($"Чисел больше нуля: {sumNumbers}");