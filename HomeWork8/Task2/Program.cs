// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 4];
FillingArray(array);
PrintArray(array);
Console.WriteLine($"{FindStringWithMinSum(array)} строка");

void FillingArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumArrayEllement(int[,] arr, int i)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    return sum;
}

int FindStringWithMinSum(int[,] arr)
{
    int strnum = -1;
    int minSum = SumArrayEllement(arr, 0);

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (minSum > SumArrayEllement(arr, i))
        {
            minSum = SumArrayEllement(arr, i);
        }
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (minSum == SumArrayEllement(arr, i))
        {
            strnum = i + 1;
        }
    }
    return strnum;
}

