// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillingArray(array);
PrintArray(array);

void FillingArray(int[] arr)
{
	Random rnd=new Random();
	for(int i=0; i<arr.Length; i++)
	{
		arr[i]=rnd.Next();
	}
}

void PrintArray(int[] arr)
{
	for(int i=0; i<arr.Length; i++)
	{
		Console.Write($"{arr[i]} ");
	}
}
