/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

int SecondNumber(int num)
{
    int second = num/10%10;
    return second;
}

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondNumber(num);
Console.WriteLine($"Second number is {result}");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

  /*if (num<100) Console.WriteLine("Нет третьей цифры");
    while(num >1000)
    {
        num = ((num - (num%10))/10)%10;
        Console.WriteLine($"Третья цифра {num}");
    */
    
void ThirdNumber(int num)
{string numtext = Convert.ToString(num);
if (numtext.Length>2) Console.WriteLine($"Третья цифра {numtext[2]}");
else Console.WriteLine("Третьей цифры нет");
}

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);

/*{
    if (num <0) num = num*(-1);
    if (num > 10000000) num= (num/100000)%10;
    if (num > 1000000) num= (num/10000)%10;
    if (num > 100000) num= (num/1000)%10;
    if (num > 10000) num= (num/100)%10;
    if (num > 1000) num= (num/10)%10;
    if (num > 100) num= num%10;
    if (num > 0) Console.WriteLine("Нет третьего числа");
    Console.WriteLine($"Third number is {num}");
}
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


bool Day(int num)
{
    if (num ==6 || num == 7) return true;
    else return false;
}

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
bool Weekend = Day(num);
Console.WriteLine(Weekend);
*/