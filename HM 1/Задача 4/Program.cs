// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Ведите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Ведите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Ведите третье число: ");
int C = int.Parse(Console.ReadLine()!);

int max = A;

if (B > max) max = B;
if (C > max) max = C;


Console.WriteLine($"Максимальное число {max}");
