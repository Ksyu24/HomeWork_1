// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int x=new Random().Next();
int result=FindThirdNum(x);
if (result!=-1)
{
    Console.WriteLine($"Третья цифра числа {x} это {result}");
} 
else {Console.WriteLine($"У числа {x} нет третьей цифры!");}

int FindThirdNum(int num)
{
    int result=-1;
    while(num/1000!=0)
    {
        num=num/10;
    }
    if ((num/100)!=0) {result=((num%10));}
    return result;
}
