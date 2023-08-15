// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

try
{
    Console.WriteLine("Введите первое неотрицательное число (m): ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе неотрицательное число (n): ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 >= 0 && number2 >= 0)
    {
        int res = AckermanFunction(number1, number2);
        Console.WriteLine($"m = {number1},  n = {number2} -> A({number1},{number2}) = {res}");
    }
    else { Console.WriteLine("Числа должны быть неотрицательными!"); }
}
catch
{
    Console.WriteLine("Введено некорректное значение!");
}

int AckermanFunction(int m, int n)
{
    if (m == 0) return n = n + 1;
    else if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    else if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    else { Console.WriteLine("Ошибка!"); return 0; }
}