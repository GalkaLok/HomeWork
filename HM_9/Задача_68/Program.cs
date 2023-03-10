// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Clear();

int Recurs(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m != 0) return Recurs(m - 1, 1);
    else if (n != 0 && m != 0) return Recurs(m - 1, Recurs(m, n - 1));
    return Recurs(m, n);
}

Console.Write("Введите число m: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Recurs(M, N));