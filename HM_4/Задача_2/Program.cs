// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int count = 1;
int product = 1;

while (count <= N)
{
    product = product * count;
    count++;
}

Console.WriteLine($"Произведение равно {product}");
