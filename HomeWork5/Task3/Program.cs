// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[10];
FillingArray(array);
double res = Convert.ToDouble(FindMaxInArray(array)) - Convert.ToDouble(FindMinInArray(array));
Console.WriteLine(
    OutputArray(array)
        + "  =>  "
        + FindMaxInArray(array)
        + " - "
        + FindMinInArray(array)
        + " = "
        + res
);

void FillingArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (1000 - (-999)) + (-999);
    }
}

string OutputArray(double[] arr)
{
    string result = "[" + arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        result = result + $", {arr[i]}";
    }
    result = result + "]";
    return result;
}

double FindMaxInArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }

    return max;
}

double FindMinInArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }

    return min;
}
