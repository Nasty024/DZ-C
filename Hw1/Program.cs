// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2) Console.Write("$Max = {num1}, min = {num2} ");
else Console.Write($"Max = {num2}, min = {num1} ");
*/


// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 3 ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1>max) max = num1;
if (num2>max) max = num2;
if (num3>max) max = num3;
Console.WriteLine($"Maximum number is {max}");
*/

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/


// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= num)
    {
        Console.WriteLine(current + " ");
        current = current+2;
    }