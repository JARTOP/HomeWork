using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public struct MaxMin
    {
        public int Max {get; set;}
        public int Min {get; set;}
    }
    public static void Main()
    {
            int[] arr = {6,1,5,8,2,3,9,3};
            List<List<int>> matrix = new List<List<int>> 
            {
                new List<int> {2,1,3}, 
                new List<int> {-3,0,67}, 
                new List<int> {-2,7,8}
            };
            
        MaxMin ArrayResult = GetMinMax(arr);    
        Console.WriteLine($"Задание 16.1:\nМаксимум: {ArrayResult.Max} \nМинимум: {ArrayResult.Min}\n");
        
        try 
        {
            MaxMin result = GetMinMax(matrix);    
            Console.WriteLine($"Задание 16.2:\nМаксимум: {result.Max} \nМинимум: {result.Min}");
            Print(matrix);
        }
        
        catch (ArgumentException ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }  
    public static MaxMin GetMinMax(int[] arr)
    {
        if (arr == null)
            throw new ArgumentException("array is null");
        if (arr.Length == 0)
            throw new ArgumentException("array is empty");
    
        int[] sorted = arr.OrderBy(x => x).ToArray();
        return new MaxMin { Max = sorted[sorted.Length - 1], Min = sorted[0] };   
    }
    public static MaxMin GetMinMax(List<List<int>> matrix)
    {
        if (matrix == null)
            throw new ArgumentException("matrix is null");
        List<int> ints = matrix.SelectMany(row => row).OrderBy(x=>x).ToList();
        
        return new MaxMin { Max = ints[ints.Count - 1], Min = ints[0] };
    }
    public static void Print(List<List<int>> matrix)
    {
        Console.WriteLine("\nЗадание 16.3:\nВся матрица:");
        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                
                Console.Write(element + " ");
            }
        Console.WriteLine();
        }
    }
}