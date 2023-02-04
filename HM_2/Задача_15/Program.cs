//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введите номер дня недели: ");
int A = int.Parse(Console.ReadLine()!);

if (A>5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}