/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

int Stepen(int num1, int num2)
{
    int step = 1;
    for (int i = 0; i<num2; i++)
    {
        step = step*num1;
    }
    return step;
}

Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Stepen(num1, num2);
Console.WriteLine($"{num1} v stepeni {num2} -> {result}");

Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int Sum(int num)
{
    int sum = 0;
    while (num>1)
    {
    sum = sum + num%10;
    num = num/10;
    }
    return sum;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Sum(num);
Console.WriteLine($"Sum of number -> {result}");

/*Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]


int[] CreateRandomArray(int size, int minvalue, int maxvalue)
{
    int [] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minvalue,maxvalue+1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
*/