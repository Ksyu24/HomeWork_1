// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int x=new Random().Next(100, 1000);
Console.WriteLine($"Вторая цифра числа {x} это {FindSecondNum(x)}");

int FindSecondNum(int num)
{
    int result = (num/10)%10;
    return result;
}


