// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] rand = FillArray(len, min, max);
PrintArray(rand);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (FindNumber(rand, number)) Console.WriteLine($"Число {number} присутствует в этом массиве");
else Console.WriteLine($"Число {number} не присутствует в этом массиве");


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

bool FindNumber(int[] array, int a)
{
    int n = array.Length;
    bool inc = false;
    for (int i = 0; i < n; i++)
    {
        if (array[i] == a) 
        {
            inc = true;
            break;
        }
    }
    return inc;
}