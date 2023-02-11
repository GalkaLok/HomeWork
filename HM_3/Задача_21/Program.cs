// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите X первой точки: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y первой точки: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z первой точки: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X второй точки: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y второй точки: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z второй точки: ");
int Z2 = int.Parse(Console.ReadLine()!);

double x = Math.Pow(X1-X2,2);
double y = Math.Pow(Y1-Y2,2);
double z = Math.Pow(Z1-Z2,2);

double c = Math.Sqrt (x+y+z);

Console.WriteLine($"Длина равна {c:f2}");