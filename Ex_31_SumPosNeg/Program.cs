// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.Write("Введите длину массива: ");
// int len = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int max = Convert.ToInt32(Console.ReadLine());

int len = 12;
int min = -9;
int max = 9;

int[] rand = FillArray(len, min, max);
PrintArray(rand);
Console.WriteLine($"Сумма положительных чисел равна {PositiveSum(rand)}");
Console.WriteLine($"Сумма отрицательных чисел равна {NegativeSum(rand)}");

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

int PositiveSum(int[] array)
{
    int n = array.Length;
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0) sum = sum + array[i];
    }
    return sum;
}

int NegativeSum(int[] array)
{
    int n = array.Length;
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] < 0) sum = sum + array[i];
    }
    return sum;
}