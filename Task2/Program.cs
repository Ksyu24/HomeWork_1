// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());

double max=a;

if (max<b)
{
    max=b;
}

if (max<c)
{
    max=c;
}

Console.WriteLine($"Максимальное из трёх чисел: {max}");