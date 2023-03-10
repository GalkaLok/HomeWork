// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int Recurs(int M, int N)
{
    if (N == M) return N;
    else
    {
        return Recurs(M, N-1) + N;
    }
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Recurs(M, N));