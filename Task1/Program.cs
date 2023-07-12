
Console.WriteLine("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

double max;
double min;
 if(a>b)
 {
    max=a;
    min=b;
 }
else {
    max=b;
    min=a;
    }
if (min==max) { Console.WriteLine("Данные числа равные"); }
else {Console.WriteLine("Большее число: " + max + ". Меньшее число: " + min);}
