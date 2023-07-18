// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    CreateTableCubes(num);
}
else
{
    Console.WriteLine("Введено неверное число");
}

void CreateTableCubes(int a)
{
    Console.WriteLine($"{a} ->");
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine($"{i, -5}|   {Math.Pow(i, 2)}");
    }
}
