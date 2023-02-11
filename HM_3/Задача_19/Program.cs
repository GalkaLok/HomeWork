//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число: ");
int A = int.Parse(Console.ReadLine()!);

int A1 = A / 10000;
int A5 = A % 10;
int A2 = (A / 1000) % 10;
int A4 = (A / 10) % 10;

if (A1 == A5 & A2 == A4)
{
    Console.WriteLine($"Число {A} палиндром");
}
else
{
    Console.WriteLine($"Число {A} не палиндром");
}
