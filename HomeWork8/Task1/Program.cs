// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array = new int[3,3];
FillingArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Отсортированный массив:");
SortsInDescendingOrder(array);
PrintArray(array);

void FillingArray(int[,] arr)
{
	Random rnd=new Random();
	for(int i=0; i<arr.GetLength(0); i++)
	{
		for(int j=0; j<arr.GetLength(1); j++)
		{
			arr[i,j]=rnd.Next(10,100);
        }
    }
}

void PrintArray(int[,] arr)
{

    for (int i=0; i<arr.GetLength(0); i++)
	{
		for(int j=0; j<arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i,j]}\t");
		}
		Console.WriteLine();
	}
}

void SortsInDescendingOrder(int[,] arr)
{
	
	for(int i=0; i<arr.GetLength(0); i++)
	{
		while(!IsDescending(arr, i))
		{
			for(int j=0; j<arr.GetLength(1)-1; j++)
			{
				if(arr[i,j]<arr[i,j+1])
				{
					int el=arr[i,j];
					arr[i,j]=arr[i,j+1];
					arr[i,j+1]=el;
				}
			}
		}
			
	}
}


bool IsDescending(int[,] arr, int Posi)
{
	bool isDescending=true;
	for(int j=0; j<arr.GetLength(1)-1; j++)
	{
		if(arr[Posi,j]<arr[Posi,j+1])
		{
			isDescending=false;
			break;
		}	
	}
	return isDescending;
}
