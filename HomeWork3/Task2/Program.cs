// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] a = new int[3];
int[] b = new int[3];
double result;
for (int i = 0; i < 3; i++)
{
    a[i] = new Random().Next(-99, 100);

    b[i] = new Random().Next(-99, 100);
}
result = DistanceBetweenPoints(a, b);
Console.WriteLine(
    $"Расстояние между точкой A({a[0]},{a[1]},{a[2]}) и B({b[0]},{b[1]},{b[2]}) равно {result}"
);

double DistanceBetweenPoints(int[] point1, int[] point2)
{
    double sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum = sum + Math.Pow((point2[i] - point1[i]), 2);
    }
    return Math.Sqrt(sum);
}
