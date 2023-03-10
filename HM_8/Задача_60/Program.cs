// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Get3DArray(int m, int n, int z)
{
    int[,,] result = new int[m, n, z];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int x = 0; x < z; x++)
            {
                result[i, j, x] = new Random().Next(10, 99);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int x = 0; x < inArray.GetLength(2); x++)

            {
                Console.Write($"{inArray[i, j, x]} ({i}, {j}, {x})\t ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту: ");
int hight = int.Parse(Console.ReadLine()!);

int[,,] array3D = Get3DArray(row, col, hight);
PrintArray(array3D);