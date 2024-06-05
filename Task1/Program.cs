/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */

static void PrintRangeOfNumbersMN(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        PrintRangeOfNumbersMN(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        PrintRangeOfNumbersMN(num1 - 1, num2);
    }
    else
    {
        Console.Write($"{num1} ");
    }
}


Console.WriteLine("Input first positive number for M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second positive number for N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < 0 || num2 < 0)
{
    Console.WriteLine("Input error");
}
else
{
    PrintRangeOfNumbersMN(num1, num2);
}

