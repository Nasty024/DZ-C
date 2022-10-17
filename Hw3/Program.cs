/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

bool Palindrom (int num)
{
    string numtext = Convert.ToString(num);
    if (num/10000 == num%10 && (num/1000)%10 == (num/10)%10) return true;
    else return false;
}

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
bool palindrom = Palindrom(num);
Console.WriteLine(palindrom);

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2
I - квадрат расстояния

double Distance (double xa, double ya, double xb, double yb, double xc, double yc)
{
    //double squad = Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2);
    //double sqrt = Math.Sqrt(squad);
    return (Math.Sqrt(Math.Pow(ya-xa,2)+Math.Pow(yb-xb,2)+Math.Pow(yc-xc,2))) ;
}

Console.WriteLine("Input xa:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xc:");
double xc = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb:");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yc:");
double yc = Convert.ToDouble(Console.ReadLine());

double dist = Distance(xa,ya,xb,yb,xc,yc);
Console.WriteLine($"Distance {dist}");


Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void cubes (int N)
{
    int num=1;
    while (num <= N)
    {
        double cube = Math.Pow(num,3);
        Console.WriteLine (cube);
        num++;
    }
}

Console.Write("Input number N ");
int N = Convert.ToInt32(Console.ReadLine());
cubes(N);