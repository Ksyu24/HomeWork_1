// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
try
{
    int day=Convert.ToInt32(Console.ReadLine());
    IsThisDayWeekend(day);
}
catch
{
    Console.WriteLine("Введено неверное значение!");
}


void IsThisDayWeekend(int day)
{
    string dayName="";
    bool weekend=false;
    switch (day)
{
    case 1:
            dayName="Понедельник";
            weekend=false;
            break;

    case 2:
            dayName="Вторник";
            weekend=false;
            break;
    
    case 3:
            dayName="Среда";
            weekend=false;
            break;
            
    case 4:
            dayName="Четверг";
            weekend=false;
            break;

    case 5:
            dayName="Пятница";
            weekend=false;
            break;

    case 6:
            dayName="Суббота";
            weekend=true;
            break;
    
    case 7:
            dayName="Воскресенье";
            weekend=true;
            break;
    
    default:
        Console.WriteLine("Введено неверное значение!");
        break;
}
// if (weekend&&dayName!="")
// {
//     Console.WriteLine($"{dayName} является выходным");
// } 
// else if (!weekend&&dayName!="")
// {
//     Console.WriteLine($"{dayName} не является выходным");
// }
if (weekend&&dayName!="")
{
    Console.WriteLine("Да");
} 
else if (!weekend&&dayName!="")
{
    Console.WriteLine("Нет");
}
}
