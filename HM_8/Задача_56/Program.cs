﻿// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int FindRowMin(int[,] inArray)
{
    int result = 1;
    int minRowSum = 0;
    int sum = 0;
    for (int x = 0; x < inArray.GetLength(0); x++)
    {
        minRowSum += inArray[0, x];
    }
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (sum < minRowSum)
        {
            minRowSum = sum;
            result = i + 1;
        }
        sum = 0;
    }
    return result;
}


    Console.Write("Введите кол-во строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int col = int.Parse(Console.ReadLine()!);

    int[,] array2D = GetArray(row, col, -10, 10);
    PrintArray(array2D);
    int minsum = FindRowMin (array2D);
    Console.WriteLine($"Минимальное число в {minsum} строке");
