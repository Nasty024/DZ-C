/*Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double[,] Create2DRandomArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i<rows;i++)
        for(int j = 0; j<columns; j++)
        {
            newArray[i,j] = new Random().NextDouble()*100;
            newArray[i,j] = Math.Round(newArray[i,j], 1);
        }
        return newArray;
}

void Show2DArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] +" ");
        }
         Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double [,] myArray = Create2DRandomArray(m, n);
Show2DArray(myArray);

Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i<rows;i++)
        for(int j = 0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
        return newArray;
}

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] +" ");
        }
         Console.WriteLine();
    }
}

void ProverkaElementa(int[,] array, int i, int j)
{
    if (i > array.GetLength(0) || j > array.GetLength(1)) Console.WriteLine($"{i},{j} -> такого числа в массиве нет");
    if (i < array.GetLength(0) && j < array.GetLength(1)) Console.WriteLine(array[i,j]);

}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int j = Convert.ToInt32(Console.ReadLine());
int [,] myArray = Create2DRandomArray(m, n, min, max);
Console.WriteLine();
Show2DArray(myArray);
Console.WriteLine();
ProverkaElementa(myArray, i,j);

Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i<rows;i++)
        for(int j = 0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
        return newArray;
}

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] +" ");
        }
         Console.WriteLine();
    }
}

void Srednee(int[,] array)
{
   
    for(int j = 0; j < array.GetLength(1);j++)
    {
        double sum = 0;
        double SrednArifm = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        SrednArifm = sum/array.GetLength(1);
        Console.WriteLine(SrednArifm);
       
    }
    
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = Create2DRandomArray(m, n, min, max);
Console.WriteLine();
Show2DArray(myArray);
Console.WriteLine();
Srednee(myArray);
