/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

temp 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

void Sort(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
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
Sort(myArray);
Show2DArray(myArray);

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumRow(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

void RowMinSum(int[,] array)
{
  int minSum = 0;
  int sumRow = SumRow(array, 0);

  for(int i = 1; i < array.GetLength(0);i++)
    {
        int temp = SumRow(array, i);
        if (minSum < temp)
        {
          sumRow = temp;
          minSum = i;
        }
       
    }
  Console.WriteLine($"Индекс строки с наименьшей суммой элементов -> {minSum}");   
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
RowMinSum(myArray);

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

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


void Proizv(int[,] Martrix1, int[,] Martrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      result[i,j] = sum;
    }
  }
}


Console.WriteLine("Введите количество строк 1 матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Martrix1 = Create2DRandomArray(m, n, min, max);
Show2DArray(Martrix1);
Console.WriteLine();
int[,] Martrix2 = Create2DRandomArray(n, p, min, max);
Show2DArray(Martrix2);

int[,] result = new int[m,p];

Proizv(Martrix1, Martrix2, result);
Console.WriteLine($"Произведение матриц");
Show2DArray(result);

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


/*int[,,] Create3DRandomArray(int x, int y, int z)
{
    int[,,] newArray = new int[x, y, z];

    for(int i = 0; i< newArray.GetLength(0);i++)
        for(int j = 0; j< newArray.GetLength(1); j++)
        {
          {
          for (int k = 0; k < newArray.GetLength(2); k++)
          {
            newArray[i,j,k] = new Random().Next(10, 100);
          }
          }
        }
        return newArray;
}

void Show3DArray (int[,,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          for (int k = 0; k < array.GetLength(2); k++)
          {
            Console.Write(array[i, j, k] +" ");
          }
          Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z");
int z = Convert.ToInt32(Console.ReadLine());
int [,,] myArray = Create3DRandomArray(x, y, z);
Console.WriteLine();
Show3DArray(myArray);
*/