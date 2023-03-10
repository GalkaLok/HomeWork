// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MatrixMulty(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int value = 0;
            for (int x = 0; x< firstMatrix.GetLength(1); x++)
            {
                value += firstMatrix[i, x] * secondMatrix[x, j];
            }
            result[i, j] = value;
        }
    }
    return result;
}

Console.Write("Введите кол-во строк 1 матрицы: ");
int rowmatrix1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов 1 матрицы: ");
int colmatrix1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во строк 2 матрицы: ");
int rowmatrix2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов 2 матрицы: ");
int colmatrix2 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = GetArray(rowmatrix1, colmatrix1, -10, 10);
PrintArray(matrix1);
Console.WriteLine();

int[,] matrix2 = GetArray(rowmatrix2, colmatrix2, -10, 10);
PrintArray(matrix2);
Console.WriteLine();

if (colmatrix1 != rowmatrix2)
{
    Console.WriteLine("Матрицы не могут быть перемножены");
}
else
{
    int[,] matrixresult = MatrixMulty(matrix1, matrix2);
    PrintArray(matrixresult);
}