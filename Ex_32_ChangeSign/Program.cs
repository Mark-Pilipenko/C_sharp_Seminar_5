// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] rand = FillArray(len, min, max);
PrintArray(rand);
Console.WriteLine("Новый массив:");
int[] randNew = ChangeSign(rand);
PrintArray(randNew);

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

int[] ChangeSign(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        array[i] = - array[i];
    }
    return array;
}