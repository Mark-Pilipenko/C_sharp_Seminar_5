int len = 123;
int min = -100;
int max = 100;

int minInt = 10;
int maxInt = 99;

int[] rand = FillArray(len, min, max);
PrintArray(rand);
Console.WriteLine($"Количество чисел лежащих на отрезке [{minInt};{maxInt}] равно {CountNumbers(rand, minInt, maxInt)}");

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

int CountNumbers(int[] array, int min, int max)
{
    int n = array.Length;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] >= min && array[i] <= max) count += 1;
    }
    return count;
}