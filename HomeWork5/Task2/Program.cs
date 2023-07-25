Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int array = new int[10];
FillingArray(array);
ConsoleWriteLine(OutputArray(array)+"  ->  "+FindSumElementsInOddPos(array));

void FillingArray(int[] arr)
{
	Random rnd=new Random();
	for(int i=0; i<arr.Length; i++)
	{
		arr[i]=rnd.Next();
	}
}

string OutputArray(int[] arr)
{
	string result="["+arr[0];
	for(int i=1; i<arr.Length; i++)
	{
		result=result+$", {arr[i]}");
	}
	result=esult+"]";
	return result;
}

int FindSumElementsInOddPos(int[] arr)
{
	int sum=0;
	for(int i=1; i<arr.Length; i+2)
	{
		sum=sum+arr[i];
	}

	return sum;
}
