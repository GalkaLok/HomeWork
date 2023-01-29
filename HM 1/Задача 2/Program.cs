// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Ведите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Ведите второе число: ");
int B = int.Parse(Console.ReadLine()!);

if (A > B)
{
    Console.WriteLine($"max = {A}");
}
else
{
    Console.WriteLine($"max = {B}");
}