/* Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n. */

int PrintAkkermanRange(int m, int n)
{ 
   if (m == 0)
   {
    return n + 1;
   }   
   if(m > 0 && n == 0)
   {
    return PrintAkkermanRange (m - 1, 1);
   }
   else
   {
    return PrintAkkermanRange(m - 1, PrintAkkermanRange (m, n - 1));
   }
}


Console.WriteLine("Input first positive number for m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second positive number for n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({num1},{num2}) = {PrintAkkermanRange(num1, num2)}");



