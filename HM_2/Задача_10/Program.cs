//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine()!);

int B = A / 10;
int C = B % 10;

Console.WriteLine($"Вторая цифра числа {A} = {C}");