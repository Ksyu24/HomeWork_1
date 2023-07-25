// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
FillingArray(array);
Console.WriteLine(OutputArray(array)+"  ->  "+FindCountEvenNum(array));

void FillingArray(int[] arr)
{
	Random rnd=new Random();
	for(int i=0; i<arr.Length; i++)
	{
		arr[i]=rnd.Next(100,1000);
	}
}

string OutputArray(int[] arr)
{
	string result="["+arr[0];
	for(int i=1; i<arr.Length; i++)
	{
		result=result+$", {arr[i]}";
	}
	result=result+"]";
	return result;
}

int FindCountEvenNum(int[] arr)
{
	int count=0;
	for(int i=0; i<arr.Length; i++)
	{
		if(arr[i]%2==0)
		{count++;}
	}
	return count;
}