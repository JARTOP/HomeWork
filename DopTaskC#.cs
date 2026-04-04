using System;
using System.Runtime.InteropServices;

/*написать функцию, принимающую число N и выводящую список всех элементов Фибоначчи до N. Функция должна быть рекурсивной.*/
public class Task
{
    public static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Числа Фибоначчи до {n}:");
        PrintFiboToN(n);
    }
    public static void PrintFiboToN(int n)
    {
        int start = 0;
        PrintFibo(start, 1, n);
    }
    private static void PrintFibo(int a, int b, int n)
    {
        if (a > n)
        {
            return;
        }
        
        if (a <= n && a != 0 || (a == 0 && n >= 0))
        {
            Console.Write(a + " ");
        }
        PrintFibo(b, a + b, n);
    }
}
