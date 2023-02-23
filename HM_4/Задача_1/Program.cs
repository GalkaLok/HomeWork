// Подсчитать сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

int count = 1;
int sum = 0;

while (A > 0)
{
    sum = sum + (A % 10);
    A = A / 10;
    count++;
}

Console.WriteLine($"Сумма цифр равна {sum}");
