using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class HomeWork1
{
    private List<List<int>> matrix = new List<List<int>> 
        {
             new List<int> {27,1,-31}, 
             new List<int> {-3,0,7}, 
            new List<int> {20,7,80}
        };
    public static void Main()
    {
        HomeWork1 hw = new HomeWork1();
        hw.Print();

        int testNumber = 2015;
        int testSum = hw.GetDigitSum(testNumber);
        Console.WriteLine($"\nЗадание 19.2: {testNumber} = {testSum}\n");

        Console.Write("Введите SUM0: ");
        int sum0 = int.Parse(Console.ReadLine());

        int count = hw.Diagonal(sum0);
        Console.WriteLine($"Количество чисел на побочной диагонали, у которых сумма цифр меньше {sum0}: {count}");
    }
    public void Print()
    {
        System.Console.WriteLine("Задание 19.1:");
        foreach(var row in matrix)
        {
            foreach(var element in row)
            {
                System.Console.Write(element + " ");
            }
        System.Console.WriteLine();
        }
    }

    // Task 19.2:
    public int GetDigitSum(int number)
    {
        int sum = 0;
        number = Math.Abs(number);
        
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        
        return sum;
    }
    public int Diagonal(int sum0)
    {
        int count = 0;
        int n = matrix.Count;
        
        Console.WriteLine("Элементы на побочной диагонали:");
        
        for (int i = 0; i < n; i++)
        {
            int element = matrix[i][n - 1 - i];
            int digitSum = GetDigitSum(element);
            
            Console.WriteLine($"Элемент [{i},{n - 1 - i}] = {element}, сумма цифр: {digitSum}");
            
            if (digitSum < sum0)
            {
                count++;
            }
        }
        
        return count;
    }
}  
   