// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

FillingArray(array);

PrintArray(array);



void FillingArray(int[,] arr)
{
    Random rnd = new Random();
    arr[0, 0] = rnd.Next(1, 85);
    if (IsRightFree(arr, 0, 0))
    {
        GoRight(arr, 0, 0);
    }
    else { Console.WriteLine("Не удалось заполнить массив"); }

}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:d2}\t");
        }
        Console.WriteLine();
    }
}


bool IsRightFree(int[,] arr, int Pozi, int Pozj)
{
    bool isFree = false;
    if ((Pozj + 1 < arr.GetLength(1)) && (arr[Pozi, Pozj] > arr[Pozi, Pozj + 1]) && (arr[Pozi, Pozj + 1] == 0))
    {
        isFree = true;
    }
    return isFree;
}

bool IsBottomFree(int[,] arr, int Pozi, int Pozj)
{
    bool isFree = false;
    if ((Pozi + 1 < arr.GetLength(0)) && (arr[Pozi, Pozj] > arr[Pozi + 1, Pozj]) && (arr[Pozi + 1, Pozj] == 0))
    {
        isFree = true;
    }
    return isFree;
}

bool IsLeftFree(int[,] arr, int Pozi, int Pozj)
{
    bool isFree = false;
    if ((Pozj - 1 > -1) && (arr[Pozi, Pozj] > arr[Pozi, Pozj - 1]) && (arr[Pozi, Pozj - 1] == 0))
    {
        isFree = true;
    }
    return isFree;
}

bool IsTopFree(int[,] arr, int Pozi, int Pozj)
{
    bool isFree = false;
    if ((Pozi - 1 > -1) && (arr[Pozi, Pozj] > arr[Pozi - 1, Pozj]) && (arr[Pozi - 1, Pozj] == 0))
    {
        isFree = true;
    }
    return isFree;
}

void GoRight(int[,] arr, int Pozi, int Pozj)
{
    if (Pozj + 1 < arr.GetLength(1))
    {
        arr[Pozi, Pozj + 1] = arr[Pozi, Pozj] + 1;
        if (IsRightFree(arr, Pozi, Pozj + 1))
        {
            GoRight(arr, Pozi, Pozj + 1);
        }
        else if (IsBottomFree(arr, Pozi, Pozj + 1))
        {
            GoBottom(arr, Pozi, Pozj + 1);
        }
    }
}
void GoBottom(int[,] arr, int Pozi, int Pozj)
{
    if (Pozi + 1 < arr.GetLength(0))
    {
        arr[Pozi + 1, Pozj] = arr[Pozi, Pozj] + 1;
        if (IsBottomFree(arr, Pozi + 1, Pozj))
        {
            GoBottom(arr, Pozi + 1, Pozj);
        }
        else if (IsLeftFree(arr, Pozi + 1, Pozj))
        {
            GoLeft(arr, Pozi + 1, Pozj);
        }
    }
}
void GoLeft(int[,] arr, int Pozi, int Pozj)
{
    if (Pozj - 1 > -1)
    {
        arr[Pozi, Pozj - 1] = arr[Pozi, Pozj] + 1;
        if (IsLeftFree(arr, Pozi, Pozj - 1))
        {
            GoLeft(arr, Pozi, Pozj - 1);
        }
        else if (IsTopFree(arr, Pozi, Pozj - 1))
        {
            GoTop(arr, Pozi, Pozj - 1);
        }
    }
}
void GoTop(int[,] arr, int Pozi, int Pozj)
{
    if (Pozi - 1 > -1)
    {
        arr[Pozi - 1, Pozj] = arr[Pozi, Pozj] + 1;
        if (IsTopFree(arr, Pozi - 1, Pozj))
        {
            GoTop(arr, Pozi - 1, Pozj);
        }
        else if (IsRightFree(arr, Pozi - 1, Pozj))
        {
            GoRight(arr, Pozi - 1, Pozj);
        }
    }
}
