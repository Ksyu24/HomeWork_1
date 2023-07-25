// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
FillingArray(array);
Console.WriteLine(OutputArray(array) + "  ->  " + FindSumElementsInOddPos(array));

void FillingArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-999, 1000);
    }
}

string OutputArray(int[] arr)
{
    string result = "[" + arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        result = result + $", {arr[i]}";
    }
    result = result + "]";
    return result;
}

int FindSumElementsInOddPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    }

    return sum;
}
