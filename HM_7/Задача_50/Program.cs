// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Задайте двумерный массив m*n, заполните его случайными целыми числами

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

void ElementCheck(int[,] inArray, int x, int y)
{
    if (x < inArray.GetLength(0) && y < inArray.GetLength(1))
    {
        Console.WriteLine($"Число {inArray[x,y]}");
    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}


Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер строки: ");
int rowNumber = int.Parse(Console.ReadLine()!)-1;
Console.Write("Введите номер столбца: ");
int colNumber = int.Parse(Console.ReadLine()!)-1;

int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
Console.WriteLine();

ElementCheck(array2D, rowNumber, colNumber);


