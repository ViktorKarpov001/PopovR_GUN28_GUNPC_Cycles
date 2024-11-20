using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1: Массив чисел Фибоначчи
        int[] fibonacciArray = new int[8];
        fibonacciArray[0] = 0;
        fibonacciArray[1] = 1;
        for (int i = 2; i < fibonacciArray.Length; i++)
        {
            fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
        }

        Console.WriteLine("Числа Фибоначчи:");
        foreach (var number in fibonacciArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Задание 2: Массив названий месяцев
        string[] monthsArray = new string[]
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        Console.WriteLine("Названия месяцев:");
        foreach (var month in monthsArray)
        {
            Console.WriteLine(month);
        }

        // Задание 3: Двумерный массив 3x3
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = (int)Math.Pow(i + 2, j + 1);
            }
        }

        Console.WriteLine("Двумерный массив (матрица):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Задание 4: Jagged array
        double[][] jaggedArray = new double[3][];
        jaggedArray[0] = new double[] { 1, 2, 3, 4, 5 };
        jaggedArray[1] = new double[] { Math.E, Math.PI };
        jaggedArray[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

        Console.WriteLine("Jagged array:");
        foreach (var subArray in jaggedArray)
        {
            Console.WriteLine(string.Join(", ", subArray));
        }

        // Задача Б: Работа с двумя массивами
        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

        // Задание 5: Копирование первых 3 элементов первого массива во второй
        Array.Copy(array, 0, array2, array2.Length - 3, 3);

        Console.WriteLine("Массив array2 после копирования:");
        Console.WriteLine(string.Join(", ", array2));

        // Задание 6: Изменение размера первого массива
        Array.Resize(ref array, array.Length * 2);

        Console.WriteLine("Массив array после изменения размера:");
        Console.WriteLine(string.Join(", ", array));
    }
}