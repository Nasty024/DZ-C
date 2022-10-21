/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{
    int [] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100,1000);
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

void Chetn(int[] array)
{
    int chetn = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        chetn++;
    }
    Console.WriteLine($"Количество четных чисел -> {chetn}");
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a);
ShowArray(myArray);
Chetn(myArray);

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


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

void NeChetn(int[] array)
{
    int sumnechetn = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!= 0)
        sumnechetn = sumnechetn + array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {sumnechetn}");
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
NeChetn(myArray);

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] CreateRandomArray(int size)
{
    double [] myArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().NextDouble()*100;
    }
    return myArray;
}

void ShowArray(double[] array)
{
    Console.WriteLine("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void Razn(double[] array)
{
    double razn = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }
    razn = max-min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {razn}");
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double [] myArray = CreateRandomArray(a);
ShowArray(myArray);
Razn(myArray);


