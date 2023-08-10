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


bool IsRightFree(int[,] arr, int Posi, int Posj)
{
    bool isFree = false;
    if ((Posj + 1 < arr.GetLength(1)) && (arr[Posi, Posj] > arr[Posi, Posj + 1]) && (arr[Posi, Posj + 1] == 0))
    {
        isFree = true;
    }
    return isFree;
}

bool IsBottomFree(int[,] arr, int Posi, int Posj)
{
    bool isFree = false;
    if ((Posi + 1 < arr.GetLength(0)) && (arr[Posi, Posj] > arr[Posi + 1, Posj]) && (arr[Posi + 1, Posj] == 0))
    {
        isFree = true;
    }
    return isFree;
}

bool IsLeftFree(int[,] arr, int Posi, int Posj)
{
    bool isFree = false;
    if ((Posj - 1 > -1) && (arr[Posi, Posj] > arr[Posi, Posj - 1]) && (arr[Posi, Posj - 1] == 0))
    {
        isFree = true;
    }
    return isFree;
}

bool IsTopFree(int[,] arr, int Posi, int Posj)
{
    bool isFree = false;
    if ((Posi - 1 > -1) && (arr[Posi, Posj] > arr[Posi - 1, Posj]) && (arr[Posi - 1, Posj] == 0))
    {
        isFree = true;
    }
    return isFree;
}

void GoRight(int[,] arr, int Posi, int Posj)
{
    if (Posj + 1 < arr.GetLength(1))
    {
        arr[Posi, Posj + 1] = arr[Posi, Posj] + 1;
        if (IsRightFree(arr, Posi, Posj + 1))
        {
            GoRight(arr, Posi, Posj + 1);
        }
        else if (IsBottomFree(arr, Posi, Posj + 1))
        {
            GoBottom(arr, Posi, Posj + 1);
        }
    }
}
void GoBottom(int[,] arr, int Posi, int Posj)
{
    if (Posi + 1 < arr.GetLength(0))
    {
        arr[Posi + 1, Posj] = arr[Posi, Posj] + 1;
        if (IsBottomFree(arr, Posi + 1, Posj))
        {
            GoBottom(arr, Posi + 1, Posj);
        }
        else if (IsLeftFree(arr, Posi + 1, Posj))
        {
            GoLeft(arr, Posi + 1, Posj);
        }
    }
}
void GoLeft(int[,] arr, int Posi, int Posj)
{
    if (Posj - 1 > -1)
    {
        arr[Posi, Posj - 1] = arr[Posi, Posj] + 1;
        if (IsLeftFree(arr, Posi, Posj - 1))
        {
            GoLeft(arr, Posi, Posj - 1);
        }
        else if (IsTopFree(arr, Posi, Posj - 1))
        {
            GoTop(arr, Posi, Posj - 1);
        }
    }
}
void GoTop(int[,] arr, int Posi, int Posj)
{
    if (Posi - 1 > -1)
    {
        arr[Posi - 1, Posj] = arr[Posi, Posj] + 1;
        if (IsTopFree(arr, Posi - 1, Posj))
        {
            GoTop(arr, Posi - 1, Posj);
        }
        else if (IsRightFree(arr, Posi - 1, Posj))
        {
            GoRight(arr, Posi - 1, Posj);
        }
    }
}
