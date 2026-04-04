using System;

/*Даны числа a и b. Определите, сколько существует последовательностей из a нулей и b единиц, 
в которых никакие два нуля не стоят рядом.*/
public class Task3
{
    public static void Main()
    {
        Console.Write("Введите количество нулей (a): ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество единиц (b): ");
        int b = int.Parse(Console.ReadLine());
        
        long count = CountSequences(a, b);
        Console.WriteLine($"Количество последовательностей: {count}");
    }
    
    public static long CountSequences(int zeros, int ones)
    {
        // Если нулей больше, чем мест между единицами + 1, то невозможно
        if (zeros > ones + 1)
        {
            return 0;
        }
        
        // Нужно выбрать zeros мест из (ones + 1) возможных
        return Combinations(ones + 1, zeros);
    }
    public static long Combinations(int n, int k)
    {
        if (k < 0 || k > n) return 0;
        if (k == 0 || k == n) return 1;
        
        if (k > n - k)
        {
            k = n - k;
        }
        
        long result = 1;
        for (int i = 1; i <= k; i++)
        {
            result = result * (n - k + i) / i;
        }
        return result;
    }
}