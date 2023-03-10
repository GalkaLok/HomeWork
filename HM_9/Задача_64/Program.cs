// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

string Recurs(int N)
{
    if (N == 1) return N.ToString();
    else
    {
        return N.ToString() + ", " + Recurs(N - 1);
    }
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recurs(N));
