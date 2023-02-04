//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

while (A > 999)
{
    A = A / 10;
}

if (A / 100 < 1)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    A = A % 10;
    Console.WriteLine($"третья цифра {A}");
}
