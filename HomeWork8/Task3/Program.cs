// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
FillingArray(array1);
FillingArray(array2);

Console.WriteLine("Первая матрица (умножаемое):");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица (множитель):");
PrintArray(array2);
Console.WriteLine();

if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] array = MultiplieArray(array1, array2);
    Console.WriteLine("Результирующая матрица (произведение):");
    PrintArray(array);
}
else { Console.WriteLine("Невозможно найти произведение данных матриц, из-за их размерности!"); }



void FillingArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-9, 10);
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

int[,] MultiplieArray(int[,] arr1, int[,] arr2)
{
    int[,] arr = new int[arr2.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = FindElMas(arr1, arr2, i, j);
        }
    }
    return arr;
}

int FindElMas(int[,] arr1, int[,] arr2, int pozM, int pozN)
{
    int sum = 0;
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        sum = sum + (arr1[pozM, j] * arr2[j, pozN]);

    }
    return sum;
}