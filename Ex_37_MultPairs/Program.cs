Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] rand = FillArray(len, min, max);
PrintArray(rand);
int[] mult = MultPairs(rand);
PrintArray(mult);

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

int[] MultPairs (int[] array)
{
    int n = array.Length;
    int nn = n / 2;
    if (n % 2 != 0) nn += 1;
    int[] mult = new int[nn];
    for (int i = 0; i < n / 2; i++)
    {
        mult[i] = array[i] * array[n-i-1];
    }
    if (n % 2 != 0) mult[nn-1] = array[n / 2];
    return mult;
}