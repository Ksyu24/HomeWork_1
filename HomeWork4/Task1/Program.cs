// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число, которое хотите возвести в степень");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите степень, в которое хотите возвести число");
int b = Convert.ToInt32(Console.ReadLine());

double res = RaisingNumberInDegree(a, b);

Console.WriteLine($"{a}, {b} -> {res}");

double RaisingNumberInDegree(double number, int degree)
{
    double result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
    }
    return result;
}
