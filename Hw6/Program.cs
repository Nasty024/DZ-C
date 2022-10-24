/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

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

void Pozitive(int[] array)
{
    int pozitive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) pozitive++;
    }
    Console.WriteLine($"Количество чисел больше 0 -> {pozitive}");
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
Pozitive(myArray);

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


void Koordinati(int b1, int k1, int b2, int k2)
{
    int x = (b2-b1)/(k1-k2);
    int y = k1*x+b1;
    
    Console.WriteLine($"Координаты точки пересечения двух прямых -> ({x},{y})");
}

Console.WriteLine("Введите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
Koordinati(b1, k1, b2, k2);