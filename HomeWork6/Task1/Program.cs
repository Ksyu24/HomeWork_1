// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов массива");
try
{
    int length = Convert.ToInt32(Console.ReadLine());
    if (length > 0)
    {
        int[] array = new int[length];
        FillingArray(array);
        Console.WriteLine(OutputArray(array) + "  ->  " + CountPositiveNumbers(array));
    }
    else
    {
        Console.WriteLine("Введено некорректное число");
    }
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}

void FillingArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        try
        {
            Console.WriteLine($"Введите {i + 1} число: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Введено некорректное значение");
        }
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

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
