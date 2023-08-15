// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

try
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 < number2)
    {
        int sum = FindSum(number1, number2);
        Console.WriteLine($"M = {number1};  N = {number2} -> {sum}");
    }
    else { Console.WriteLine("Задан неверный диапазон!"); }
}
catch
{
    Console.WriteLine("Введено некорректное значение!");
}

int FindSum(int num1, int num2)
{
    int sum = 0;
    if (num2 == num1) return num2 + sum;
    else return sum = num2 + FindSum(num1, num2 - 1);
}


