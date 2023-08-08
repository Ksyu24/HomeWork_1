// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int [,] array = new int[3,4];
FillArray(array);
PrintArray(array);

int pozM=0;
int pozN=0;
Console.WriteLine("Введите позицию: ");
	try {
		string[] poz=Console.ReadLine().Split(',');
		pozM=int.Parse(poz[0]);
		pozN=int.Parse(poz[1]);
	}
	catch {
		Console.WriteLine("Некорректный ввод");
	}

IsInArray(array, pozM, pozN);

void FillArray(int[,] arr)
{
	Random rnd=new Random();
	for (int i=0; i<arr.GetLength(0); i++)
	{
		for (int j=0; j<arr.GetLength(1); j++)
		{
			arr[i,j]=rnd.Next(0, 10);
		}
	}

}

void PrintArray(int[,] arr)
{
	
	for(int i=0; i<arr.GetLength(0); i++)
	{
		for(int j=0; j<arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i,j]}\t");
		}
		Console.WriteLine();
	}
}



void IsInArray(int[,] arr, int pozM, int pozN)
{
	try {
		if(pozM<arr.GetLength(0)&&pozN<arr.GetLength(1))
		{
			Console.WriteLine($"{pozM},{pozN} -> {arr[pozM,pozN]}");
		}
		else {Console.WriteLine($"{pozM},{pozN} -> такого элемента в массиве нет");}
	}
	catch {
		Console.WriteLine("Произошла ошибка. Не удалось обнаружить позицию");
	}
}
