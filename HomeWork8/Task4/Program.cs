// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];
FillingArray(array);
Print(array);

void FillingArray(int[,,] arr)
{
	Random rnd = new Random();
	bool isUnik = false;
	int newElArr = rnd.Next(10, 100);
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int z = 0; z < arr.GetLength(2); z++)
			{
				while (!isUnik)
				{
					newElArr = rnd.Next(10, 100);
					isUnik = IsUnic(arr, newElArr);
				}

				arr[i, j, z] = newElArr;
				isUnik = false;
			}
		}
	}
}

void Print(int[,,] arr)
{

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int z = 0; z < arr.GetLength(2); z++)
		{
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				Console.Write($"{arr[i, j, z]}({i},{j},{z})\t");
			}
		}
		Console.WriteLine();
	}
}

bool IsUnic(int[,,] arr, int el)
{
	bool isUnic = true;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int z = 0; z < arr.GetLength(2); z++)
			{
				if ((arr[i, j, z] == el))
				{
					isUnic = false;
					break;
				}
			}
		}
	}
	return isUnic;

}


