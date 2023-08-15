// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
try
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        Console.Write($"N = {number} -> ");
        PrintNum(number);
    }
    else { Console.WriteLine("Введено ненатуральное число!"); }
}
catch
{
    Console.WriteLine("Введено некорректное значение!");
}

void PrintNum(int num)
{
    if (num == 0) return;
    PrintNum(num - 1);
    Console.Write($"{num}  ");
}


