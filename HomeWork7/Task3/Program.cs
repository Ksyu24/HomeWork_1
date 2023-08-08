// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
ResponseOutput(array);

void FillArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 100);
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

double FindArithmeticMeanElements(int[,] arr, int PozN)
{
    double arithMean;
    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == PozN)
            {
                sum = sum + arr[i, j];
            }
        }
    }
    arithMean = Convert.ToDouble(sum) / arr.GetLength(0);
    arithMean = Math.Round(arithMean, 2);
    return arithMean;
}

void ResponseOutput(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{FindArithmeticMeanElements(arr, j)}\t ");
    }
}
